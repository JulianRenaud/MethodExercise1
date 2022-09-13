using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExercise1
{
    internal class Methods
    {
        public static void MethodExercise()
        {
            Console.WriteLine("What is your full name? (click enter to skip)");
            var fullName = Console.ReadLine();

            Console.WriteLine("What is your age? (click enter to skip)");
            var age = Console.ReadLine();

            Console.WriteLine("What is your favorite color? (click enter to skip)");
            var favColor = Console.ReadLine();

            Console.WriteLine("What is your favorite animal at this zoo? (click enter to skip)");
            var favAnimal = Console.ReadLine();

            Console.WriteLine($"Hello {fullName}, your survey has been submitted!");


        }
    }
}
