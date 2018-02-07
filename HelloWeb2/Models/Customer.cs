using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloWeb2.Models
{
    public class Customer
    {
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
    }

    public class calc
    {
        int a, b, c, sum;
        float avg;

        public calc(int d, int e, int f)
        {
            a = d;
            b = e;
            c = f;
        }

        public int calcSum(int a,int b, int c)
        {
            sum = a + b + c;
            return sum;
        }
        public float calcAvg()
        {
            avg = (float)calcSum(a, b, c) / 3;
            return avg;
        }
    }
}