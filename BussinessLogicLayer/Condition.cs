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
    public class Condition:Plant
    {
        private int requirementID;
        private string airTemperature;
        private string airHumidity;
        private string vapourPressure;
        private string sunshine;
        private string soilTemperature;
        private string soilHumidity;


        public int RequirementID
        {
            get { return requirementID; }
            set { requirementID = value; }
        }

        public string AirTemperature
        {
            get { return airTemperature; }
            set { airTemperature = value; }
        }

        public string AirHumidity
        {
            get { return airHumidity; }
            set { airHumidity = value; }
        }

        public string VapourPressure
        {
            get { return vapourPressure; }
            set { vapourPressure = value; }
        }

        public string Sunshine
        {
            get { return sunshine; }
            set { sunshine = value; }
        }

        public string SoilTemperature
        {
            get { return soilTemperature; }
            set { soilTemperature = value; }
        }

        public string SoilHumidity
        {
            get { return soilHumidity; }
            set { soilHumidity = value; }
        }

        public Condition()
        {

        }

        public Condition(int requirementID, string airTemperature, string airHumidity, string vapourPressure, string sunshine, 
            string soilTemperature, string soilHumidity, int plantID):base(plantID)
        {
            this.requirementID = requirementID;
            this.airTemperature = airTemperature;
            this.airHumidity = airHumidity;
            this.vapourPressure = vapourPressure;
            this.sunshine = sunshine;
            this.soilTemperature = soilTemperature;
            this.soilHumidity = soilHumidity;
        }

        public List<Condition> RetrieveConditions()
        {
            List<Condition> conditionList = new List<Condition>();
            DataHandler handler = new DataHandler();
            DataTable dataTable = handler.SelectCondtion();
            foreach (DataRow conditionData in dataTable.Rows)
            {
                conditionList.Add(new Condition(int.Parse(conditionData["RequirementID"].ToString()), conditionData["AirTemperature"].ToString(),
                    conditionData["AirHumidity"].ToString(), conditionData["VapourPressure"].ToString(), conditionData["Sunshine"].ToString(), 
                    conditionData["SoilTemperature"].ToString(), conditionData["SoilHumidity"].ToString(), int.Parse(conditionData["PlantID"].ToString())));
            }
            return conditionList;
        }

        public Condition RetrieveUserCondition(int plantID)
        {
            Condition condition = new Condition();
            List<Condition> conditionList = RetrieveConditions();
            foreach (Condition item in conditionList)
            {
                if (plantID == item.PlantID)
                {
                    condition = new Condition(item.requirementID, item.airTemperature, item.airHumidity, item.vapourPressure, item.sunshine, item.soilTemperature, item.soilHumidity, item.UserPlantID);
                }
            }
            return condition;
        }

        public void UpdateCondition(Condition condition)
        {
            ArrayList conditionList = new ArrayList() { condition.requirementID, condition.airTemperature, condition.airHumidity, condition.vapourPressure, condition.sunshine, condition.soilTemperature, condition.soilHumidity, condition.UserPlantID };
            DataHandler handler = new DataHandler();
            handler.UpdateCondition(conditionList, "Requirements", condition.requirementID);
        }

    }
}
