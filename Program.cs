using System;

namespace ConsoleAppSortASC
{
    class SortArray
    {
        public void LowToHigh(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 1 + i; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            Console.Write("Array list after sorting : ");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int temp;
            int[] arr; 
            arr = new int[5];
            Console.WriteLine(" Enter the array element : " );
            for (int i = 0; i < arr.Length; i++)
            {
                
                arr[i] = Convert.ToInt32(Console.ReadLine());
             
            }
            new SortArray().LowToHigh(arr);
            
        }
    }
}
