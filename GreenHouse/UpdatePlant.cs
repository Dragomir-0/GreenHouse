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
    public partial class UpdatePlant : Form
    {
        User user;
        Plant plant;
        Condition condition;
        public UpdatePlant()
        {
            InitializeComponent();
        }
        public UpdatePlant(User user, Plant plant)
        {
            this.user = user;
            this.plant = plant;
            InitializeComponent();
        }

        private void UpdateOrInsertPlant_Load(object sender, EventArgs e)
        {
                condition = new Condition();
                condition = condition.RetrieveUserCondition(plant.PlantID);
                txtPlantNameUpdate.Text = plant.PlantName;
                txtPlantTypeUpdate.Text = plant.PlantType;
                txtPlantDescriptionUpdate.Text = plant.PlantDescription;
                txtAirHumidityUpdate.Text = condition.AirHumidity;
                txtAirTemperatureUpdate.Text = condition.AirTemperature;
                txtSoilHumidityUpdate.Text = condition.SoilHumidity;
                txtSoilTemperatureUpdate.Text = condition.SoilTemperature;
                txtSunshineUpdate.Text = condition.Sunshine;
                txtVapourPressureUpdate.Text = condition.VapourPressure;
        }

        private void btnBackUOI_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage(user);
            this.Hide();
            mainPage.Show();
        }

        private void btnUpdateOrInsertPlant_Click(object sender, EventArgs e)
        {
            string plantName = txtPlantNameUpdate.Text;
            string plantType = txtPlantTypeUpdate.Text;
            string plantDescription = txtPlantDescriptionUpdate.Text;

            string airTemperature = txtAirTemperatureUpdate.Text;
            string airHumidity = txtAirHumidityUpdate.Text;
            string vapourPressure = txtVapourPressureUpdate.Text;
            string sunshine = txtSunshineUpdate.Text;
            string soilTemperature = txtSoilTemperatureUpdate.Text;
            string soilHumidity = txtSoilHumidityUpdate.Text;

            plant = new Plant(plant.UserPlantID, plantName, plantType, plantDescription);
            plant.UpdatePlant(plant);

            condition = new Condition(condition.RequirementID, airTemperature, airHumidity, vapourPressure, sunshine, soilTemperature, soilHumidity, plant.UserPlantID);
            condition.UpdateCondition(condition);

            MessageBox.Show("Successfully updated", "Update" ,MessageBoxButtons.OK);
            
        }
    }
}
