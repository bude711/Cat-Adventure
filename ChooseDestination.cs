using Cat_Adventure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat_Adventure
{
    internal class ChooseDestination
    {
        public static string LocationOne(IInputProvider inputProvider, IOutputProvider outputProvider, Cat cat)
        {
            Console.Clear();
            outputProvider.WriteLine($"You are {cat.name}, a {cat.state} {cat.color} cat and you want to go meet up with your cat friends.");
            outputProvider.WriteLine();
            outputProvider.WriteLine("Where do you want to go look for them?");
            outputProvider.WriteLine();
            outputProvider.WriteLine("1. the Park");
            outputProvider.WriteLine("2. the Bodega");
            outputProvider.WriteLine("3. the Alleyway");
            outputProvider.WriteLine();
            outputProvider.WriteLine("Please enter the number you would like to choose.");

            var choice = inputProvider.Read();
            if (choice.Contains('1'))
            {
                outputProvider.WriteLine("You’ve chosen to go to the Park!");
                outputProvider.WriteLine();
                outputProvider.WriteLine("You exit your home and start your journey!");
            }
            else if (choice.Contains('2'))
            {
                outputProvider.WriteLine("You’ve chosen to go to the Bodega!");
                outputProvider.WriteLine();
                outputProvider.WriteLine("You exit your home and start your journey!");
            }
            else if (choice.Contains('3'))
            {
                outputProvider.WriteLine("You’ve chosen to go to the Alleyway!");
                outputProvider.WriteLine();
                outputProvider.WriteLine("You exit your home and start your journey!");
            }
            else
            {
                outputProvider.WriteLine("Not a valid option. The cat gods have made the decision for you and you will be going to the dump.");
            }
            outputProvider.WriteLine();
            outputProvider.WriteLine("Hit any key to continue.");
            Console.ReadKey();

            GraphicalStuff.WalkingCat(outputProvider);
            return "Adventurous";
        }
    }
}
