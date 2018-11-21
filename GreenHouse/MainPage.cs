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
    public partial class MainPage : Form
    {
        Plant plant;
        User user;
        BindingSource bindingSourcePlant;
        BindingSource bindingSourceCondition;
        public MainPage()
        {
            InitializeComponent();
        }

        public MainPage(Plant plantParam, User userParam)
        {
            this.plant = plantParam;
            this.user = userParam;
            InitializeComponent();
        }
        public MainPage(User userParam)
        {
            this.user = userParam;
            InitializeComponent();
        }


        private void MainPage_Load(object sender, EventArgs e)
        {
            bindingSourcePlant = new BindingSource();
            bindingSourceCondition = new BindingSource();
            IsPlantSelected();
        }

        private void selectPlantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectPlant selectPlant = new SelectPlant(user);
            this.Hide();
            selectPlant.Show();
        }

        private void viewCurrentPlantToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
        }

        private void IsPlantSelected()
        {
            plant = new Plant();
            plant = plant.RetrieveUserPlant(user.UserID);
            Condition condition = new Condition();
            condition = condition.RetrieveUserCondition(plant.PlantID);
            if (plant.PlantID != 0)
            {
                lblConditionsMainPage.Visible = true;
                lblSelectedPlantMainPage.Visible = true;
                bindingSourcePlant.DataSource = plant;
                dgvPlantMainPage.DataSource = bindingSourcePlant;
                bindingSourceCondition.DataSource = condition;
                dgvConditionsMainPage.DataSource = bindingSourceCondition;
                dgvConditionsMainPage.Columns[0].Visible = false;
                dgvConditionsMainPage.Columns[7].Visible = false;
                dgvConditionsMainPage.Columns[8].Visible = false;
                dgvConditionsMainPage.Columns[9].Visible = false;
                dgvConditionsMainPage.Columns[10].Visible = false;
                dgvConditionsMainPage.Columns[11].Visible = false;
                dgvConditionsMainPage.Columns[12].Visible = false;
                dgvConditionsMainPage.Columns[13].Visible = false;
                dgvConditionsMainPage.Columns[14].Visible = false;
                dgvConditionsMainPage.Visible = true;
                dgvPlantMainPage.Columns[0].Visible = false;
                dgvPlantMainPage.Columns[4].Visible = false;
                dgvPlantMainPage.Columns[5].Visible = false;
                dgvPlantMainPage.Columns[6].Visible = false;
                dgvPlantMainPage.Columns[7].Visible = false;
                dgvPlantMainPage.Visible = true;
                btnSimulateMainPage.Visible = true;
                lblMainPageIntro.Visible = false;
            }
            else
            {
                lblMainPageIntro.Visible = true;
                lblConditionsMainPage.Visible = false;
                lblSelectedPlantMainPage.Visible = false;
                dgvConditionsMainPage.Visible = false;
                dgvPlantMainPage.Visible = false;
                btnSimulateMainPage.Visible = false;
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void updateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateOrInsertUser updateOrInsertUser = new UpdateOrInsertUser(user, "Update");
            this.Hide();
            updateOrInsertUser.Show();

        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateOrInsertUser updateOrInsertUser = new UpdateOrInsertUser(user, "Insert");
            this.Hide();
            updateOrInsertUser.Show();
        }

        private void updatePlantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdatePlant updateOrInsertPlant = new UpdatePlant(user, plant);
            this.Hide();
            updateOrInsertPlant.Show();
        }
    }
}
