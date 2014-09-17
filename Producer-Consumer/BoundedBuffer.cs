﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Producer_Consumer
{
    public class BoundedBuffer
    {
        private Queue<int> number = new Queue<int>(); 
        public int Capactiy { get; private set; }


        public BoundedBuffer(int capacity)
        {
            Capactiy = capacity;
        }

        public bool IsFull()
        {
            return number.Count == Capactiy;
        }


        public void Put(int element)
        {
            Monitor.Enter(number);

            while (IsFull())
            {
                Monitor.Wait(number);
            }

            number.Enqueue(element);
            Monitor.PulseAll(number);
        }

        public int Take()
        {
            Monitor.Enter(number);

            while (number.Count == 0)
            {
                Monitor.Wait(number);
            }
            int element = number.Dequeue();
            Monitor.PulseAll(number);
            return element;
        }
    }
}
