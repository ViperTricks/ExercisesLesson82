/// <summary>
/// <author>Branium Academy</author>
/// <version>2022.05.24</version>
/// <see cref="Trang chủ" href="https://braniumacademy.net"/>
/// </summary>

using System;
using System.Text;

namespace ExercisesLesson82
{
    internal class Ex5
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào một lời nhắn: ");
            var str = Console.ReadLine();

            Console.WriteLine("Test 1: ");
            Test(str);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Test 2: ");
            Test("");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Test 3: ");
            Test(null);
            Console.WriteLine("-----------------------------------");
        }

        private static void Test(string str)
        {
            try
            {
                Console.WriteLine("Chuỗi kí tự sau khi viết hoa: ");
                var result = UpperCase(str);
                Console.WriteLine(result);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }
        }

        private static string UpperCase(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException("input", "Đối số truyền vào cho inut null.");
            }
            else if (input.Length == 0)
            {
                throw new ArgumentException("Tham số đầu vào rỗng.", "input");
            }
            return input.ToUpper();
        }
    }
}
