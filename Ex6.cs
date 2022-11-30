/// <summary>
/// <author>Branium Academy</author>
/// <version>2022.05.24</version>
/// <see cref="Trang chủ" href="https://braniumacademy.net"/>
/// </summary>

using System;
using System.Text;

namespace ExercisesLesson82
{
    internal class Ex6
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            string[] names = new string[10];
            object x = 100;
            object y = "Huy";
            object z = new object();
            Console.WriteLine("Test 1: ");
            Test(names, x);
            Console.WriteLine("--------------------------");
            Console.WriteLine("Test 2: ");
            Test(names, y);
            Console.WriteLine("--------------------------");
            Console.WriteLine("Test 3: ");
            Test(names, z);
            Console.WriteLine("--------------------------");
        }

        private static void Test(string[] names, object x)
        {
            try
            {
                Add(names, x);
                Console.WriteLine("==> Thêm thành công.");
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e);
            }
        }


        private static void Add(string[] names, object x)
        {
            if(x.GetType() != typeof(string))
            {
                throw new InvalidCastException("Không thể ép kiểu tham số x sang string.");
            }
            string xStr = x as string;
            names[0] = xStr;
        }
    }
}
