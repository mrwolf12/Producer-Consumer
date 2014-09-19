using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Producer_Consumer
{
    class Program
    {
        static void Main(string[] args)
        {
            BoundedBuffer buffer = new BoundedBuffer(4);
            Producer producer = new Producer(buffer, 10000);
            Consumer consumer = new Consumer(buffer, 10000);
            
            Parallel.Invoke(producer.Run, consumer.Run);



            //Thread t1 = new Thread(() => producer.Run());
            //Thread t2 = new Thread(() => consumer.Run());
            //t1.Start();
            //t2.Start();
        }
    }
}
