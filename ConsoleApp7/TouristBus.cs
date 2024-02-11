using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class TouristBus:Bus
    {
        public double excursionCost;

        public TouristBus(string brand, int seats, double ticketPrice, double excursionCost) : base(brand, seats, ticketPrice)
        {
            this.excursionCost = excursionCost;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Стоимость экскурсии: {excursionCost}");
        }

        public new double TotalTicketCost() // переопределенный метод для учета увеличения цены билетов за экскурсию
        {
            return seats * (ticketPrice + excursionCost);
        }
    }
}

