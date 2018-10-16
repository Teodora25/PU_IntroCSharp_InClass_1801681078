using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you nwant to play some music?");
            String answer = Console.ReadLine();
            
            if(answer=="Yes")
            {
                Console.WriteLine("Playing music...!!!");

            }
            else if(answer=="No")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("wrong input!");
            }


        }
    }
}
