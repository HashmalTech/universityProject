﻿using BOL.DataBaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DataServices
{
    public  interface IStudentsDataDAL
    {
        List<Students> GetStudentsListDAL();
        string saveStudentRecordDAL(Students FormData);
    }
}
