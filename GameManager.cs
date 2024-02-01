using Cat_Adventure.Interfaces;
using Console = Colorful.Console;
using System;
using System.Collections.Generic;
using System.Data;
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
            //outputProvider.WriteLine("Welcome to Cat Adventure!");           
            GraphicalStuff.WelcomeScreen(outputProvider);
            GameState = GameState.GameStarted;
            Thread.Sleep(3000);
            outputProvider.WriteLine();
            chooseDestination();
            handleDog();
            reachedDestination();           
            
        }

        public void chooseDestination() {
            outputProvider.WriteLine("You are a cat and you want to go meet up with your cat friends.");
            outputProvider.WriteLine("Where do you want to go look for them?");
            outputProvider.WriteLine();
            outputProvider.WriteLine("1. the Park");
            outputProvider.WriteLine("2. the Bodega");
            outputProvider.WriteLine("3. the Alleyway");
            outputProvider.WriteLine();
            outputProvider.WriteLine("Please enter the number you would like to choose.");            

            var choice = inputProvider.Read();
            if (choice.Contains('1')) {
                outputProvider.WriteLine();
                outputProvider.WriteLine("You’ve chosen to go to the Park!");
                outputProvider.WriteLine();
                outputProvider.WriteLine("You exit your home and start your journey!");
            }
            else if (choice.Contains('2')) {
                outputProvider.WriteLine();
                outputProvider.WriteLine("You’ve chosen to go to the Bodega!");
                outputProvider.WriteLine();
                outputProvider.WriteLine("You exit your home and start your journey!");
            }
            else if (choice.Contains('3'))
            {
                outputProvider.WriteLine();
                outputProvider.WriteLine("You’ve chosen to go to the Alleyway!");
                outputProvider.WriteLine();
                outputProvider.WriteLine("You exit your home and start your journey!");
            }
            else
            {
                outputProvider.WriteLine();
                outputProvider.WriteLine("Not a valid option. The cat gods have made the decision for you and you will be going to the dump.");
            }
            outputProvider.WriteLine();
            outputProvider.WriteLine("Hit any key to continue.");
            Console.ReadKey();

            GraphicalStuff.WalkingCat(outputProvider);
        }

        public void handleDog()
        {
              
            GraphicalStuff.DogEncounter(outputProvider);
            outputProvider.WriteLine("What do you do?");
            outputProvider.WriteLine();
            outputProvider.WriteLine("1. hiss at the dog");
            outputProvider.WriteLine("2. run around the dog");
            outputProvider.WriteLine("3. high-five the dog");
            outputProvider.WriteLine();
            outputProvider.WriteLine("Please enter the number you would like to choose.");            

            var choice = inputProvider.Read();
            if (choice.Contains('1'))
            {
                outputProvider.WriteLine();
                outputProvider.WriteLine("You’ve chosen to hiss at the dog!");
                outputProvider.WriteLine();
                outputProvider.WriteLine("You scare off the dog and continue on your path.");
            }
            else if (choice.Contains('2'))
            {
                outputProvider.WriteLine();
                outputProvider.WriteLine("You’ve chosen to run around the dog!");
                outputProvider.WriteLine();
                outputProvider.WriteLine("You bolt into the next street, finding a new path to your destination.");
            }
            else if (choice.Contains('3'))
            {
                outputProvider.WriteLine();
                outputProvider.WriteLine("You’ve chosen to high-five the dog!");
                outputProvider.WriteLine();
                outputProvider.WriteLine("This dog happens to be a friend! You greet each other and then continue to your destination.");
            }
            else
            {
                outputProvider.WriteLine();
                outputProvider.WriteLine("Not a valid option. The dog's owner calls him and your path is cleared.");
            }
            outputProvider.WriteLine();
            outputProvider.WriteLine("Hit any key to continue.");
            Console.ReadKey();
            GraphicalStuff.WalkingCat(outputProvider);

        }

        public void reachedDestination()
        {
            outputProvider.WriteLine();
            outputProvider.WriteLine("Congratulations! You've arrived at your destination.");
            outputProvider.WriteLine("Your friends are here!");
            outputProvider.WriteLine("Now it's time for a cat party!");


        }
    }
}
