using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace Sorting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SelectionButton_Click(object sender, EventArgs e)
        {
            SelectionSortExample();
        }

        private void QuickButton_Click(object sender, EventArgs e)
        {
            QuickSortExample();
        }

        void SelectionSortExample()
        {
            SelectionListBox.Items.Clear(); //Clear the listbox first each time the button is pressed.
            int[] array = GenerateArray(); //Call the function and return a array of random integers.
            if (array != null) //Only run this code if a valid array was returned (length > 0).
            {
                SelectionListBox.Items.Add("Unsorted Items");
                DisplayArrayValues(array, SelectionListBox); //Call method and pass it the array and the SelectionListbox
                Stopwatch watch = new Stopwatch(); //Create a new stopwatch to time the sort algorithm in milliseconds.
                watch.Start(); // Start the stopwatch.
                SelectionSort(array); //Call the sort method and pass it the array to be sorted.
                watch.Stop(); //Stop the stopwatch.
                SelectionWatchLabel.Text = watch.ElapsedMilliseconds.ToString() + "ms"; //Display the stopwatch count in the label.
                SelectionListBox.Items.Add("Sorted Items");
                DisplayArrayValues(array, SelectionListBox); //Call method and pass it the array, which is now sorted.
                SelectionListBox.Items.Add("Sort Complete");
            }
            else //runs if the user did not enter a valid integer for the size of the array.
            {
                SelectionListBox.Items.Add("Please enter a valid integer");
            }
        }

        void QuickSortExample() //comments are the same as those from the seleciton sort, just using a quicksort instead.
        {
            QuickListBox.Items.Clear();
            int[] array = GenerateArray();
            if (array != null)
            {
                QuickListBox.Items.Add("Unsorted Items");
                DisplayArrayValues(array, QuickListBox);
                Stopwatch watch = new Stopwatch();
                watch.Start();
                QuickSort(array, 0, array.Length - 1);
                watch.Stop();
                QuickWatchLabel.Text = watch.ElapsedMilliseconds.ToString() + "ms";
                QuickListBox.Items.Add("Sorted Items");
                DisplayArrayValues(array, QuickListBox);
                QuickListBox.Items.Add("Sort Complete");
            }
            else
            {
                QuickListBox.Items.Add("Please enter a valid integer");
            }
        }

        int[] GenerateArray()
        {
            int vMin = 0;
            int vMax;
            bool isInt = int.TryParse(ArraySizeTextBox.Text, out vMax); //Try to parse the text in the textbox to an integer.
            if (isInt && vMax > 0) //only create the array if a valid integer that is greater than 0 was entered.
            {
                int[] arrInt = new int[vMax];
                Random randNum = new Random();

                for (int i = 0; i < arrInt.Length; i++)
                {
                    arrInt[i] = randNum.Next(vMin, vMax);
                }

                return arrInt;
            }
            else
            {
                return null; //return a null array if a valid integer was not entered.
            }
        }


        void SelectionSort(int[] array) //Selection Sort Algorithm.
        {
            int pos_min = 0;
            int temp = 0;

            for (int i = 0; i < array.Length; i++)
            {
                pos_min = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[pos_min])
                    {
                        pos_min = j;
                    }
                }

                if (pos_min != i)
                {
                    temp = array[i];
                    array[i] = array[pos_min];
                    array[pos_min] = temp;
                }
            }
        }

        void QuickSort(int[] array, int start, int end) //Quicksort Algorithm.
        {
            int pivot = array[end];
            int i = start;
            int j = end;
            int temp;

            while (i <= j)
            {
                while (array[i] < pivot)
                {
                    i++;
                }

                while (array[j] > pivot)
                {
                    j--;
                }

                if (i <= j)
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }

            if (start < j)
            {
                QuickSort(array, start, j);
            }

            if (i < end)
            {
                QuickSort(array, i, end);
            }
        }

        void DisplayArrayValues(int[] arr, ListBox listBox)
        {
            if (arr.Length <= 20000) //If the array length is less than or equal to 20000, display it in the listbox.
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    listBox.Items.Add(arr[i]);
                }
            }
            else
            {
                listBox.Items.Clear(); //Clear the listbox if its size is greater than 20000 to remove the Unsorted and Sorted messages. Sort Complete is still displayed.
            }
        }

        private void ArraySizeTextBox_TextChanged(object sender, EventArgs e)
        {
            SelectionWatchLabel.Text = "Time";
            QuickWatchLabel.Text = "Time";
            SelectionListBox.Items.Clear();
            QuickListBox.Items.Clear();
        }
    }
}