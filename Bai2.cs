using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thuchanh2
{
    class PS
    {
        private int ts, ms;
        public PS()
        {
            ts = 0; ms = 1;
        }
        public PS(int ts, int ms)
        {
            this.ts = ts;
            this.ms = ms;
        }
        public PS(PS t2)
        {
            this.ts = t2.ts;
            this.ms = t2.ms;
        }

        public PS Tong(PS t2)
        {
            PS t = new PS();
            t.ts = this.ts * t2.ms + t2.ts * this.ms;
            t.ms = this.ms * t2.ms;
            return t.Rutgon();
        }
        public PS Hieu(PS t2)
        {
            PS t = new PS();
            t.ts = this.ts * t2.ms - t2.ts * this.ms;
            t.ms = this.ms * t2.ms;
            return t;
        }
        public PS Nhan(PS t2)
        {
            PS t = new PS();
            t.ts = this.ts * t2.ts;
            t.ms = this.ms * t2.ms;
            return t.Rutgon();
        }
        public PS CHIA(PS t2)
        {
            PS t = new PS();
            t.ts = this.ts * t2.ms;
            t.ms = this.ms * t2.ts;
            return t.Rutgon();
        }
        public static bool operator ==(PS t1, PS t2)
        {
            return t1.ts * t2.ms == t2.ts * t1.ms;
        }
        public static bool operator !=(PS t1, PS t2)
        {
            return t1.ts * t2.ms != t2.ts * t1.ms;
        }
        public int UCLN(int ts, int ms)
        {
            ts = Math.Abs(ts); ms = Math.Abs(ms);
            while (ts != ms)
            {
                if (ts > ms) ts = ts - ms;
                if (ts < ms) ms = ms - ts;
            }
            return ts;
        }
        public PS Rutgon()
        {
            int uc = UCLN(this.ts, this.ms);
            this.ts = this.ts / uc;
            this.ms = this.ms / uc;
            return this;
        }
        public void Hien()
        {
            if (ms == 1) Console.WriteLine("{0}", ts);
            else if (ts == 0) Console.WriteLine("{0}", 0);
            else Console.WriteLine("{0}/{1}", ts, ms);
        }
        public static bool operator >(PS t1, PS t2)
        {
            return t1.ts * t2.ms > t2.ts * t1.ms;
        }
        public static bool operator <(PS t1, PS t2)
        {
            return t1.ts * t2.ms < t2.ts * t1.ms;
        }



    }
    class APP
    {
        static void Main2()
        {
            PS t1 = new PS(4, 5);
            PS t2 = new PS(9, 10);
            Console.Write(" Tong 2 phan so la: ");
            PS t = t1.Tong(t2);
            t.Hien();
            Console.Write(" Hieu 2 phan so la: ");
            PS t3 = t1.Hieu(t2);
            t3.Hien();
            Console.Write(" Nhan 2 phan so bang: ");
            PS t4 = t1.Nhan(t2);
            t4.Hien();
            Console.Write(" chia 2 phan so bang: ");
            PS t5 = t1.CHIA(t2);
            t5.Hien();
            if (t1 == t2) Console.WriteLine("Hai phan so bang nhau");
            else Console.WriteLine("Hai phan so khong bang nhau");
            if (t1 > t2) Console.WriteLine("t1>t2");
            else Console.WriteLine("t1<=t2");
            Console.ReadKey();
        }
    }
}
