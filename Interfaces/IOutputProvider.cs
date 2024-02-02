using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat_Adventure.Interfaces
{
    public interface IOutputProvider
    {
        void Write(string message);
        void WriteLine(string message);

        void WriteLine(string message, Color color);

        void WriteLine();

        void Clear();
    }
}
