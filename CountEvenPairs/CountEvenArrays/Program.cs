using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountEvenArrays
{
    class Program
    {
        static int[] a;
        static void Main(string[] args)
        {
            a = new int[5];
            a[0] = 2;
            a[1] = 1;
            a[2] = 5;
            a[3] = -6;
            a[4] = 9;

            if (!IsInputRangeValid(a) || !IsValuesValid())
            {
                return;
            }

            Console.WriteLine(CountPairs());
            Console.ReadLine();
        }

        static int CountPairs()
        {
            var count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i+1; j < a.Length; j++)
                {
                    var total = a[i] + a[j];
                    if (total % 2 == 0)
                    {
                        count++;
                        Console.WriteLine($"x:{a[i]} y:{a[j]} = {total} -- EVEN");
                    }
                    else
                    {
                        Console.WriteLine($"x:{a[i]} y:{a[j]} = {total}");

                    }
                }
            }

            if (1000000000 < count)
                count = -1;

            return count;
        } 

        static bool IsInputRangeValid(int[] inputs)
        {
            if (50000 < inputs.Length)
            {
                return false;
            }

            return true;
        }

        static bool IsValuesValid()
        {
            var result = true;
            foreach (var i in a)
            {
                if (i < - 1000000000 || 1000000000 < i)
                {
                    return false;
                }
            }

            return result;
        }
    }
}
