using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment_automation
{
    class SqlHelper
    {  
        private string ConnectionString { get; set; }
        public SqlConnection SqlConnection { get; set; }

        public SqlHelper()
        {
           
            ConnectionString = @"Data Source=DESKTOP-L0NA0DU\SQLEXPRESS;Initial Catalog=Apartment;Integrated Security=True";
            SqlConnection = new SqlConnection(ConnectionString);
        }

        public  void  ExecuteProcedure(string ProcName,params SqlParameter[] ps)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = ProcName;
            command.Parameters.AddRange(ps);
            command.Connection = SqlConnection;
            SqlConnection.Open();
            command.ExecuteNonQuery();
            SqlConnection.Close();
        }

        public DataTable GetDataTable(string query)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, ConnectionString);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            return dataTable;
        }
    }
}
