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
            _array = array;
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                int numbers = random.Next(10, 100);
                array[i] = numbers;
            }
            array.OrderBy(f => f).ToArray();
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
 