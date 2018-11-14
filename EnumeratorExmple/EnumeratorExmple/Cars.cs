using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeratorExmple
{
  public  class Cars:IEnumerable,IEnumerator
    {
        int position = -1;
        private Car[] carlist;
        public Cars()
        {
            carlist = new Car[3]
            {
                new Car(1992,"Ford"),
                new Car(1993,"BMW"),
                new Car(1995,"Toyota")
            };


        }

        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }
        public bool MoveNext()
        {
            position++;
            return (position < carlist.Length);
        }
        public object Current
        {
            get
            {
                return carlist[position];
            }
        }


        

        public void Reset()
        {
            position = 0;
        }
    }
}
