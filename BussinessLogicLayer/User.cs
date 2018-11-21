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
    public class User
    {
        private int userID;
        private string username;
        private string password;
        private int userPlantID;

        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string  Password
        {
            get { return password; }
            set { password = value; }
        }

        public int UserPlantID
        {
            get { return userPlantID; }
            set { userPlantID = value; }
        }


        public User(int userID, string username, string password, int userPlantID)
        {
            this.userID = userID;
            this.username = username;
            this.password = password;
            this.userPlantID = userPlantID;
        }

        public User(string username, string password, int userPlantID)
        {
            this.username = username;
            this.password = password;
            this.userPlantID = userPlantID;
        }


        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public User()
        {

        }
        public User(int userID, int UserPlantID)
        {
            this.userID = userID;
            this.userPlantID = UserPlantID;
        }

        public User(int userID)
        {
            this.userID = userID;
        }

        public List<User> RetrieveUsers()
        {
            DataHandler handler = new DataHandler();
            DataTable data = handler.SelectUser("User");
            List<User> userList = new List<User>();
            foreach (DataRow row in data.Rows)
            {
                userList.Add(new User(int.Parse(row["UserID"].ToString()), row["Username"].ToString(), row["Password"].ToString(), int.Parse(row["PlantID"].ToString())));
            }
            
            return userList;
        }

        public User VerifyUser(string username, string password)
        {
            User user = new User();
            List<User> userList = RetrieveUsers();
            foreach (User item in userList)
            {
                if (item.password.Equals(password) && item.username.Equals(username))
                {
                    user = new User(item.userID, item.username, item.password, item.userPlantID);
                }
            }
            return user;
        }

        public void InsertUser(User userParam)
        {
            DataHandler handler = new DataHandler();
            ArrayList userList = new ArrayList() { userParam.username, userParam.password, userParam.userPlantID };
            handler.InsertUser(userList, "User");
        }

        public void UpdateUser(User userParam)
        {
            DataHandler handler = new DataHandler();
            ArrayList userList = new ArrayList() { userParam.username, userParam.password, userParam.userPlantID };
            handler.UpdateUser(userList, "User", userParam.userID);
        }
    }
}
