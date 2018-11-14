using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeratorExmple
{
  public class Car
    {
        public int Year { get; set; }
        public string Company { get; set; }
        public Car(int year,string company)
        {
            this.Year = year;
            this.Company = company;
        }
    }


}
