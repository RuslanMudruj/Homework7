using System;

namespace Homework7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Read_machine bla = new Read_machine();
            bla.read_method();
            foreach(var el in bla.products_list)
                Console.WriteLine($"{el.Name} {el.Weight:F2} {el.Price:F2}");
        }
    }
}
