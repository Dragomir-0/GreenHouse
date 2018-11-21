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
        private SqlCommand command;
        private SqlDataAdapter adapter;
        private DataTable dataTable;

        SqlConnectionStringBuilder connectionString = new SqlConnectionStringBuilder();

        public DataHandler()
        {
            connectionString.DataSource = @"DESKTOP-T4H3RHU";
            connectionString.InitialCatalog = "AutoGreenHouse";
            connectionString.IntegratedSecurity = true;
        }


        public DataTable SelectUser(string tableName)
        {
            SqlConnection connection = new SqlConnection(connectionString.ToString());
            string query = string.Format("SELECT * FROM [User]");
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                command = new SqlCommand(query, connection);
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
            SqlConnection connection = new SqlConnection(connectionString.ToString());
            StringBuilder query = new StringBuilder("INSERT INTO [" + tableName);
            query.Append("] (Username,Password, PlantID)");
            query.Append(" VALUES");
            query.Append(string.Format(" ('{0}','{1}', '{2}')", dataUser[0], dataUser[1], dataUser[2]));
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                command = new SqlCommand(query.ToString(), connection);
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

        public void UpdateUser(ArrayList updateUser, string tableName, int userID)
        {
            SqlConnection connection = new SqlConnection(connectionString.ToString());
            StringBuilder query = new StringBuilder("UPDATE [" + tableName + "] SET");
            query.Append(string.Format(" Username = '{0}'", updateUser[0]));
            query.Append(string.Format(", Password = '{0}'", updateUser[1]));
            query.Append(string.Format(", PlantID = '{0}'", updateUser[2]));
            query.Append(string.Format(" WHERE UserID = '{0}'", userID));
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                command = new SqlCommand(query.ToString(), connection);
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
            SqlConnection connection = new SqlConnection(connectionString.ToString());
            string query = string.Format("SELECT * FROM Requirements");
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                command = new SqlCommand(query, connection);
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
            SqlConnection connection = new SqlConnection(connectionString.ToString());
            StringBuilder query = new StringBuilder("INSERT INTO " + tableName);
            query.Append(" (AirTemperature,AirHumidity,VapourPressure,Sunshine,SoilTemperature,SoilHumidity)");
            query.Append(" VALUES");
            query.Append(string.Format(" ('{0}','{1}','{2}','{3}','{4}','{5}')", dataCondtion[0], dataCondtion[1], dataCondtion[2], dataCondtion[3], dataCondtion[4], dataCondtion[5]));
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                command = new SqlCommand(query.ToString(), connection);
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

        public void UpdateCondition(ArrayList dataCondtion, string tableName, int requirementID)
        {
            SqlConnection connection = new SqlConnection(connectionString.ToString());
            StringBuilder query = new StringBuilder("UPDATE " + tableName + " SET");
            query.Append(string.Format(" AirTemperature = '{0}'", dataCondtion[0]));
            query.Append(string.Format(", AirHumidity = '{0}'", dataCondtion[1]));
            query.Append(string.Format(", VapourPressure = '{0}'", dataCondtion[2]));
            query.Append(string.Format(", Sunshine = '{0}'", dataCondtion[3]));
            query.Append(string.Format(", SoilTemperature = '{0}'", dataCondtion[4]));
            query.Append(string.Format(", SoilHumidity = '{0}'", dataCondtion[5]));
            query.Append(string.Format(" WHERE RequirementID = '{0}'", requirementID));
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                command = new SqlCommand(query.ToString(), connection);
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
            SqlConnection connection = new SqlConnection(connectionString.ToString());
            string query = string.Format("SELECT * FROM Plant");
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                command = new SqlCommand(query, connection);
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

        public void UpdatePlant(ArrayList updatePlant, string tableName, int plantID)
        {
            SqlConnection connection = new SqlConnection(connectionString.ToString());
            StringBuilder query = new StringBuilder("UPDATE " + tableName + " SET");
            query.Append(string.Format(" PlantName = '{0}'", updatePlant[0]));
            query.Append(string.Format(", PlantType = '{0}'", updatePlant[1]));
            query.Append(string.Format(", PlantDescription = '{0}'", updatePlant[2]));            
            query.Append(string.Format(" WHERE PlantID = '{0}'", plantID));
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                command = new SqlCommand(query.ToString(), connection);
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
