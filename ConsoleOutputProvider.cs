using Cat_Adventure.Interfaces;
using System.Drawing;
using Console = Colorful.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat_Adventure
{
    public class ConsoleOutputProvider : IOutputProvider
    {
        public void Clear()
        {
            Console.Clear();
        }

        public void Write(string message)
        {
            Console.Write(message);
        }

        public void WriteLine(string message)
        {
            Console.WriteLine(message, Color.White);
        }

        public void WriteLine(string message, Color color)
        {
            Console.WriteLine(message, color);
        }

        public void WriteLine()
        {
            Console.WriteLine();
        }
    }
}
