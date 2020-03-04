using System;

namespace SmallerThanCurrent
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] nums = { 8, 1, 2, 2, 3 };
            SmallerThanCurrent(nums);
        }
        static void SmallerThanCurrent(int[] N)
        {
            int[] smallarr = new int[N.Length];

            int k = 0;
            for (int i = 0; i < N.Length; i++)

            {
                int count = 0;
                for (int j = 0; j < N.Length; j++)
                    if (N[i] != N[j])
                    {
                        if (N[i] > N[j])
                            count++;
                    }

                smallarr[k] = count;
                k++;

            }

            foreach (int i in smallarr)
            {
                Console.Write(i);
            }

        }
    }
}



