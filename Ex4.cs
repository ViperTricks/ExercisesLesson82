/// <summary>
/// <author>Branium Academy</author>
/// <version>2022.05.24</version>
/// <see cref="Trang chủ" href="https://braniumacademy.net"/>
/// </summary>

using System;
using System.Text;

namespace ExercisesLesson82
{
    internal class Ex4
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Test 1: ");
            Test(0, 4);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Test 2: ");
            Test(-8, 3);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Test 3: ");
            Test(5, 0);
            Console.WriteLine("-----------------------------------");
        }

        private static void Test(int a, int b)
        {
            try
            {
                Console.WriteLine($"{a} / {b} = {Div(a, b)}");
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e);
            }
        }

        private static float Div(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Mẫu số của phép chia, b phải khác 0.");
            }
            return 1.0f * a / b;
        }
    }
}
