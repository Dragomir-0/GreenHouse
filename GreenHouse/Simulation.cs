using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLogicLayer;

namespace GreenHouse
{
    public partial class Simulation : Form
    {
        Plant plant;
        Condition condition;
        public Simulation(Plant plant, Condition condition)
        {
            this.plant = plant;
            this.condition = condition;
            InitializeComponent();
        }

        private void Simulation_Load(object sender, EventArgs e)
        {
            txtPlantNameSimulation.Text = plant.PlantName;
            txtPlantTypeSimulation.Text = plant.PlantType;
            txtPlantDescriptionSimulation.Text = plant.PlantDescription;

            txtAirHumiditySimulation.Text = condition.AirHumidity;
            txtAirTemperatureSimulation.Text = condition.AirTemperature;
            txtSoilHumiditySimulation.Text = condition.SoilHumidity;
            txtSoilTemperatureSimulation.Text = condition.SoilTemperature;
            txtSunshineSimulation.Text = condition.Sunshine;
            txtVapourPressureSimulation.Text = condition.VapourPressure;

        }

        private void btnOkaySimulation_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
