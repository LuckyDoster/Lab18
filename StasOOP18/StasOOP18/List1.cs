using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StasOOP18
{
    internal class List1
    {
        // одновимірний масив
        private int[] array;

        // конструктор
        public List1(int length)
        {
            array = new int[length];
        }

        // Властивості
        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= array.Length)
                    throw new IndexOutOfRangeException();

                return array[index];
            }
            set
            {
                if (index < 0 || index >= array.Length)
                    throw new IndexOutOfRangeException();

                array[index] = value;
            }
        }

        // рахунок від'ємних елементів масиву
        public int CountNegative()
        {
            int result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                    result++;
            }

            return result;
        }

        // отримання суми
        public int GetSum()
        {
            // пошук індекса мінімального елемента по модулю
            int minValue = Math.Abs(array[0]);
            int minIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i]) < minValue)
                {
                    minValue = Math.Abs(array[i]);
                    minIndex = i;
                }
            }

            // пошук суми
            int sum = 0;
            for (int i = minIndex; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum;
        }

        // спеціальне сортування
        public void SpecialSort()
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                    array[i] = (int)Math.Pow(array[i], 2);
            }

            Array.Sort(array);
        }

        // вивід масиву
        public void DisplayArray()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}; ");
            }
        }
    }
}
