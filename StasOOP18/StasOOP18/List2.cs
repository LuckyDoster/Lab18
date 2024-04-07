using System;

namespace StasOOP18
{
    internal class List2
    {
        // двовимірний масив
        private int[,] matrix;

        // конструктор
        public List2(int rows, int cols)
        {
            matrix = new int[rows, cols];
        }

        // властивості
        public int this[int rows, int cols]
        {
            get
            {
                if (rows < 0 || rows >= matrix.GetLength(0) || cols < 0 || cols >= matrix.GetLength(1))
                    throw new IndexOutOfRangeException();

                return matrix[rows, cols];
            }
            set
            {
                if (rows < 0 || rows >= matrix.GetLength(0) || cols < 0 || cols >= matrix.GetLength(1))
                    throw new IndexOutOfRangeException();

                matrix[rows, cols] = value;
            }
        }

        // вивід матриці
        public void DisplayMatrix()
        {
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    Console.Write($"{matrix[rows, cols]}  ");
                }
                Console.WriteLine();
            }
        }

        // вивід рядка матриці
        public void DisplayRow(int rows)
        {
            if (rows < 0 || rows >= matrix.GetLength(0))
                throw new IndexOutOfRangeException();

            for (int cols = 0; cols < matrix.GetLength(1); cols++)
            {
                Console.Write($"{matrix[rows, cols]}  ");
            }
            Console.WriteLine();
        }

        // вивід стовпця матриці
        public void DisplayCol(int cols)
        {
            if (cols < 0 || cols >= matrix.GetLength(1))
                throw new IndexOutOfRangeException();

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                Console.Write($"{matrix[rows, cols]}  ");
            }
            Console.WriteLine();
        }
    }
}
