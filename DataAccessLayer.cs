using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Doctors
{
   public class DataAccessLayer
    {
        public SqlConnection sqlcon;
       
        public DataAccessLayer()
        {
            sqlcon = new SqlConnection(@"Server=" + Properties.Settings.Default.Server + "; Database=" + Properties.Settings.Default.Database + "; Integrated Security=true");
            //sqlcon = new SqlConnection(@"Data Source=DESKTOP-GIL9I30\SQLEXPRESS2019;Initial Catalog=Doctor;Trusted_Connection=True");
        }

        public void Open()
        {
            if (sqlcon.State != ConnectionState.Open)
            {
                sqlcon.Open();
            }
        }

       
        public void Close()
        {
            if (sqlcon.State == ConnectionState.Open)
            {
                sqlcon.Close();
            }
        }

        public DataTable SelectData(string stored_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = sqlcon;

            if (param != null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    sqlcmd.Parameters.Add(param[i]);
                }
            }
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
