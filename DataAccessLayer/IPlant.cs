﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    interface IPlant
    {
        DataTable SelectPlant();

        void UpdatePlant(ArrayList updatePlant, string tableName, int plantID);
    }
}
