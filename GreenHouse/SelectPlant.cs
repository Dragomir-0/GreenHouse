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
    public partial class SelectPlant : Form
    {
        User user;
        public SelectPlant(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void SelectPlant_Load(object sender, EventArgs e)
        {
            Plant plant = new Plant();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = plant.RetrievePlants();
            lbxCurrentPlants.DataSource = bindingSource;
            List<Plant> plantList = plant.RetrievePlants();  
        }

        private void btnSelectPlant_Click(object sender, EventArgs e)
        {
            Plant selectedPlant = (Plant)lbxCurrentPlants.SelectedItem;
            MainPage page = new MainPage(selectedPlant, user);
            user.UserPlantID = selectedPlant.PlantID;
            user.UpdateUser(user);
            this.Hide();
            page.Show();
        }
    }
}
