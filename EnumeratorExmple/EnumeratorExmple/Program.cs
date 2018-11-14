using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeratorExmple
{
    class Program
    {
        static void Main(string[] args)
        {
            Cars cars = new Cars();
            foreach (Car item in cars)
            {
                Console.WriteLine(item.Company+" "+item.Year);
            }
        }
    }
}
