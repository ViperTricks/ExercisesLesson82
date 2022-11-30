/// <summary>
/// <author>Branium Academy</author>
/// <version>2022.05.24</version>
/// <see cref="Trang chủ" href="https://braniumacademy.net"/>
/// </summary> 

using System;
using System.Text;

namespace ExercisesLesson82
{
    internal class Ex3
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            float[] arr = new float[] { 1, 2, 3, 6, 5, 4, 6, 7, 8, 9, 10 };
            Console.WriteLine("Test 1: ");
            Test(arr, 0, 4);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Test 2: ");
            Test(arr, -2, 4);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Test 3: ");
            Test(arr, 5, 40);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Test 4: ");
            Test(null, 0, 4);
            Console.WriteLine("-----------------------------------");
        }

        private static void Test(float[] arr, int firstIndex, int secondIndex)
        {
            try
            {
                Console.WriteLine($"Tổng 2 phần tử tại vị trí {firstIndex} và {secondIndex} " +
                    $"trong mảng: {Sum(arr, firstIndex, secondIndex)}");
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e);
            } catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e);
            }
        }

        private static float Sum(float[] arr, int firstIndex, int secondIndex)
        {
            if (arr == null)
            {
                throw new ArgumentNullException("arr", "Đối số truyền vào cho arr null.");
            }
            else if (firstIndex < 0 || firstIndex >= arr.Length)
            {
                throw new IndexOutOfRangeException($"Chỉ số mảng firstIndex = {firstIndex} không hợp lệ.");
            }
            else if (secondIndex < 0 || secondIndex >= arr.Length)
            {
                throw new IndexOutOfRangeException($"Chỉ số mảng secondIndex = {secondIndex} không hợp lệ.");
            }
            return arr[firstIndex] + arr[secondIndex];
        }
    }
}
