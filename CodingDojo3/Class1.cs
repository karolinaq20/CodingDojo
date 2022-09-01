using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingDojo3
{
    public class CashMachine
    {
        public int[] Withdraw(int totalValue)
        {
            if (totalValue % 10 != 0 || totalValue <= 0)
            {
                throw new InvalidValueException();
            }

            if (notes.Contains(totalValue))
                return new[] { totalValue };

            var result = new List<int>();

            while (totalValue != 0)
            {
                if(totalValue >= 100)
                {
                    totalValue -= 100;
                    result.Add(100);
                }
               else if (totalValue >= 50)
                {
                    totalValue -= 50;
                    result.Add(50);
                }
               else if (totalValue >= 20)
                {
                    totalValue -= 20;
                    result.Add(20);
                }
                else
                {
                    totalValue -= 10;
                    result.Add(10);
                }

            }
            return result.ToArray();
        }

        private readonly static int[] notes = new[] { 10, 20, 50, 100 };
    }

    public class InvalidValueException : Exception
    {


    }
}
