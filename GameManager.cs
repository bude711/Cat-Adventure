using Cat_Adventure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat_Adventure
{
    internal class GameManager
    {
        private IInputProvider inputProvider;
        private IOutputProvider outputProvider;
        public GameState GameState { get; private set; }

        Cat cat = new Cat();
        public GameManager() : this(new ConsoleInputProvider(), new ConsoleOutputProvider())
        {
        }
        public GameManager(IInputProvider inputProvider, IOutputProvider outputProvider)
        {
            this.inputProvider = inputProvider;
            this.outputProvider = outputProvider;
            GameState = GameState.WaitingToStart;
        }


        public void Run()
        {
            outputProvider.WriteLine("Hello World of Cats!");
            
        }
    }
}
