using Microsoft.Extensions.DependencyInjection;
using RastreadorPaquetesService;
using RastreadorPaquetesService.Interfaces;
using System;
using System.Collections.Generic;
using Utilidades;
using Utilidades.Interfaces;

namespace RastreadorPaquetes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ConstructorMensajePedidos constructorMensaje = new ConstructorMensajePedidos();

                IProcesadorPedidos procesador = CrearDependencias(constructorMensaje).GetService<IProcesadorPedidos>();

               List<MensajePedidoDto> respuesta = procesador.ProcesarPedidos(constructorMensaje);

                foreach (MensajePedidoDto pedidoDto in respuesta)
                {
                    Console.ForegroundColor = pedidoDto.ColorMensaje;

                    Console.WriteLine(pedidoDto.Mensaje);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            catch(Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
            }
        }

        protected static IServiceProvider CrearDependencias(ConstructorMensajePedidos constructorMensajePedidos)
        {
            //setup our DI
            IServiceProvider serviceProvider = new ServiceCollection()
                .AddSingleton<ILectorArchivos, LectorArchivos>()
                .AddSingleton<IConstructorRespuestaPedido, ConstructorMensajePedidos>()
                .AddSingleton<ICreadorPedidos, CreadorPedidos>()

                .AddSingleton<IDirectorMensajePedidos>
                (x=>new DirectorMensajePedidos(constructorMensajePedidos,x.GetRequiredService<IValidadorFecha>(),x.GetRequiredService<IManejadorRangoTiempo>(),x.GetRequiredService<ICreardorDetallesPedido>()))
                .AddSingleton<IManejadorPaqueteria, ManejadorPaqueteria>()
                .AddSingleton<IManejadorRangoTiempo, ManejadorRangoTiempo>()
                .AddSingleton<IProcesadorPedidos, ProcesadorPedidos>()
                .AddSingleton<IProductorDePaqueteriasFactory, ProductorDePaqueteriasFactory>()
                .AddSingleton<IValidadorFecha, ValidadorFecha>()
                .AddSingleton<IVerificadorPrecios,VerificadorPrecios>()
                .AddSingleton<IPaqueteriaService,PaqueteriaService>()
                .AddSingleton<ICreardorDetallesPedido, CreadorDetallesPedido>()
                .BuildServiceProvider();
            return serviceProvider;
        }
    }
}
