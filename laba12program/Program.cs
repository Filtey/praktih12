using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba12program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввести А\nВвести В\nвыполнить операцию '+'\nВыполнить операцию '-'\nВыполнить операцию '*'\nВыполнить операцию '/'\n");
            string menu = Console.ReadLine();
            int a = 0, b = 0;
<<<<<<< HEAD
            if (menu == "Ввести В")
            {
                b = int.Parse(Console.ReadLine());
=======
            if(menu == "Выполнить операцию '/'")
            {
                Console.WriteLine(a/b);
>>>>>>> delenie
            }
        }
    }
}
