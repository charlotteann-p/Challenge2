using System;

namespace CodingChallenge2
{
    class Program
    {
        public static int DiffBetweenStrings(string str1, string str2)
        {
            //str1 = "this";
            //str2 = "that";
            //var str1Array = str1.Split()[str1.Length + 1];  
            //var str2Array = str2.Split()[str2.Length];
            var diff = new int[str1.Length + 1];
            var sum = 0;

            for (int i = 0; i < str1.Length; i++)
            {
                var ascii1 = (int)str1[i];
                var ascii2 = (int)str2[i];
                int difference = ascii1 - ascii2;
                diff[i] = difference;
                sum += Math.Abs(difference);
                //diff[i] = ascii1 - ascii2;
            }
            //var sumDiff = diff.Sum();
            //return diff;

            Console.WriteLine(sum);
            return sum;
        }
        static void Main()
        {
            DiffBetweenStrings("bear", "this");
            Console.WriteLine("help");
        }
    }
}     
