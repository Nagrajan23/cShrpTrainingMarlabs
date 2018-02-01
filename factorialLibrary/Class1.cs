using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace factorialLibrary
{
    public class Factorial
    {
        /*public BigInteger Calculate(BigInteger number)
        {
            BigInteger result = number;
            for(int i = 1; i<number; i++)
            {
                result = result * i;
            }
            return result;
        }//*/

        public delegate void SendResult(BigInteger number);
        //public SendResult WhereToSend;

        //Events cannot publish data
        public event SendResult WhereToSend;
        public void Calculate(BigInteger number)
        {
            BigInteger result = number;
            for (int i = 1; i < number; i++)
            {
                result = result * i;
            }
            WhereToSend(result);
        }
    }
}
