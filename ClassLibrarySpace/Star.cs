using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrarySpace
{
    public class Star
    {
        private int mass;
        private string name;

        public Star(int mass, string name)
        {
            this.mass = mass;
            this.name = name;
        }

        public int Mass
        {
            get
            {
                if (mass > 0)
                    return mass;
                return -1;
            }

        }

        public string Name
        {
            get
            {
                if (name != null)
                    return name;
                return "Без названия";
            }

        }

    }
}
