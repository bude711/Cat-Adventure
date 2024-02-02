using Cat_Adventure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat_Adventure
{

    public class Cat
    {
        public string name { get; set; }
        public string color { get; set; }
        public string state { get; set; }

 
        public Cat(IInputProvider inputProvider, IOutputProvider outputProvider)
        {
            // Prompt player to enter the name of the cat
            var nameAsk = $"\nPlease enter the name of your cat: ";

            foreach (var character in nameAsk)
            {
                Console.Write(character);
                Thread.Sleep(40);
            }
            outputProvider.WriteLine();
            name = inputProvider.Read();

            var colorAsk = $"\nPlease enter the color of your cat: ";

            foreach (var character in colorAsk)
            {
                Console.Write(character);
                Thread.Sleep(40);
            }
            outputProvider.WriteLine();
            color = inputProvider.Read();

            var moodAsk = $"\nPlease enter the mood of your cat: ";

            foreach (var character in moodAsk)
            {
                Console.Write(character);
                Thread.Sleep(40);
            }
            outputProvider.WriteLine();
            state = inputProvider.Read();
           
        }
    }
}
