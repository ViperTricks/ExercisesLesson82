using System;
using System.Text;

namespace ExercisesLesson82
{
    internal class Ex2
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[] arr = new int[] { 1, 2, 3, 0, 4, 5, 6, 7, 9, 10 };
            int[] arr2 = null;
            int index = 0;

            Console.WriteLine("Test 1: ");
            Test(arr, index);
            Console.WriteLine("-----------------------------------------------------------");

            index = 10;
            Console.WriteLine("Test 2: ");
            Test(arr, index);
            Console.WriteLine("-----------------------------------------------------------");

            index = -5;
            Console.WriteLine("Test 3: ");
            Test(arr, index);
            Console.WriteLine("-----------------------------------------------------------");

            index = 5;
            Console.WriteLine("Test 4: ");
            Test(arr2, index);
            Console.WriteLine("-----------------------------------------------------------");
        }

        private static void Test(int[] arr, int index)
        {
            try
            {
                Console.WriteLine($"Phần tử tại vị trí {index} của mảng là {ElementAt(arr, index)}");
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e);
            }
        }

        private static int ElementAt(int[] arr, int pos)
        {
            if(arr == null)
            {
                throw new ArgumentNullException("arr", "arr không được phép null");
            } else if(pos < 0)
            {
                throw new ArgumentOutOfRangeException("post", $"Giá trị pos = {pos} không phải chỉ số mảng hợp lệ.");
            }
            else if(arr.Length <= pos)
            {
                throw new IndexOutOfRangeException($"vị trí {pos} vượt quá biên mảng.");
            }
            return arr[pos];
        }
    }
}
