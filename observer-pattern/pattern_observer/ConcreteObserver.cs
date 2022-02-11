using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_observer
{
    public class ConcreteObserver : IObserver
    {
        private int counter = 0;
        public void UpDate()
        {
            counter = counter + 1;
        }

        public int GetCounter()
        {
            return counter;
        }
    }
}
