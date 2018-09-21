using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrarySpace
{
    public class Satellite : Star
    {
        private string _OpenPeople;
        private int _OpenYear;

        public Satellite(string OpenPeople, int OpenYear, int mass, string name) : base(mass, name)
        {
            _OpenPeople = OpenPeople;
            _OpenYear = OpenYear;
        }

        public string OpenPeople
        {
            get
            {
                if (_OpenPeople != null)
                    return _OpenPeople;
                return "null";
            }
        }

        public int OpenYear
        {
            get
            {
                if (_OpenYear > 0)
                    return _OpenYear;

                return -1;
            }
        }
    }
}
