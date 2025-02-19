﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace A68
{
    class Date
    {
        private int year, month, day;

        public Date()
        {
            year = 1;
            month = 1;
            day = 1;
        }

        public Date(int y, int m, int d)
        {
            year = y;
            month = m;
            day = d;
        }

        public void PrintDate()
        {
            Console.WriteLine("{0}/{1}/{2}", year, month, day);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Date birthday = new Date(2000,11,22);
            Date xmas = new Date(2024, 12, 25);
            Date firstDat = new Date();

            birthday.PrintDate();
            xmas.PrintDate();
            firstDat.PrintDate();  
        }
    }
}
