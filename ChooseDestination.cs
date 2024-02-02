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
            var myFirstString = $"You are {cat.name}, a {cat.state}, {cat.color} cat and you want to go meet up with your cat friends.\n" +
                $"\n" +
                $"Where do you want to go look for them?\n" +
                $"\n" +
                $"1. the Park\n" +
                $"2. the Bodega\n" +
                $"3. the Alleyway\n" +
                $"\n" +
                $"Please enter the number you would like to choose.";

                foreach (var character in myFirstString)
                 {
                    Console.Write(character);
                    Thread.Sleep(50);
                 }
                outputProvider.WriteLine();                      

            var choice = inputProvider.Read();
                if (choice.Contains('1'))
                 {
                    var choiceOne = $"\n" +
                    $"You’ve chosen to go to the Park!\n" +
                    $"You exit your home and start your journey!";              

                    foreach (var character in choiceOne)
                        {
                        Console.Write(character);
                        Thread.Sleep(50);
                        }
                    outputProvider.WriteLine();
               
                 }
                else if (choice.Contains('2'))
                 {
                     var choiceTwo = $"\n" +
                         $"You’ve chosen to go to the Bodega!\n" +
                         $"You exit your home and start your journey!";

                     foreach (var character in choiceTwo)
                      {
                        Console.Write(character);
                        Thread.Sleep(50);
                      }
                     outputProvider.WriteLine();
                
                 }
                else if (choice.Contains('3'))
                 {
                     var choiceThree = $"\n" +
                         $"You’ve chosen to go to the Alleyway!\n" +
                          $"You exit your home and start your journey!";

                     foreach (var character in choiceThree)
                     {
                       Console.Write(character);
                       Thread.Sleep(50);
                     }
                     outputProvider.WriteLine();
               
                 }
                else
                 {
                     var choiceFour = $"\n" +
                        $"Not a valid option. The cat gods have made the decision for you and you will be going to the dump.";

                     foreach (var character in choiceFour)
                     {
                         Console.Write(character);
                         Thread.Sleep(50);
                     }
                     outputProvider.WriteLine();
               }
            
            var hitAKey = $"\n" +
                   $"Press any key to continue." ;

            foreach (var character in hitAKey)
            {
                Console.Write(character);
                Thread.Sleep(50);
            }
            outputProvider.WriteLine();
            Console.ReadKey(true);

            GraphicalStuff.WalkingCat(outputProvider);
            return "Adventurous";
        }
    }
}
