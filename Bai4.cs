using System;
using System.Collections.Generic;
using System.Text;

namespace Thuchanh2
{
    class DATHUC
    {
        private int n;
        private int[] a;
        public DATHUC()
        {
            n = 0; a = new int[0];
        }
        public DATHUC(int n)
        {
            this.n = n;
            a = new int[n];
        }
        public void Nhap()
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap a[{0}]=", i);
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        public void Hien()
        {
            for (int i = 0; i < n; i++)
                Console.Write("{0}\n", a[i]);
            Console.WriteLine();
        }
        public DATHUC Tong(DATHUC T2)
        {
            if (this.n == T2.n)
            {
                DATHUC t = new DATHUC(this.n);
                for (int i = 0; i < n; i++)

                    t.a[i] = this.a[i] + T2.a[i];
                return t;
            }
            else return null;
        }
        public DATHUC Hieu(DATHUC T2)
        {
            if (this.n == T2.n)
            {
                DATHUC t = new DATHUC(this.n);
                for (int i = 0; i < n; i++)

                    t.a[i] = this.a[i] - T2.a[i];
                return t;
            }
            else return null;
        }

    }
    class App2
    {
        static void Main3()
        {
            Console.WriteLine("Nhap thong tin da thuc thu 1");
            DATHUC t1 = new DATHUC(4); t1.Nhap();
            Console.WriteLine("Nhap thong tin da thuc thu 2");
            DATHUC t2 = new DATHUC(4); t2.Nhap();

            DATHUC t3 = t1.Tong(t2);
            if (t3 == null)
                Console.WriteLine("Hai da thuc co kich co khac nhau");
            else
            {
                Console.WriteLine("Tong hai da thuc");
                t3.Hien();
            }
            DATHUC t4 = t1.Hieu(t2);
            if (t4 == null)
                Console.WriteLine("Hai da thuc co kich co khac nhau");
            else
            {
                Console.WriteLine("Hieu hai da thuc");
                t4.Hien();
            }
            Console.ReadKey();
        }
    }
}