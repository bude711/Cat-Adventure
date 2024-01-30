﻿using Cat_Adventure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat_Adventure
{
    class ConsoleOutputProvider : IOutputProvider
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
            Console.WriteLine(message);
        }

        public void WriteLine()
        {
            Console.WriteLine();
        }
    }
}