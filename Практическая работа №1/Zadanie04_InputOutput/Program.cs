using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Консоль4
{
    class Program
    {
        static void Main(string[] args)
        {
            int weight,
                height;

            Console.Write("Введите ваш вес: ");
            weight = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите ваш рост: ");
            height = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n\nВес= " + weight + "\n\nрост=" + height);
            Console.ReadLine();
        }
    }
}
