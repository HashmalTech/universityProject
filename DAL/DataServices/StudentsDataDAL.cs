using BOL.DataBaseEntities;
using DAL.DataContext;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DataServices
{
    public  class StudentsDataDAL : IStudentsDataDAL
    {
        private readonly IDapperOrmHelper _dapperOrmhelper;
        public StudentsDataDAL(IDapperOrmHelper dapperOrmhelper)
        {
            this._dapperOrmhelper = dapperOrmhelper;
        }

        public List<Students> GetStudentsListDAL()
        {
            List<Students> students = new List<Students>();
            try
            {
                using (IDbConnection dbConnection = _dapperOrmhelper.GetDapperContexthelper())
                {
                    String sql = "select * from Students";
                    students = dbConnection.Query<Students>(sql,commandType:CommandType.Text).ToList();
                }
            }
            catch (Exception ex)
            {
                String message = ex.Message;
            }
        return students;
        }

        public string saveStudentRecordDAL(Students Formdata)
        {
            string result = string.Empty;
            try
            {
                using (IDbConnection dbConnection = _dapperOrmhelper.GetDapperContexthelper())
                { 
                    dbConnection.Execute(@"insert into Students(FirstName,LastName,Email) values(@FirstName,@LastName,@Email)", 
                        new
                        {
                            FirstName = Formdata.FirstName, Lastname = Formdata.LastName, Email = Formdata.Email
                        },
                        commandType: CommandType.Text);
                    result = "Saved Sucessfully";
                }
            }
            catch (Exception ex)
            {
                String message = ex.Message;
            }
            return result;
        }
    }
}
