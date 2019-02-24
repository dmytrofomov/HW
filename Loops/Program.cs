using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            string a;
          

            while (true)
            {
                a = Console.ReadLine();
                if (a == "exit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("ЖОПА!");
                }
                
            }
        }
    }
}
