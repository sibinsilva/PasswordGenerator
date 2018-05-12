using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    public class Commercial
    {
        CreateRandom Randomise = new CreateRandom();
        public void Generate(int n)
        {
            int num = n;
            Console.WriteLine("****You have selected Commercial use****");
            Console.WriteLine("Enter the number of Password characters required -- minimum 12 characters required");
            int number = Int32.Parse(Console.ReadLine());
            if (number < 12)
            {
                Console.WriteLine("Your password character count is short please re-enter");
                Generate(num);
            }
            else
            {
                string result = Randomise.Password(number);
                Console.WriteLine(result);
            }
        }
    }
}
