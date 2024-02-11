using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Bus
    {
        public string brand;
        public int seats;
        public double ticketPrice;

        public Bus(string brand, int seats, double ticketPrice)
        {
            this.brand = brand;
            this.seats = seats;
            this.ticketPrice = ticketPrice;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Марка: {brand}");
            Console.WriteLine($"Количество мест: {seats}");
            Console.WriteLine($"Стоимость билета: {ticketPrice}");
        }

        public double TotalTicketCost()
        {
            return seats * ticketPrice;
        }
    }
}
