using MarsRover.ConsoleApp.Model;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace MarsRover.ConsoleApp
{
    public class Program
    {
        private static IServiceProvider _serviceProvider;
        static void Main(string[] args)
        {
            ConfigureServices();

            IPositionService positionService = _serviceProvider.GetService<IPositionService>();

            Plateau plateau = new Plateau(5, 5);
            Position position = new Position(1, 2, Directions.N);
            string moves = "LMLMLMLMM";
            Move move = new Move
            {
                Position = position,
                Plateau = plateau,
                Moves = moves
            };

            var result_12N = positionService.StartMoving(move);
            Console.WriteLine($"{result_12N.X} {result_12N.Y} {result_12N.Direction}");

            position = new Position(3, 3, Directions.E);
            moves = "MMRMMRMRRM";
            move = new Move
            {
                Plateau = plateau,
                Position = position,
                Moves = moves
            };
            var result_33E = positionService.StartMoving(move);
            Console.WriteLine($"{result_33E.X} {result_33E.Y} {result_33E.Direction}");


            Console.ReadLine();
        }


        private static void ConfigureServices()
        {
            ServiceCollection services = new ServiceCollection();
            services
                .AddOptions().AddScoped<IPositionService, PositionService>();
            _serviceProvider = services.BuildServiceProvider();
        }
   
    }
}
