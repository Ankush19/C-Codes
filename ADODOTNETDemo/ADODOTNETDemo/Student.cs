using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ADODOTNETDemo
{
    public class Student
    {
        public SqlHelper _sqlHelper;
        public string sqlQuery;

        public Student()
        {
            _sqlHelper = new SqlHelper();
        }

        //public void update()
        //{
        //    int rno;
        //    string name;
        //    Console.WriteLine("Enter rolll no to update");
        //    rno = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Enter updated name");
        //    name = Console.ReadLine();
        //    sqlQuery = string.Format("update [Table] SET RNo={0},StudName={1} Where (RNo={0} )",rno,name);
        //    _sqlHelper.updateExecute(sqlQuery);
        //}

        public void GetData()
        {
            sqlQuery = "select * from [Table]";
            var sqlReader = _sqlHelper.ExecuteQuery(sqlQuery);
            //Console.WriteLine(sqlReader[0]);
            while (sqlReader.Read())
            {

                Console.WriteLine(string.Format("RollNo:{0}\nStudentName:{1}", sqlReader[0].ToString(), sqlReader[1].ToString()));

            }
            sqlReader.Close();

            sqlQuery = "select * from [Table]";
            var count = _sqlHelper.ExecuteScalar(sqlQuery);
            Console.WriteLine("Count " + count);
          }

        public void SaveData()
        {
            Console.WriteLine("Enter roll no");
            int rno = int.Parse(Console.ReadLine());
            sqlQuery = string.Format(@"insert into [Table] values({0},'{1}',{2},'{3}')",rno,"ank",23,"2344323333");
            _sqlHelper.ExecuteNonQuery(sqlQuery);

        }

        public void getDataSet()
        {
            sqlQuery = "select * from [Table]";
            DataTable dt=_sqlHelper.GetDataSet(sqlQuery);
            foreach   (DataRow dr in dt.Rows)
            {
                Console.WriteLine(string.Format("RollNo:{0}\n"+"StudentName:{1}",dr[0].ToString(),dr[1].ToString()));
            }
            dt.WriteXml("Student.xls");
        }

        public void doUpdate()
        {
            _sqlHelper.update(5, "aaaaaaa");

        }

        public void doDelete()
        {
            _sqlHelper.delete(10);

        }
    }
}
