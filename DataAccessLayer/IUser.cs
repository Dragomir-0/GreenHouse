
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    interface IUser
    {
        DataTable SelectUser(string tableName);

        void InsertUser(ArrayList dataUser, string tableName);

        void UpdateUser(ArrayList updateUser, string tableName, int userID);
    }
}
