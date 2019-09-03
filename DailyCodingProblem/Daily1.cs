using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Given a list of numbers and a number k, return whether any two numbers from the list add up to k.

    For example, given[10, 15, 3, 7] and k of 17, return true since 10 + 7 is 17.
 */

namespace Daily1
{
    class Daily1
    {
        static void Main(string[] args)
        {
            List<int> numList = new List<int>
            {
                10,
                9,
                3,
                1,
                5,
                4
            };

            int k = 15;
            bool result = false;

            for (int i = 0; i < numList.Count; i++)
            {
                var currentVal = numList[i];
                var remainingVal = k - currentVal;

                if (numList.IndexOf(remainingVal) > 0 && remainingVal != currentVal)
                {
                    result = true;
                    break;
                }
            }

            Console.WriteLine(result
                ? "This list having those two numbers"
                : "This list not having those two numbers.");

            Console.ReadKey();
        }
    }
}
