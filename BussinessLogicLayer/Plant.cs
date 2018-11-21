using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BussinessLogicLayer
{
    public class Plant:User
    {
        private int plantID;
        private string plantName;
        private string plantType;
        private string plantDescription;
        public int PlantID
        {
            get { return plantID; }
            set { plantID = value; }
        }

        public string PlantName
        {
            get { return plantName; }
            set { plantName = value; }
        }

        public string PlantType
        {
            get { return plantType; }
            set { plantType = value; }
        }

        public string PlantDescription
        {
            get { return plantDescription; }
            set { plantDescription = value; }
        }


        public Plant()
        {

        }

        public Plant(int plantID)
        {
            this.plantID = plantID;
        }

        public Plant(int plantID, string plantName, string plantType, string plantDescription, int userID):base(userID)
        {
            this.plantID = plantID;
            this.plantName = plantName;
            this.plantDescription = plantDescription;
        }

        public List<Plant> RetrievePlants()
        {
            List<Plant> plantList = new List<Plant>();
            DataHandler handler = new DataHandler();
            DataTable table = handler.SelectPlant();
            foreach (DataRow plantData in table.Rows)
            {
                plantList.Add(new Plant(int.Parse(plantData["PlantID"].ToString()), plantData["PlantName"].ToString(), 
                    plantData["PlantType"].ToString(), plantData["PlantDescription"].ToString(), int.Parse(plantData["UserID"].ToString())));
            }

            return plantList;
        }

        public List<Plant> CurrentPlantsInGreenhouse()
        {
            List<Plant> currentPlantList = new List<Plant>();

            return currentPlantList;

        }
    }
}
