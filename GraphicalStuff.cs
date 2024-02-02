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
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            outputProvider.WriteLine(margin + "(\\");
                            outputProvider.WriteLine(margin + " ))         )\\");
                            outputProvider.WriteLine(margin + "((         /  o(.");
                            outputProvider.WriteLine(margin + "\\\\.-\"```\"`'=_/=");
                            outputProvider.WriteLine(margin + "  >  ,       /");
                            outputProvider.WriteLine(margin + "  \\   )__.\\ |");
                            outputProvider.WriteLine(margin + "   > / /  ||\\");
                            outputProvider.WriteLine(margin + "   \\ \\  \\ \\");
                            outputProvider.WriteLine(margin + "   `\" `\" `\"`\"");
                            Console.ForegroundColor = ConsoleColor.Green;
                            outputProvider.WriteLine("\\||/ ___ ____ _____\\||/ _____ ___ \\||/ __ ____ _ _ _ ______ ");
                            break;
                        };
                    case 1:
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            outputProvider.WriteLine(margin + "(\\");
                            outputProvider.WriteLine(margin + " ))         )\\");
                            outputProvider.WriteLine(margin + "((         /  o(");
                            outputProvider.WriteLine(margin + "\\\\.-\"```\"'`=_/=");
                            outputProvider.WriteLine(margin + "  >  ,       /");
                            outputProvider.WriteLine(margin + "  \\   )__.|| |");
                            outputProvider.WriteLine(margin + "   > | |  ||\\");
                            outputProvider.WriteLine(margin + "   || ||  || \\");
                            outputProvider.WriteLine(margin + "   `\" `\" `\"`\"");
                            Console.ForegroundColor = ConsoleColor.Green;
                            outputProvider.WriteLine("\\||/ ___ ____ _____\\||/ _____ ___ \\||/ __ ____ _ _ _ ______ ");
                            break;
                        };
                    case 2:
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            outputProvider.WriteLine(margin + "(\\");
                            outputProvider.WriteLine(margin + " ))         )\\");
                            outputProvider.WriteLine(margin + "((         /  o(.");
                            outputProvider.WriteLine(margin + "\\\\.-\"```\"'`=_/=");
                            outputProvider.WriteLine(margin + "  >  ,       /");
                            outputProvider.WriteLine(margin + "  \\   )__.|| |");
                            outputProvider.WriteLine(margin + "   > / /  //\\");
                            outputProvider.WriteLine(margin + "  // //  // \\");
                            outputProvider.WriteLine(margin + "  `\" `\" `\"`\"");
                            Console.ForegroundColor = ConsoleColor.Green;
                            outputProvider.WriteLine("\\||/ ___ ____ _____\\||/ _____ ___ \\||/ __ ____ _ _ _ ______ ");
                            break;
                        };
                }
                counter++;
                j++;
                Thread.Sleep(200);
                Console.ResetColor();
            }
        }

        public static void WelcomeScreen(IOutputProvider outputProvider)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
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
            Console.ResetColor();
        }

        public static void DogEncounter(IOutputProvider outputProvider)
        {
            Console.Clear();
            outputProvider.WriteLine("Oh no! On your walk you encounter a dog!");

            outputProvider.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            outputProvider.WriteLine("              |\\_ /| ");
            outputProvider.WriteLine("              | @ @   Woof!");
            outputProvider.WriteLine("              |   <>                _");
            outputProvider.WriteLine("              | _ /\\------____   ((| |))");
            outputProvider.WriteLine("              |                 `--' | ");
            outputProvider.WriteLine("         ____ |_         ___|    |___.'");
            outputProvider.WriteLine("        / _/ _____/ ____/ _______| ");
            outputProvider.WriteLine();
            Thread.Sleep(2000);
            Console.ResetColor();
        }

        public static void FenceCats(IOutputProvider outputProvider)
        {
            outputProvider.Clear();
            outputProvider.WriteLine();
            outputProvider.WriteLine("Yay! Fur-iends!");
            outputProvider.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            outputProvider.WriteLine("                    /^--^\\     /^--^\\     /^--^\\");
            outputProvider.WriteLine("                    \\____/     \\____/     \\____/");
            outputProvider.WriteLine("                    /      \\   /      \\   /      \\");
            outputProvider.WriteLine("                   |        | |        | |        |");
            outputProvider.WriteLine("                    \\__  __/   \\__  __/   \\__  __/");
            Console.ForegroundColor = ConsoleColor.Yellow;
            outputProvider.WriteLine("|^|^|^|^|^|^|^|^|^|^|^|^\\ \\^|^|^|^/ /^|^|^|^|^\\ \\^|^|^|^|^|^|^|^|^|^|^|^|");
            outputProvider.WriteLine("| | | | | | | | | | | | |\\ \\| | |/ /| | | | | |\\ \\| | | | | | | | | | | |");
            Console.ForegroundColor = ConsoleColor.Green;
            outputProvider.WriteLine("########################/ /######\\ \\###########/ /#######################");
            Console.ForegroundColor = ConsoleColor.Yellow;
            outputProvider.WriteLine("| | | | | | | | | | | | \\/| | | | \\/| | | | | |\\/ | | | | | | | | | | | | ");
            Console.ForegroundColor = ConsoleColor.Green;
            outputProvider.WriteLine("|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|");
            Thread.Sleep(2000);
            Console.ResetColor();
        }

        public static void AngryCat(IOutputProvider outputProvider)
        {
            Console.Clear();
            outputProvider.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            outputProvider.WriteLine("      HISSSSSSSSSSSSSSSSSSSSSSS!");
            outputProvider.WriteLine("                          _");
            outputProvider.WriteLine("                         \\ \\");
            outputProvider.WriteLine("       |\\_/|              | |");
            outputProvider.WriteLine("       )O O  ` ,_\\-||||-.  / /");
            outputProvider.WriteLine("      =\\Y_= /           \\/ / ");
            outputProvider.WriteLine("         `\"`\\        /     / ");
            outputProvider.WriteLine("           |       \\  |    / ");
            outputProvider.WriteLine("            \\     /-   \\  \\");
            outputProvider.WriteLine("             | |  |     / /  /");
            outputProvider.WriteLine("             ( (__|     ((__/");
            Thread.Sleep(2000);
            Console.ResetColor();
        }

        public static void HighFive(IOutputProvider outputProvider)
        {       
            Console.Clear();
            outputProvider.WriteLine("This dog happens to be a friend! You greet each other and then continue to your destination.");
            outputProvider.WriteLine();
            outputProvider.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            outputProvider.WriteLine("                 *^ \"\" ~~ ,         ");
            outputProvider.WriteLine("                (  /     \\        ");
            outputProvider.WriteLine("               /  /|     O `--~@   ");
            outputProvider.WriteLine("              (__//            )    ");
            outputProvider.WriteLine("                 /        \\---:              ^         ");
            outputProvider.WriteLine("                |         |                 - )\\      ");
            outputProvider.WriteLine("               /          \\      --.      /@   |       ");
            outputProvider.WriteLine("        *     |            |    /  _)@)  =* ==  \\               ");
            outputProvider.WriteLine("       / |   /          \\  \\ /  /  \\ \\    )   ~.        __. ");
            outputProvider.WriteLine("      /  |  |             \\     /     \\ \\/       \\     /  __)");
            outputProvider.WriteLine("      |  |  |              \\._ /        \\           \\   / /      "); 
            outputProvider.WriteLine("      |  |  |            (                 \\          |   | |   ");
            outputProvider.WriteLine("      |  |  \\           |                  \\     _   | / /    ");
            outputProvider.WriteLine("      |  |   \\  )   \\  \\                  |    /    |/ /    ");
            outputProvider.WriteLine("      \\  \\__/  /     \\  |_.              /     | )    /  ");
            outputProvider.WriteLine("        --    ( __)     (___ )           ( ~~ ` (~~ )-\"'       ");
            Console.ForegroundColor = ConsoleColor.Green;
            outputProvider.WriteLine("_____  _____\\||/ _____ ___ \\||/ __ ____ \\// ___ __ _____ ___ \\||/ __ ____ ____");
            outputProvider.WriteLine("                                              ");
            Thread.Sleep(2000);
            Console.ResetColor();
        }
            
    }
}
