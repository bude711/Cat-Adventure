using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat_Adventure
{

    internal class Cat
    {
        private string name;
        private string color;
        public string state
        {
            get { return state; }
            set { state = value; }
        }

        public Cat()
        {
            name = "Bean";
            color = "Tabby";
            state = "Happy";
        }
    }
}
