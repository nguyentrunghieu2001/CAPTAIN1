using System;
using System.Collections.Generic;
using System.Text;

namespace Thuchanh2
{
    class Queue
    {
        private int dau, cuoi;
        private int[] q;
        public Queue()
        {
            dau = cuoi = 0;
            q = new int[20];
        }
        public Queue(int n)
        {
            dau = cuoi = 0;
            q = new int[n];

        }
        public bool isFull()
        {
            return cuoi >= q.Length - 1;
        }
        public bool isEmpty()
        {
            return dau == 0;
        }
        public void Push(int x)
        {
            if (isFull()) Console.WriteLine("Stack day");
            else
            {
                cuoi++;
                q[cuoi] = x;
            }
        }
        public int Pop()
        {
            if (isEmpty()) throw new Exception("Stack rong");
            else
            {
                int x = q[dau];
                dau--;
                return x;
            }
        }
    }
}

