﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_2
{
    class CALC
    {
        public static int Multi(int x,int y)
        {
            return x * y;
        }
        public static int Power(int x)
        {
            return x * x;
        }
        public static int Add(int x, int y)
        {
            return x + y;

        }
        public static int Str(int x, int y)
        {
            return x - y;

        }
        public static double Div(double x, double y)
        {
            return Math.Round(((x / y) + (x % y)),2);
        }

        public static int Summy(int x, int y)
        {
            int mary = 0;
            for (int i = x; i <= y; i++)
            {
                mary = mary + i;

            }
            return mary;


        }
        public static double Abs(double x)
        {
            double absy;
            absy = Math.Sqrt(x * x);

            return absy;
        }
        public static int Abs(int x)
        {
            int absy;
            absy = (int)Math.Sqrt(x * x);

            return absy;
        }
        public static float Abs(float x)
        {
            float absy;
            absy = (float)Math.Sqrt(x * x);

            return absy;
        }
        public static long Abs(long x)
        {
            long absy;
            absy = (long)Math.Sqrt(x * x);

            return absy;
        }

    }
}
