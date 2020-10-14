using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double speed = 0;
            string userInput = "";

            //ask user
            Console.Write("Vad är din hastighet?");
            userInput = Console.ReadLine();
            //convert input to int
            speed = int.Parse(userInput);

            //if greater than 30
            if (speed <= 30)
            {
                Console.Write("Du kör lagligt!");
            }
            else if (speed <= 40)
                Console.Write("böta 2000kr!");
            else if (speed <= 50)
                Console.Write("böta 3000kr!");
            else if (speed >= 51)
                Console.Write("böta 5000kr bessutom av med körkortet!");

            //stop
            Console.ReadKey();



        }
    }
}
