using Cat_Adventure.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat_Adventure
{
    internal class GraphicalStuff
    {
        public static void WalkingCat(IOutputProvider outputProvider)
        {
            var counter = 0;
            var j = 1;
            for (int i = 0; i < 30; i++)
            {
                Console.Clear();
                Console.WriteLine();

                var margin = "".PadLeft(j);
                switch (counter % 3)

                {
                    case 0:
                        {
                            outputProvider.WriteLine(margin + "(\\", Color.Orange);
                            outputProvider.WriteLine(margin + " ))         )\\", Color.Orange);
                            outputProvider.WriteLine(margin + "((         /  o(.", Color.DarkOrange);
                            outputProvider.WriteLine(margin + "\\\\.-\"```\"`'=_/=", Color.Orange);
                            outputProvider.WriteLine(margin + "  >  ,       /", Color.Orange);
                            outputProvider.WriteLine(margin + "  \\   )__.\\ |", Color.Orange);
                            outputProvider.WriteLine(margin + "   > / /  ||\\", Color.OrangeRed);
                            outputProvider.WriteLine(margin + "   \\ \\  \\ \\", Color.Orange);
                            outputProvider.WriteLine(margin + "   `\" `\" `\"`\"", Color.DarkOrange);
                            outputProvider.WriteLine("\\||/ ___ ____ _____\\||/ _____ ___ \\||/ __ ____ _ _ _ ______ ", Color.Green);
                            break;
                        };
                    case 1:
                        {
                            outputProvider.WriteLine(margin + "(\\", Color.Orange);
                            outputProvider.WriteLine(margin + " ))         )\\", Color.Orange);
                            outputProvider.WriteLine(margin + "((         /  o(", Color.DarkOrange);
                            outputProvider.WriteLine(margin + "\\\\.-\"```\"'`=_/=", Color.Orange);
                            outputProvider.WriteLine(margin + "  >  ,       /", Color.Orange);
                            outputProvider.WriteLine(margin + "  \\   )__.|| |", Color.Orange);
                            outputProvider.WriteLine(margin + "   > | |  ||\\", Color.OrangeRed);
                            outputProvider.WriteLine(margin + "   || ||  || \\", Color.Orange);
                            outputProvider.WriteLine(margin + "   `\" `\" `\"`\"", Color.DarkOrange);
                            outputProvider.WriteLine("\\||/ ___ ____ _____\\||/ _____ ___ \\||/ __ ____ _ _ _ ______ ", Color.Green);

                            break;
                        };
                    case 2:
                        {
                            outputProvider.WriteLine(margin + "(\\", Color.Orange);
                            outputProvider.WriteLine(margin + " ))         )\\", Color.Orange);
                            outputProvider.WriteLine(margin + "((         /  o(.", Color.DarkOrange);
                            outputProvider.WriteLine(margin + "\\\\.-\"```\"'`=_/=", Color.Orange);
                            outputProvider.WriteLine(margin + "  >  ,       /", Color.Orange);
                            outputProvider.WriteLine(margin + "  \\   )__.|| |", Color.Orange);
                            outputProvider.WriteLine(margin + "   > / /  //\\", Color.OrangeRed);
                            outputProvider.WriteLine(margin + "  // //  // \\", Color.Orange);
                            outputProvider.WriteLine(margin + "  `\" `\" `\"`\"", Color.DarkOrange);
                            outputProvider.WriteLine("\\||/ ___ ____ _____\\||/ _____ ___ \\||/ __ ____ _ _ _ ______ ", Color.Green);
                            break;
                        };
                }
                counter++;
                j++;
                Thread.Sleep(200);

            }
        }

        public static void WelcomeScreen(IOutputProvider outputProvider)
        {
            // Console.Clear();
            Console.WriteLine();
            outputProvider.WriteLine("      ,_  ");
            outputProvider.WriteLine("      |\\_,-~/|");
            outputProvider.WriteLine("      / _  _ |    ,--.");
            outputProvider.WriteLine("     (  @  @ )   / ,-'");
            outputProvider.WriteLine("     \\  _T_ /-._( (");
            outputProvider.WriteLine("      /         `. \\");
            outputProvider.WriteLine("      |         _  \\ |");
            outputProvider.WriteLine("      \\ \\ ,  /      |");
            outputProvider.WriteLine("       || |-_\\__   /");
            outputProvider.WriteLine("      ((_/`(____,-'");
            outputProvider.WriteLine();
        }

        public static void DogEncounter(IOutputProvider outputProvider)
        {
            Console.Clear();
            Console.WriteLine();
            outputProvider.WriteLine("              |\\_ /| ");
            outputProvider.WriteLine("              | @ @   Woof!");
            outputProvider.WriteLine("              |   <>                _");
            outputProvider.WriteLine("              | _ /\\------____  ((| |))");
            outputProvider.WriteLine("              |                 `--' | ");
            outputProvider.WriteLine("         ____ |_         ___|    |___.'");
            outputProvider.WriteLine("        / _/ _____/ ____/ _______| ");
        }
    }
}
