using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Personal Pass = new Personal();
            Commercial Passw = new Commercial();
            Console.WriteLine("*******Welcome to the Password Generator App*******");
            Console.WriteLine("Before you proceed please choose if you need password for personal or commercial use");
            Console.WriteLine("1. Personal Use");
            Console.WriteLine("2. Commercial use");
            Console.WriteLine("Please select the option to proceed:");
            int value=Int32.Parse(Console.ReadLine());
            switch (value)
            {
                case 1:
                    Pass.Generate(value);
                    break;
                case 2:
                    Passw.Generate(value);
                    break;
                default:
                    Console.WriteLine("You have selected a wrong option");
                    Console.WriteLine("Closing the application ");
                    Thread.Sleep(2000);
                    Environment.Exit(1);
                    break;
            }
            Console.ReadLine();
        }
    }
}
