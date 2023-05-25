using BOL.DataBaseEntities;
using DAL.DataServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.LogicServices
{
    public class StudentsLogic : IStudentsLogic
    {
        private readonly IStudentsDataDAL _studentsDataDAL;
        public StudentsLogic(IStudentsDataDAL studentsDataDAL)
        {
            this._studentsDataDAL = studentsDataDAL;
        }
        public List<Students> GetStudentsListLogic()
        {
            List<Students> result = new List<Students>();
            result = _studentsDataDAL.GetStudentsListDAL();
            return result;
        }
        public string saveStudentRecordLogic(Students FormData)
        {
            string result = string.Empty;
            if (String.IsNullOrWhiteSpace(FormData.FirstName) || String.IsNullOrWhiteSpace(FormData.LastName) || String.IsNullOrWhiteSpace(FormData.Email))
            {
                result = "please fill all forms";
                return result;
            }
            result = _studentsDataDAL.saveStudentRecordDAL(FormData);
            if(result == "Saved Sucessfully")
            {
                return "Saved Sucessfully";
            }
            else
            {
                result = "An Error Ocured please Try Again";
                return result;
            } 
        }
    }
    
}
