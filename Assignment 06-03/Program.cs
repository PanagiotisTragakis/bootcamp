using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_06_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Give age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            while (age <= 5 || age >= 100)
            {
                Console.WriteLine("Wrong age. Give your age again: ");
                age = Convert.ToInt32(Console.ReadLine());
            }
            
            Console.WriteLine("Give weight: ");
            double weight = Convert.ToDouble(Console.ReadLine());
            while (weight <=20 || weight >= 200)
            {
                Console.WriteLine("Wrong weight. Give your weight again: ");
                weight = Convert.ToDouble(Console.ReadLine());
            }

            string colorCheck;
            string weightCheck;
            
            List<string> colors = new List<string>() { "White", "Pink", "Red", "Green", "Blue", "Black" };
            List<string> shirtSize = new List<string>() { "Small", "Medium", "Large", "X-Large" };
            
            if (age >= 0 && age <= 17)
            {
                colorCheck = colors[0];
            }
            if (age >= 18 && age <= 24)
            {
                colorCheck = colors[1];
            }
            if (age >= 25 && age <= 35)
            {
                colorCheck = colors[2];
            }
            if (age >= 36 && age <= 45)
            {
                colorCheck = colors[3];
            }
            if (age >= 45 && age <= 55)
            {
                colorCheck = colors[4];
            }
            else
            {
                colorCheck = colors[5];
            }
            if (weight < 50)
            {
                weightCheck = shirtSize[0];
            }
            if (weight >= 50 && weight <= 64)
            {
                weightCheck = shirtSize[1];
            }
            if (weight >= 65 && weight <= 79)
            {
                weightCheck = shirtSize[2];
            }
            else
            {
                weightCheck = shirtSize[3];
            }
            
            Console.WriteLine($"Hey {name}, it is cool to be {age} years old! You should buy a {colorCheck} {weightCheck} shirt.");


        }
    }
}
