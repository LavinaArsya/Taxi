using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxi_5723
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Taxi taxi = new Taxi();

            taxi.Nama = "Jono";
            taxi.Duty = true;
            taxi.Id = 10;

            taxi.orderan();
            taxi.mengantar();
            taxi.mengantar();

            Console.ReadKey();
        }
    }
}
