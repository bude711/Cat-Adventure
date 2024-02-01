using Cat_Adventure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat_Adventure
{

    internal class Cat
    {
        public string name { get; set; }
        public string color { get; set; }
        public string state { get; set; }

 
        public Cat(IInputProvider inputProvider, IOutputProvider outputProvider)
        {
            // Prompt player to enter the name of the cat
            outputProvider.WriteLine("Please enter the name of your cat: ");
            name = inputProvider.Read();

            outputProvider.WriteLine("Please enter the color of your cat: ");
            color = inputProvider.Read();

            outputProvider.WriteLine("Please enter the mood of your cat: ");
            state = inputProvider.Read();
        }
    }
}
