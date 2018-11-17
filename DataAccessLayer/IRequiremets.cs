using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    interface IRequiremets
    {
        DataTable SelectCondtion();

        void InsertCondtion(ArrayList dataCondtion, string tableName);

        void UpdateCondition(ArrayList dataCondtion, string tableName, string condition);
    }
}
