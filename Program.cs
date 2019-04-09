using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            //Membuat instan Class / object
            Time objTime = new Time(2019, 10, 10, 10, 30, 40);

            /*Memanggil method pada class tersebut
            objTime.DisplayCurrentTime();*/

            /*memberi nilai property
            objTime.Year = 2000;
            objTime.Month = 5;
            objTime.Date = 1;*/

            //Mengambil Nilai Dengan Property
            Console.WriteLine("Year : {0}", objTime.Year.ToString());
            Console.WriteLine("Month : {0}", objTime.Month.ToString());
            Console.WriteLine("Date : {0}", objTime.Date);
            Console.WriteLine("Hour : {0}", objTime.Hour);
            Console.WriteLine("Minute : {0}", objTime.Minute);
            Console.WriteLine("Second : {0}", objTime.Second);
            Console.ReadKey();
        }
    }
}
