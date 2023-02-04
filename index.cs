using System;

namespace betterHomework2_2
{
    class Program
    {
        public static int myFunc(int[] arr, int i)
        {
            int[] memo = new int[i + 1];
            for(int j=0; j < memo.Length; j++)
            {
                memo[j] = -2;
            }
            return myFunc(arr, i, memo);
        }

        public static int myFunc(int[] arr, int i, int[] memo)
        {

            if (i == 0)
            {
                return arr[i];
            }
            else if (i == 1)
            {
                return arr[i] + arr[i - 1];
            }
            else if (memo[i] != -2)
            {
                return memo[i];
            }
            else
            {
                int x = myFunc(arr, i - 1);
                int y = myFunc(arr, i - 2);
                if (x <= y)
                {
                    memo[i] = arr[i] + x;
                    return memo[i];
                }
                else
                {
                    memo[i] = arr[i] + y;
                    return memo[i];
                }
            }
        }

        static void Main(string[] args)
        {
            const int N1 = 6, N2 = 22, N3 = 5, N4 = 11;
            int path1, path2, path3, path4, 
                start_index1 = N1 - 1, start_index2 = N2 - 1,
                start_index3 = N3 - 1, start_index4 = N4 - 1;
            int[] arr1 = new int[N1] { 0, 3, 80, 6, 57, 10 };
            int[] arr2 = new int[N2] { 0, 23, 25, 63, 23, 24, 64,
51,52, 59, 58, 38, 39, 41, 24, 25, 43, 50, 52, 54, 53, 55 };
            int[] arr3 = new int[N3] { 0, 3, 5, 8, 1 };
            int[] arr4 = new int[N4] { 0, 4, 58, 3, 47, 2,
 36, 1, 23, 5, 25 };

            
             path1 = myFunc(arr1, start_index1);
             path2 = myFunc(arr2, start_index2);
             path3 = myFunc(arr3, start_index3);
             path4 = myFunc(arr4, start_index4);

            
            Console.WriteLine("The smallest path is:" + path1);
            Console.WriteLine("The smallest path is:" + path2);
            Console.WriteLine("The smallest path is:" + path3);
            Console.WriteLine("The smallest path is:" + path4);

        }
    }
}
