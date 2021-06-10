using System;
using System.Collections.Generic;

namespace RunningMedian
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>
            { 12, 4, 5, 3, 8, 7 };

            var result = Result.RunningMedian(numbers);

            for(int i =0; i< result.Count; i++)
            {
                Console.WriteLine("{0:0.0}", result[i]);
            }
        }
    }

    class Result
    {
        public static List<double> RunningMedian(List<int> a)
        {
            var temp = new List<int>();
            var result = new List<double>();

            for (int i = 0; i < a.Count; i++)
            {
                temp.Add(a[i]);
                temp.Sort();
                temp.Reverse();

                if (temp.Count % 2 == 0)
                {
                    var indice1 = (int)Math.Floor((decimal)i / 2);
                    var indice2 = indice1 + 1;

                    double median = (float)(temp[indice1] + temp[indice2]) / 2;
                    result.Add(median);
                }
                else
                {
                    var indice = (int)Math.Floor((decimal)i / 2);
                    result.Add(temp[indice]);
                }
            }

            return result;
        }
    }
}
