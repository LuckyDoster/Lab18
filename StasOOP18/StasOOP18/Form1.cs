using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StasOOP18
{
    public partial class Form1 : Form
    {
        List1 array = new List1(10);
        List2 matrix = new List2(5, 5);

        public Form1()
        {
            InitializeComponent();
        }

        private void task1_add_Click(object sender, EventArgs e)
        {
            try
            {
                int index = int.Parse(txt1index.Text);
                int value = int.Parse(txt1value.Text);

                array[index] = value;
            }
            catch (FormatException) { }
            catch (IndexOutOfRangeException) { }
        }

        private void task1_a_Click(object sender, EventArgs e)
        {
            Console.WriteLine($"Кiлькiсть вiд'ємних елементiв масиву : {array.CountNegative()}");
        }

        private void task1_b_Click(object sender, EventArgs e)
        {
            Console.WriteLine($"Сума елементiв пiсля найменшого по модулю : {array.GetSum()}");
        }

        private void task1_display_Click(object sender, EventArgs e)
        {
            array.DisplayArray();
            Console.WriteLine();
        }

        private void task1_sort_Click(object sender, EventArgs e)
        {
            array.SpecialSort();
        }




        private void rask2_add_Click(object sender, EventArgs e)
        {
            try
            {
                int rows = int.Parse(txt2rows.Text);
                int cols = int.Parse(txt2cols.Text);
                int value = int.Parse(txt2value.Text);

                matrix[rows, cols] = value;
            }
            catch (FormatException) { }
            catch (IndexOutOfRangeException) { }
        }

        private void task2_display1_Click(object sender, EventArgs e)
        {
            try
            {
                int row = int.Parse(txt2thisRow.Text);
                Console.Write("Рядок матрицi : ");
                matrix.DisplayRow(row);
            }
            catch (FormatException) { }
            catch (IndexOutOfRangeException) { }
        }

        private void task2_display2_Click(object sender, EventArgs e)
        {
            try
            {
                int col = int.Parse(txt2thisCol.Text);
                Console.Write("Стовпець матрицi : ");
                matrix.DisplayCol(col);
            }
            catch (FormatException) { }
            catch (IndexOutOfRangeException) { }
        }

        private void task2_display3_Click(object sender, EventArgs e)
        {
            matrix.DisplayMatrix();
            Console.WriteLine();
        }
    }
}
