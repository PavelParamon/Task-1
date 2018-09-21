using System;
using System.Collections.Generic;
using System.Text;


namespace ClassLibrarySpace
{
    public class Functions
    {
        public List<Star> Stars;
        public List<Planet> Planets;

        public Functions()
        {
            Stars = new List<Star>();
            Planets = new List<Planet>();
        }

        public void AddStar(int _mass, string _name)
        {
            Star star = new Star(_mass, _name);
            Stars.Add(star);
        }

        public void AddPlanet(int _mass, string _name, int _count, int _period, string _SatelliteInfo)
        {
            Planet planet = new Planet(_count, _period, _mass, _name);

            if (_count != 0 && _SatelliteInfo != null) 
            {
                planet.AddSatellite(_SatelliteInfo);
            }
            Planets.Add(planet);
        }

        public  int CountPlanets()
        {
            return Planets.Count;
        }

        public string[] PrintNameStars()
        {
            string[] nameStars = new string[Stars.Count];

            for (int i = 0; i < Stars.Count; i++)
            {
                nameStars[i] =  Convert.ToString(i + 1) + ") " + Stars[i].Name + '\n';
            }

            return nameStars;

            
        }

        public string[] PrintInfoPlanets()
        {
            string[] inf = new string[Planets.Count];

            if (Planets.Count == 0)
                return null;

            for(int i = 0; i < Planets.Count; i++)
            {
                inf[i] = Convert.ToString(i + 1) + ") Название: " + Planets[i].Name + ",  Масса: " + Convert.ToString(Planets[i].Mass) + ", Период вращения: " +
                    Convert.ToString(Planets[i].PeriodRotate) + ", Кол-во спутников: " + Convert.ToString(Planets[i].SatelliteCount);
                if (Planets[i].SatelliteCount == 0)
                    inf[i] += Environment.NewLine;

                for(int j = 0; j < Planets[i].Satellites.Count; j++)
                {
                    inf[i] += Environment.NewLine + "      Спутник" +  Convert.ToString(j + 1) + ") Название: " + Convert.ToString(Planets[i].Satellites[j].Name) + ", Масса спутника: " +
                        Convert.ToString(Planets[i].Satellites[j].Mass) + ", Открыватель: " + Planets[i].Satellites[j].OpenPeople + ", Год открытия: " + 
                        Convert.ToString(Planets[i].Satellites[j].OpenYear) + '\n';
                }

            }
            return inf;
        }

    }
}
