
using Models;
using System;

namespace ConsoleApp4POO
{
    class Program
    {
        /// <summary>
        /// POO herencia
        /// permite derivar una clase de otra, por lo tanto habra clases hijos y clases padres
        /// se podria simular heredar de 2 clases con composicion, ver ducktoy
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            Duck duck = new Duck()
            {
                Color = "amarillo",
                Race = "normal"
            };

            Console.WriteLine($"duck: {duck.ToString()}");

            Duck duck2 = new Duck()
            {
                Color = "blanco"
            };

            Console.WriteLine($"duck2: {duck2.ToString()}");

            Duck duck3 = new Duck()
            {
                Race = "normal"
            };

            Console.WriteLine($"duck3: {duck3.ToString()}");

            DuckToy ducktoy = new DuckToy("amarillo","normal","goma",2);

            Console.WriteLine($"Ducktoy: {ducktoy.ToString()}");

            Motorcycle moto = new Motorcycle()
            {
                Brand = "marca",
                Displacement = 200,
                MaxVelocity = 100,
                Model = "modelo",
                WheelQuantity = 2
            };

            Console.WriteLine($"moto: {moto.ToString()}");
        }
    }
}
