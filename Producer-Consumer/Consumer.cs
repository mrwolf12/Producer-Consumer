using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producer_Consumer
{
    class Consumer
    {
        public BoundedBuffer Buffer { get; private set; }
        public int HowMany { get; private set; }

        public Consumer(BoundedBuffer buffer, int howMany)
        {
            Buffer = buffer;
            HowMany = howMany;
        }

        public void Run()
        {
            for (int i = 0; i <= HowMany; i++)
            {
                int temp = Buffer.Take();
                //Console.WriteLine("Consumer {0} ", temp);
            }
        }
    }
}
