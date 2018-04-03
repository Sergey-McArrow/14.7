using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._7
{
    class MyArray
    {
        private int[] _array;
        public MyArray (int[] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                int numbers = random.Next(10, 100);
                array[i] = numbers;
            }

            int temp;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            _array = array;
        }
        public int GetMax
        {
            get
            {
                return _array[0];
            }
        }
        public int GetMin
        {
            get
            {
                return _array[_array.Length-1];
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyArray array = new MyArray(new int[20]);
            Console.WriteLine(array.GetMax);
            Console.WriteLine(array.GetMin);
        }
    }
}
 