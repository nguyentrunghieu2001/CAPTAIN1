using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thuchanh2
{
    class Stack
    {
        private int top;
        private int[] s;
        public Stack()
        {
            top = -1;
            s = new int[20];
        }
        public Stack(int n)
        {
            top = -1;
            s = new int[n];

        }
        public bool Full()
        {
            return top == s.Length - 1;
        }
        public bool Empty()
        {
            return top == -1;
        }
        public void Push(int x)
        {
            if (Full()) Console.WriteLine("Stack day");
            else s[++top] = x;
        }
        public int Pop()
        {
            if (Empty()) throw new Exception("Stack rong");
            else
            {
                int x = s[top--];
                return x;
            }
        }
    }
    class Hexa
    {
        private int n;
        private Stack s;
        public void NHAP()
        {

            Console.Write("Nhap so nguyen n=");
            n = int.Parse(Console.ReadLine());

        }
        public void Chuyencoso()
        {
            s = new Stack();
            string st = "0123456789ABCDEF";
            while (n != 0)
            {
                s.Push((int)st[n % 16]);
                n = n / 16;
            }
            while (!s.Empty())
                Console.Write((char)s.Pop());
        }
    }
    class Bai1
    {
        static void Main1(string[] args)
        {
            Hexa t = new Hexa();
            t.NHAP();
            t.Chuyencoso();
            Console.ReadKey();
        }
    }
}