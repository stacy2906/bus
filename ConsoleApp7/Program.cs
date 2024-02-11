using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bus bus = new Bus("Volvo", 50, 10);
            Console.WriteLine("Информация обычного автобуса:");
            bus.PrintInfo();
            Console.WriteLine($"Общая стоимость всех мест: {bus.TotalTicketCost()}");

            Console.WriteLine();

            TouristBus touristBus = new TouristBus("Mercedes", 40, 15, 5);
            Console.WriteLine("Информация о туристическом автобусе:");
            touristBus.PrintInfo();
            Console.WriteLine($"Общая стоимость всех мест с учетом экскурсии: {touristBus.TotalTicketCost()}");
            Console.ReadKey();
        }
    }
}
