using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;

namespace DataAccessLayer
{
    public class DataHandler : IUser, IRequiremets, IPlant
    {
        private string connectionString;
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataAdapter adapter;
        private DataTable dataTable;

        // Lambda
        public delegate string connectStringDelegate(string connectionStrg);
        public connectStringDelegate connect = (connectionStrg) =>
        {
            return ConfigurationManager.ConnectionStrings[connectionStrg].ConnectionString;
        };

        public DataHandler(string connectioStringParam = "default")
        {
            this.connectionString = connect(connectioStringParam);
            connection = new SqlConnection(this.connectionString);
        }


        public DataTable SelectUser(string userName, string tableName)
        {
            string qeury = string.Format("SELECT UserID,Username,Password FROM User WHERE Username = '{0}'", userName);
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                command = new SqlCommand(qeury, connection);
                adapter = new SqlDataAdapter(command);

                dataTable = new DataTable();
                adapter.Fill(dataTable);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
            return dataTable;
        }

        public void InsertUser(ArrayList dataUser, string tableName)
        {
            StringBuilder qeury = new StringBuilder("INSERT INTO " + tableName);
            qeury.Append(" (Username,Password)");
            qeury.Append(" VALUES");
            qeury.Append(string.Format(" ('{0}','{1}')", dataUser[0], dataUser[1]));
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                command = new SqlCommand(qeury.ToString(), connection);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public void UpdateUser(ArrayList updateUser, string tableName, string username)
        {
            StringBuilder qeury = new StringBuilder("UPDATE " + tableName + " SET");
            qeury.Append(string.Format(" Username = '{0}'", updateUser[0]));
            qeury.Append(string.Format(", Password = '{0}'", updateUser[1]));
            qeury.Append(string.Format(" WHERE Username = '{0}'", username));
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                command = new SqlCommand(qeury.ToString(), connection);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public DataTable SelectCondtion()
        {
            string qeury = string.Format("SELECT * FROM Requirements");
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                command = new SqlCommand(qeury, connection);
                adapter = new SqlDataAdapter(command);

                dataTable = new DataTable();
                adapter.Fill(dataTable);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
            return dataTable;
        }

        public void InsertCondtion(ArrayList dataCondtion, string tableName)
        {
            StringBuilder qeury = new StringBuilder("INSERT INTO " + tableName);
            qeury.Append(" (AirTemperature,AirHumidity,VapourPressure,Sunshine,SoilTemperature,SoilHumidity)");
            qeury.Append(" VALUES");
            qeury.Append(string.Format(" ('{0}','{1}','{2}','{3}','{4}','{5}')", dataCondtion[0], dataCondtion[1], dataCondtion[2], dataCondtion[3], dataCondtion[4], dataCondtion[5]));
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                command = new SqlCommand(qeury.ToString(), connection);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public void UpdateCondition(ArrayList dataCondtion, string tableName, string condition)
        {
            StringBuilder qeury = new StringBuilder("UPDATE " + tableName + " SET");
            qeury.Append(string.Format(" AirTemperature = '{0}'", dataCondtion[0]));
            qeury.Append(string.Format(", AirHumidity = '{0}'", dataCondtion[1]));
            qeury.Append(string.Format(", VapourPressure = '{0}'", dataCondtion[2]));
            qeury.Append(string.Format(", Sunshine = '{0}'", dataCondtion[3]));
            qeury.Append(string.Format(", SoilTemperature = '{0}'", dataCondtion[4]));
            qeury.Append(string.Format(", SoilHumidity = '{0}'", dataCondtion[5]));
            qeury.Append(string.Format(" WHERE AirTemperature = '{0}'", condition));
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                command = new SqlCommand(qeury.ToString(), connection);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public DataTable SelectPlant()
        {
            string qeury = string.Format("SELECT * FROM Plant");
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                command = new SqlCommand(qeury, connection);
                adapter = new SqlDataAdapter(command);

                dataTable = new DataTable();
                adapter.Fill(dataTable);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
            return dataTable;
        }

        public void UpdatePlant(ArrayList updatePlant, string tableName, string plantName)
        {
            StringBuilder qeury = new StringBuilder("UPDATE " + tableName + " SET");
            qeury.Append(string.Format(" PlantName = '{0}'", updatePlant[0]));
            qeury.Append(string.Format(", PlantType = '{0}'", updatePlant[1]));
            qeury.Append(string.Format(", PlantDescription = '{0}'", updatePlant[2]));            
            qeury.Append(string.Format(" WHERE PlantName = '{0}'", plantName));
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                command = new SqlCommand(qeury.ToString(), connection);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
