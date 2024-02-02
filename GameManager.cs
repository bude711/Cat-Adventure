using Cat_Adventure.Interfaces;
//using Console = Colorful.Console;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace Cat_Adventure
{
    internal class GameManager
    {
        private IInputProvider inputProvider;
        private IOutputProvider outputProvider;
        public GameState GameState { get; private set; }

        public Cat? cat;
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
            PlayMusic("animal_crossing.mp3");    
        }

        public void StoryEvents()
        {
            outputProvider.WriteLine("Welcome to Cat Adventure!");
            outputProvider.WriteLine("=========================\n");
            GraphicalStuff.WelcomeScreen(outputProvider);

            var pressKey = $"\n" +
                         $"Press any key to continue\n" ;

            foreach (var character in pressKey)
            {
                Console.Write(character);
                Thread.Sleep(40);
            }
           
            Console.ReadKey(true);
            
            GameState = GameState.GameStarted;
            cat = new Cat(inputProvider, outputProvider);

            cat.state = ChooseDestination.LocationOne(inputProvider, outputProvider, cat);
            handleDog();
            reachedDestination();
        }
        public void PlayMusic(string fileName)
        {
            using (var audioFile = new AudioFileReader(fileName))
            using (var outputDevice = new WaveOutEvent())
            {
                outputDevice.Init(audioFile);
                outputDevice.Play();

                StoryEvents();

                Console.ReadKey();
            }
        }
      
        public void handleDog()
        {
              
            GraphicalStuff.DogEncounter(outputProvider);

            var mySecondString = $"What do you do?\n" +               
                $"\n" +
                $"1. hiss at the dog\n" +
                $"2. run around the dog\n" +
                $"3. high-five the dog\n" +
                $"\n" +
                $"Please enter the number you would like to choose.";

            foreach (var character in mySecondString)
            {
                Console.Write(character);
                Thread.Sleep(40);
            }
            outputProvider.WriteLine();
           
            var choice = inputProvider.Read();
            if (choice.Contains('1'))
            {

                var choiceOne = $"\n" +
                    $"You’ve chosen to hiss at the dog!";

                foreach (var character in choiceOne)
                {
                    Console.Write(character);
                    Thread.Sleep(40);
                }
                outputProvider.WriteLine();
                Thread.Sleep(1000);
                GraphicalStuff.AngryCat(outputProvider);
            }
            else if (choice.Contains('2'))
            {
                var choicetwo = $"\n" +
                    $"You’ve chosen to run around the dog!\n" +
                    $"You bolt into the next street, finding a new path to your destination.";

                foreach (var character in choicetwo)
                {
                    Console.Write(character);
                    Thread.Sleep(40);
                }
                outputProvider.WriteLine();
              
            }
            else if (choice.Contains('3'))
            {
                var choiceThree = $"\n" +
                   $"You’ve chosen to high-five the dog!\n";

                foreach (var character in choiceThree)
                {
                    Console.Write(character);
                    Thread.Sleep(40);
                }
                outputProvider.WriteLine();
                Thread.Sleep(1000);

                GraphicalStuff.HighFive(outputProvider);

            }
            else
            {
                var choiceFour = $"\n" +
                  $"Not a valid option. The dog's owner calls him and your path is cleared.";

                foreach (var character in choiceFour)
                {
                    Console.Write(character);
                    Thread.Sleep(40);
                }

            }
            var pressKey = $"\n" +
                         $"Press any key to continue.";

            foreach (var character in pressKey)
            {
                Console.Write(character);
                Thread.Sleep(40);
            }
            outputProvider.WriteLine();
            Console.ReadKey(true);
            GraphicalStuff.WalkingCat(outputProvider);

        }

        public void reachedDestination()
        {
            var end = $"\n" +
                         $"Congratulations! You've arrived at your destination.\n" +
                         $"Your friends are here!\n" +
                         $"Now it's time for a cat party!\n";

            foreach (var character in end)
            {
                Console.Write(character);
                Thread.Sleep(40);
            }
            outputProvider.WriteLine();
            Thread.Sleep(1000);
            GraphicalStuff.FenceCats(outputProvider);

            var endingMessage = $"\n" +
                         $"Purrfect! You've completed Cat Adventure!\n" +
                         $"We hope you had a meow-velous time!\n" +
                         $"With the right catitude, anything is pawsible!\n" +
                         $"-Team M.E.O.W.\n\n" +
                         $"Press any key to exit the game.\n";

            foreach (var character in endingMessage)
            {
                Console.Write(character);
                Thread.Sleep(40);
            }
        }
    }
}
