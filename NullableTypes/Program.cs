using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Nullable<DateTime> date = null;

//            Console.WriteLine("GetValueOrDefault: " + date.GetValueOrDefault());
//            Console.WriteLine("HasValue: " + date.HasValue);
//            Console.WriteLine("Value" + date.Value);

            DateTime? datetime = new DateTime(2014, 1, 1);
            DateTime date2 = datetime.GetValueOrDefault();
            DateTime? date3 = date2;


            Console.WriteLine(datetime);
            Console.WriteLine(date2);
            Console.WriteLine(date3);

            // Null coalesing operator

            DateTime? date4 = null;
            DateTime date5;

            if (date4 != null)
                date5 = date.GetValueOrDefault();
            else 
                date5 = DateTime.Today;

            Console.WriteLine(date5);

            // If date4 has a value assign it, otherwise the other one
            DateTime date6 = date4 ?? DateTime.Today;
        }
    }
}
