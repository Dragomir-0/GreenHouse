using System;
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

        public int userID
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

        public User(int userID, string username, string password)
        {
            this.userID = userID;
            this.username = username;
            this.password = password;
        }

        public User()
        {

        }
        public User(int userID)
        {
            this.userID = userID;
        }

        public List<User> RetrieveUsers()
        {
            DataHandler handler = new DataHandler();
            DataTable data = handler.SelectUser(username, "User");
            List<User> userList = new List<User>();
            if (data != null)
            {
                foreach (DataRow row in data.Rows)
                {
                    userList.Add(new User(int.Parse(row["UserID"].ToString()), row["Username"].ToString(), row["Password"].ToString()));
                }
            }
            return userList;
        }

        public bool VerifyUser(string username, string password)
        {
            bool verified = false;
            List<User> userList = RetrieveUsers();
            foreach (User item in userList)
            {
                if (item.password.Equals(password))
                {
                    verified = true;
                }
            }
            return verified;
        }


    }
}
