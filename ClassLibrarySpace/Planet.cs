using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrarySpace
{
    public class Planet : Star
    {
        private int SatelliteCount_;
        private int PeriodRotate_;
        public List<Satellite> Satellites = new List<Satellite>();

        public Planet(int SatelliteCount, int PeriodRotate, int mass, string name) : base(mass, name)
        {
            SatelliteCount_ = SatelliteCount;
            PeriodRotate_ = PeriodRotate;
        }

        public int SatelliteCount
        {
            get
            {
                if (SatelliteCount_ >= 0)
                    return SatelliteCount_;

                return -1;
            }
        }

        public int PeriodRotate
        {
            get
            {
                if (SatelliteCount_ >= 0)
                    return PeriodRotate_;

                return -1;

            }
        }

        public void AddSatellite(string _SatelliteInfo)
        {
            string[] inf = _SatelliteInfo.Split(new Char[] { ' ', ',', '.', ':' });

            if (inf != null) 
                for(int k = 0 , i = 0; i < inf.Length; i++)
                {
                
                    string _name, _mass, _People, _Year;

                    if (inf[i].Trim() != "")
                    {
                        if (k < 3)  
                        {
                            k++;
                            continue;
                        }
                        _name = inf[i - k];
                        _mass = inf[i - 2];
                        _People = inf[i - 1];
                        _Year = inf[i];

                        k = 0;

                        Satellite satellite = new Satellite(_People, Convert.ToInt32(_Year), Convert.ToInt32(_mass), _name);
                        Satellites.Add(satellite);
                    }

                }

            
        }

    }
}
