using System;
using LibForArray;
namespace ConsoleAppPract05
{
    class Program
    {
        //Handle for all funk in lib for short code
        public delegate int MyFunction(int [] arr);


        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Введіть кількіть елементів масиву:");

            SaveConsoleInput(out n);

            if (n <= 0) Console.WriteLine("кількість елементів не може бути від'ємною або = 0!");
            else
            {
                int[] arr = new int[n];

                ArrayTasks.GenerateRandomArr(ref arr, -10, 10);

                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write($"arr[{i}] = {arr[i]}\n");
                }

                Console.Write('\n');

                ShortOutputCodeFunk(ArrayTasks.SumOfNegativeElementsOfArray, arr, "сума від’ємних елементів масиву: ");

                ShortOutputCodeFunk(ArrayTasks.FindMaxElementFromEvenNumbersOfArray, arr, "максимальний серед парних елементів масиву: ");

                ShortOutputCodeFunk(ArrayTasks.FindProductOfEvenIndexesOfArray, arr, "добуток елементів масиву, що мають парні індекси: ");

                ShortOutputCodeFunk(ArrayTasks.FindIndexOfMaxElementOfArray, arr, "номер (індекс) максимального елемента масиву: ");

                ShortOutputCodeFunk(ArrayTasks.MaxElementWithAbs, arr, "максимальний за модулем елемент масиву: ");

                ShortOutputCodeFunk(ArrayTasks.SumOfIndexsPositiveNumbers, arr, "суму індексів додатних елементів: ");

                ShortOutputCodeFunk(ArrayTasks.CountOfOddElements, arr, "кількість непарних елементів масиву: ");

            }
        }

        static void ShortOutputCodeFunk(MyFunction funk, int [] arr, string task = "no task") 
        {
            int result = funk(arr);
            Console.WriteLine(task + result);
        }

        static void SaveConsoleInput(out int N) 
        {
            int number;
            while (!int.TryParse(Console.ReadLine(), out number)) 
            {
                Console.Write("В ввели неправильно число!\nПовторіть ще раз -> ");
            }

            N = number;
        } 
    }
}
