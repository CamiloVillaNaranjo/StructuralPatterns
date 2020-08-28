using CompositeApp.Component.Composite;
using CompositeApp.Component.Leaf;
using System;

namespace CompositeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var ram = new SimpleProduct("Memoria RAM GigaBit Módulo de 16GB", 150000);
            var processor = new SimpleProduct("Intel Core i7", 750000);
            var videoCard = new SimpleProduct("nVidia GTX 1050", 1500000);
            var keyBoard = new SimpleProduct("Keyboard generic 101 keys - Intel", 20000);
            var mouse = new SimpleProduct("Mouse generic 3 buttons - Intel", 20000);

            var computerGeneric = new CompositeProduct("Computer Gamer Generic");
            computerGeneric.Add(ram);
            computerGeneric.Add(processor);
            computerGeneric.Add(videoCard);
            computerGeneric.Add(keyBoard);
            computerGeneric.Add(mouse);

            Console.WriteLine($"Precio de {ram.Name} es: ${ram.GetPrice().ToString("N2")}");
            Console.WriteLine($"Precio de {computerGeneric.Name} es: ${computerGeneric.GetPrice().ToString("N2")}");

            Console.ReadLine();
        }
    }
}
