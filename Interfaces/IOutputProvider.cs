using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat_Adventure.Interfaces
{
    internal interface IOutputProvider
    {
        void Write(string message);
        void WriteLine(string message);

        void WriteLine();

        void Clear();
    }
}
