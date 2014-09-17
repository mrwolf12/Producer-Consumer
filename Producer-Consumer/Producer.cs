using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Producer_Consumer
{
    public class Producer
    {
        public BoundedBuffer Buffer { get; private set; }
        public int HowMany { get; private set; }
        public static int LastElement = -1;

        public Producer(BoundedBuffer buffer, int howMany)
        {
            if (buffer == null)
            {
                throw new ArgumentNullException("Buffer is null");
            }
            if (HowMany < 0)
            {
                throw new ArgumentOutOfRangeException("howMany is out of range");
            }
            Buffer = buffer;
            HowMany = howMany;
        }

        public void Run()
        {
            for (int i = 0; i < HowMany; i++)
            {
                Buffer.Put(HowMany);
                Console.WriteLine("Producer " + i);
            }
        }
    }
}
