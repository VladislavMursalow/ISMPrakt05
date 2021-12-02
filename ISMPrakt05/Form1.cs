using System;
using System.Windows.Forms;
using LibForArray;

namespace ISMPrakt05
{
    public partial class Form1 : Form
    {
        //Handle for all funk in lib for short code
        public delegate int MyFunction(int[] arr);

        int[] arr;
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateResultsButton_Click(object sender, EventArgs e)
        {
            arr = new int[(int)NnumericUpDown.Value];

            ArrayTasks.GenerateRandomArr(ref arr ,- 10, 10);

            OutputArrayToTextBox(arr, OutputTextBox);
            outputResultsToTextBoxes();
        }

        void ShortOutputToTextBoxeCodeFunk(MyFunction funk, int[] arr, TextBox tb)
        {
            int result = funk(arr);
            tb.Text = result.ToString();
        }

        void outputResultsToTextBoxes() 
        {
            ShortOutputToTextBoxeCodeFunk(ArrayTasks.SumOfNegativeElementsOfArray, arr, taskOneTextBox);

            ShortOutputToTextBoxeCodeFunk(ArrayTasks.FindMaxElementFromEvenNumbersOfArray, arr, taskTwoTextBox);

            ShortOutputToTextBoxeCodeFunk(ArrayTasks.FindProductOfEvenIndexesOfArray, arr, taskTreeTextBox);

            ShortOutputToTextBoxeCodeFunk(ArrayTasks.FindIndexOfMaxElementOfArray, arr, taskFourTextBox);

            ShortOutputToTextBoxeCodeFunk(ArrayTasks.MaxElementWithAbs, arr, taskFiveTextBox);

            ShortOutputToTextBoxeCodeFunk(ArrayTasks.SumOfIndexsPositiveNumbers, arr, taskSixTextBox);

            ShortOutputToTextBoxeCodeFunk(ArrayTasks.CountOfOddElements, arr, taskSevenTextBox);

            ShortOutputToTextBoxeCodeFunk(ArrayTasks.SumOfNegativeElementsOfArray, arr, taskOneTextBox);
        }

        void OutputArrayToTextBox(int[] arr, TextBox tb) 
        {
            tb.Text = "";
            for (int i = 0; i < arr.Length; i++) 
            {
                tb.Text += $"arr[{i}] = {arr[i]} {Environment.NewLine}";   
            }
        }

        private void OutputTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
