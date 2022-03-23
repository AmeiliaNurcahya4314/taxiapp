using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    public class Taxi
    {
        //properties
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public float NumPassenger { get; set; }
        public string keterangan { get; set; }

        //method
        public void TaxiInfo()
        {
            Console.WriteLine("======================");
            Console.WriteLine("Driver name: {0}", DriverName);
            if(OnDuty == true)
            {
                keterangan = "yes";
            }
            else
            {
                keterangan = "no";
                
            }
            Console.WriteLine("OnDuty: {0}", keterangan);
            Console.WriteLine("Num Passenger: {0}\n", NumPassenger);
            Console.WriteLine("----------------------");

        }
        public void PickUpPassenger()
        {
            Console.WriteLine("{0} sedang menjemput penumpang", DriverName);
        }
        public void DropOffPassenger()
        {
            Console.WriteLine("{0} selesai mengantar penumpang\n", DriverName);
            Console.WriteLine("=======================");
        }
        
    }
}
