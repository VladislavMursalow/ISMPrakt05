using System;
using System.Linq;

namespace LibForArray
{
    public static class ArrayTasks
    {
        //сума від’ємних елементів масиву
        public static int SumOfNegativeElementsOfArray(int [] arr) 
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++) 
            {
                if (arr[i] < 0) sum += arr[i];
            }

            return sum;
        }

        //максимальний серед парних елементів масиву
        public static int FindMaxElementFromEvenNumbersOfArray(int[] arr) 
        {
            int max = arr.Min(); //найменший елемент масиву спочатку буде максимальнийм

            for (int i = 0; i < arr.Length; i++) 
            {
                if (arr[i] % 2 == 0) 
                {
                    if (max < arr[i]) max = arr[i];
                }
            }

            if (max % 2 != 0) return -1; //випадок, коли в масиві немає парних чисел,
                                         //а max просто зберігає найменший з елементів масиву,
                                         //який також непарний

            return max;
        }

        //добуток елементів масиву, що мають парні індекси
        public static int FindProductOfEvenIndexesOfArray(int[] arr) 
        {
            int product = 1;

            for (int i = 0; i < arr.Length; i+=2)
            {
                product *= arr[i];
            }

            return product;
        }

        //номер (індекс) максимального елемента масиву
        public static int FindIndexOfMaxElementOfArray(int[] arr)
        {
            int index = 0;

            int maxNumber = arr.Min();

            for (int i = 0; i < arr.Length; i++)
            {
                if (maxNumber < arr[i]) 
                {
                    maxNumber = arr[i];
                    index = i;
                }
            }

            return index;
        }

        //максимальний за модулем елемент масиву
        public static int MaxElementWithAbs(int[] arr)
        {
            int maxNumber = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (Math.Abs(maxNumber) < Math.Abs(arr[i]))
                {
                    maxNumber = arr[i];
                }
            }

            return maxNumber;
        }

        //сума індексів додатних елементів
        public static int SumOfIndexsPositiveNumbers(int[] arr)
        {
            int sumOfIndexes = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]>0)
                {
                    sumOfIndexes += i;
                }
            }

            return sumOfIndexes;
        }

        //кількість непарних елементів масиву
        public static int CountOfOddElements(int[] arr) 
        {
            int count = 0;

            for (int i = 0; i < arr.Length; i++) 
            {
                if (arr[i] % 2 != 0) count++;
            }

            return count;
        }

        //метод заповнює масив рандомними числами
        public static void GenerateRandomArr(ref int[] arr, int min, int max) 
        {
            Random rand = new Random();

            for (int i = 0; i < arr.Length; i++) 
            { 
                arr[i] = rand.Next(min, max+1);
            }
        }
        
    }
}
