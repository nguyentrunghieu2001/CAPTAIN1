using System;
using System.Collections.Generic;
using System.Text;

namespace Thuchanh2
{
    class Data
    {
        private int day, month, year;
        public Data(DateTime dt)
        {
            day = dt.Day;
            month = dt.Month;
            year = dt.Year;
        }
        public void Hien()
        {
            Console.WriteLine("{0}/{1}/{2}", month, day, year);
        }
    }
    class App3
    {
        static void Main4()
        {
            System.DateTime currentTime = System.DateTime.Now;
            Data t = new Data(currentTime);
            t.Hien();
            Console.ReadKey();
        }
    }
}