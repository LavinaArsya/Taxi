using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxi_5723
{
    internal class Taxi
    {
        public string Nama { get; set; }
        public bool Duty { get; set; }
        public float Id { get; set; }


        public void orderan()
        {
            Console.WriteLine("Driver Name: {0}", Nama);
            Console.WriteLine("On Duty: {0}", (Duty ? "Yes" : "No"));
            Console.WriteLine("Number of Passenger: {0}\n", Id);
        }

        public void menjemput()
        {
            Console.WriteLine("Jono sedang menjemput penumpang");
        }

        public void mengantar()
        {
            Console.WriteLine("Jono selesai mengantar penumpang");
        }
    }
}
