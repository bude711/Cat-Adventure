using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat_Adventure
{
    public class ConsoleInputProvider: Interfaces.IInputProvider
    {
        public string Read()
        {
            return Console.ReadLine();
        }
    }
}
