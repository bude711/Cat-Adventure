using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat_Adventure
{
    internal class GameManager
    {
        public GameState GameState { get; private set; }

        Cat cat = new Cat();
        public GameManager() 
        { }

        public void Run()
        {
            Console.WriteLine("Hello World of Cats!");
        }
    }
}
