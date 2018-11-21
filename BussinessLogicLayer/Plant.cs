using System;
using System.Collections;
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

        public Plant(int plantID, string plantName, string plantType, string plantDescription, int userPlantID):base(userPlantID)
        {
            this.plantID = plantID;
            this.plantName = plantName;
            this.plantType = plantType;
            this.plantDescription = plantDescription;
        }

        public Plant(int plantID, string plantName, string plantType, string plantDescription)
        {
            this.plantID = plantID;
            this.plantName = plantName;
            this.plantType = plantType;
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
                    plantData["PlantType"].ToString(), plantData["PlantDescription"].ToString()));
            }

            return plantList;
        }

        public Plant RetrieveUserPlant(int userID)
        {
            Plant plant = new Plant();
            List<Plant> plantList = RetrievePlants();
            User user = new User();
            List<User> userList = user.RetrieveUsers();
            foreach (User userItem in userList)
            {
                if (userItem.UserID == userID)
                {
                    foreach (Plant plantItem in plantList)
                    {
                        if (userItem.UserPlantID == plantItem.plantID)
                        {
                            plant = new Plant(plantItem.plantID, plantItem.plantName, plantItem.PlantType, plantItem.plantDescription);
                        }
                    }
                }
            }
            return plant;
        }

        public void UpdatePlant(Plant plant)
        {
            ArrayList plantList = new ArrayList() { plant.plantID, plant.plantName, plant.plantType, plant.PlantDescription, plant.UserID };
            DataHandler handler = new DataHandler();
            handler.UpdatePlant(plantList, "Plant", plant.plantID);
        }

        public override string ToString()
        {
            return string.Format("{0}", plantName);
        }
    }
}
