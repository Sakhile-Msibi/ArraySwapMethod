using System;

namespace ArraySwapMethod
{
    class Program
    {
        public int[] reverseArray(int[] arr, int d)
        {
            int[] A = new int[d];
            int len = Math.Abs(arr.Length - d);
            int[] B = new int[len];
            int j = 0;

            for (int i = 0; i < d; i++)
            {
                A[i] = arr[i];
            }

            for (int i = d; i < (len + d); i++)
            {
                B[j] = arr[i];
                j++;
            }

            j = 0;

            if (d < len)
            {
                int[] Bl = new int[len - d];
                int[] Br = new int[d];

                for (int i = 0; i < (len - d); i++)
                {
                    Bl[i] = B[i];
                }

                for (int i = (len - d); i < len; i++)
                {
                    Br[j] = B[i];
                    j++;
                }

                j = 0;

                for (int i = 0; i < Bl.Length; i++)
                {
                    arr[i] = Bl[i];
                    j++;
                }

                for (int i = 0; i < Br.Length; i++)
                {
                    arr[j] = Br[i];
                    j++;
                }

                for (int i = 0; i < A.Length; i++)
                {
                    arr[j] = A[i];
                    j++;
                }
            }
            else if (d > len)
            {
                int[] Al = new int[len];
                int[] Ar = new int[d - len];

                for (int i = 0; i < len; i++)
                {
                    Al[i] = A[i];
                }

                for (int i = len; i < d; i++)
                {
                    Ar[j] = A[i];
                    j++;
                }

                j = 0;

                for (int i = 0; i < B.Length; i++)
                {
                    arr[i] = B[i];
                    j++;
                }

                for (int i = 0; i < Al.Length; i++)
                {
                    arr[j] = Al[i];
                    j++;
                }

                for (int i = 0; i < Ar.Length; i++)
                {
                    arr[j] = Ar[i];
                    j++;
                }
            }
            else
            {
                j = 0;
                for (int i = 0; i < B.Length; i++)
                {
                    arr[i] = B[i];
                    j++;
                }

                for (int i = 0; i < A.Length; i++)
                {
                    arr[j] = A[i];
                    j++;
                }
            }

            return arr;
        }

        static void Main(string[] args)
        {
            Program program = new Program();

            int[] arr = { 1, 2, 3, 4, 5, 6 };
            int d = 3;

            arr = program.reverseArray(arr, d);

            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
        }
    }
}
