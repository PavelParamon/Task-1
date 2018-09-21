using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClassLibrarySpace;
using Utils;

namespace Task_1
{
    public partial class MainForm : Form
    {
        public Functions SpaceObjects = new Functions();

        public MainForm()
        {
            InitializeComponent();
        }

        private void AddPlanetButton_Click(object sender, EventArgs e)
        {
            try
            {
                string _namePlanet = FormsUtils.Enter("Укажите название планеты", "Информация планеты");
                int _massPlanet = Convert.ToInt32(FormsUtils.Enter("Укажите массу планеты", "Информация планеты"));
                int _period = Convert.ToInt32(FormsUtils.Enter("Укажите период вращения планеты", "Информация планеты"));
                int _count = Convert.ToInt32(FormsUtils.Enter("Укажите кол-во спутников планеты", "Информация планеты"));


                string SatelliteInf = null;


                if (_count > 0)
                {

                    for (int i = 0; i < _count; i++)
                    {
                        string _nameSatellite = FormsUtils.Enter("Укажите название спутника", "Информация спутника");
                        string _massSatellite = FormsUtils.Enter("Укажите массу спутника", "Информация спутника");
                        string _People = FormsUtils.Enter("Укажите открываателя", "Информация спутника");
                        string _Year = FormsUtils.Enter("Укажите год открытия", "Информация спутника");

                        SatelliteInf += " " +  _nameSatellite + " " + _massSatellite + " " + _People + " " + _Year;
                    }
                }

                SpaceObjects.AddPlanet(_massPlanet, _namePlanet, _count, _period, SatelliteInf);
            }
            catch
            {
                FormsUtils.ErrorMessageBox("Error");
            }

            
        }

        private void AddStarButton_Click(object sender, EventArgs e)
        {
            try
            {
                string _nameStar = FormsUtils.Enter("Укажите название звезды", "Информация звезды");
                int _massStar = Convert.ToInt32(FormsUtils.Enter("Укажите массу звезды", "Информация звезды"));
                SpaceObjects.AddStar(_massStar, _nameStar);
            }
            catch
            {
                FormsUtils.ErrorMessageBox("Error");
            }
        }

        private void CountPlanetButton_Click(object sender, EventArgs e)
        {
            try
            {
                string count = Convert.ToString(SpaceObjects.CountPlanets());
                FormsUtils.ShowMessage(count);
            }
            catch
            {
                FormsUtils.ErrorMessageBox("Error");
            }
        }

        private void NameStarButton_Click(object sender, EventArgs e)
        {
            try
            {
                InfoTextBox.Text = "";
                string[] name = SpaceObjects.PrintNameStars();
                for(int i = 0; i < name.Length; i++)
                {
                    InfoTextBox.AppendText(name[i]);
                }
                
            }
            catch
            {
                FormsUtils.ErrorMessageBox("Error");
            }
        }

        private void PlanetsInfoButton_Click(object sender, EventArgs e)
        {
            try
            {
                InfoTextBox.Text = "";
                string[] planetsInfo = SpaceObjects.PrintInfoPlanets();
                for(int i = 0;i < planetsInfo.Length; i++)
                {
                    InfoTextBox.AppendText(planetsInfo[i]);
                }
            }
            catch
            {
                FormsUtils.ErrorMessageBox("Error");
            }
        }
    }
}
