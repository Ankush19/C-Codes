using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ADODOTNETDemo
{
    public class SqlHelper
    {
        private SqlConnection _sqlConnection;
        private SqlCommand _sqlCommand;
        public SqlDataAdapter _sqlDataAdapter;
        public string sqlQuery = null;
        public string conString = @"Data Source=ANKUSH-D;Initial Catalog=DemoStudent;Integrated Security=True;Pooling=False";
        public SqlHelper()
        {
            _sqlConnection = new SqlConnection(conString);
            if (_sqlConnection.State == System.Data.ConnectionState.Closed) 
            _sqlConnection.Open();
            Console.WriteLine("Connection is open");

        }


        public SqlDataReader ExecuteQuery(string sqlQuery)
        {
            _sqlCommand = new SqlCommand(sqlQuery,_sqlConnection);
            //_sqlCommand.CommandText = sqlQuery;
            //_sqlCommand.Connection = _sqlConnection;
            return _sqlCommand.ExecuteReader();
        }

        public string ExecuteScalar(string sqlQuery)
        {
            _sqlCommand = new SqlCommand(sqlQuery, _sqlConnection);
            //_sqlCommand.CommandText = sqlQuery;
            //_sqlCommand.Connection = _sqlConnection;
            return _sqlCommand.ExecuteScalar().ToString();
        }

        public bool ExecuteNonQuery(string sql)
        {
            var result = false;
            _sqlCommand = new SqlCommand(sql, _sqlConnection);
            var count = _sqlCommand.ExecuteNonQuery();
            result = count > 0 ? true : false;
            return result;
        }

        public DataTable GetDataSet(string sqlQuery)
        {
            var ds = new DataSet();
            _sqlDataAdapter = new SqlDataAdapter(sqlQuery, conString);
            _sqlDataAdapter.Fill(ds, "Student");
            return ds.Tables[0];
        }

        public void update(int rno,string name)
        {
            sqlQuery = string.Format("select * from [Table] where rno={0}",rno);
            var ds = new DataSet();
            _sqlDataAdapter = new SqlDataAdapter(sqlQuery, conString);
            SqlCommandBuilder sb = new SqlCommandBuilder(_sqlDataAdapter);
            _sqlDataAdapter.Fill(ds, "student");
            DataTable dt = ds.Tables[0];
            dt.Rows[0][0] = rno;
            dt.Rows[0][1] = name;
            _sqlDataAdapter.Update(dt);
            
        }

        public void delete(int rno)
        {
            sqlQuery = string.Format("select * from [Table] where RNo={0}",rno);
            var ds = new DataSet();
            _sqlDataAdapter = new SqlDataAdapter(sqlQuery, conString);
            SqlCommandBuilder sb = new SqlCommandBuilder(_sqlDataAdapter);
            _sqlDataAdapter.Fill(ds, "student");

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                row.Delete();
            }
            DataTable dt = ds.Tables[0];
            _sqlDataAdapter.Update(dt);

        }


        //public bool updateExecute(string sqlQuery)
        //{
        //    var result = false;
        //    _sqlCommand = new SqlCommand(sqlQuery, _sqlConnection);
        //    var count = _sqlCommand.ExecuteNonQuery();
        //    result = count > 0 ? true : false;
        //    return result;
        //}
    }
}
