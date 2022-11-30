using System;
using System.Text;

namespace ExercisesLesson82
{
    internal class Ex1
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Test 1: ");
            Console.WriteLine("Nhập vào một dòng dữ liệu: ");
            var line = Console.ReadLine();
            Test(line);
            Console.WriteLine("Test 1: ");
            string otherLine = null;
            Test(otherLine);
        }

        private static void Test(string line)
        {
            try
            {
                Console.WriteLine("Số từ trong câu: " + CountWords(line));
                Console.WriteLine("----------------------------------------------");
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static int CountWords(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException("input không được phép null.");
            }
            var words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
    }
}
