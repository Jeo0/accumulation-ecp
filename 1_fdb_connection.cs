using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectNamin
{
    internal class fdb_connection
    {
        //declaration of variables for database connections and query which to access from one form to another
        public String connectionString = null;
        public SqlConnection sql_connection;
        public SqlCommand sql_command;
        public DataSet sql_dataset;
        public SqlDataAdapter sql_dataadapter;
        public string sql = null;
        public void connString()//codes to establish connection from C# forms to the SQL Server database
        {
            sql_connection = new SqlConnection();
            //connectionString = connectionString = "Data Source = JUDEE\\SQLEXPRESS; Initial Catalog = POSDB; user id = qwer; password = qwer";
            connectionString = connectionString = "Data Source = JR\\SEQUEL2022X; Initial Catalog = POSDB; user id = qwer; password = qwer";
            sql_connection = new SqlConnection(connectionString);
            sql_connection.ConnectionString = connectionString;
            sql_connection.Open();
        }
        public void cmd()//public function codes that support the mssql query
        {
            sql_command = new SqlCommand(sql, sql_connection);
            sql_command.CommandType = CommandType.Text;
        }
        public void sqladapterSelect()//public function codes in mediating the language or world of C# and MSSQL SELECT command
        {
            sql_dataadapter = new SqlDataAdapter();
            sql_dataadapter.SelectCommand = sql_command;
            sql_command.ExecuteNonQuery();
        }
        public void sqladapterInsert()//public function codes in mediating the languag or world of C# and MSSQL INSERT command
        {
            sql_dataadapter = new SqlDataAdapter();
            sql_dataadapter.InsertCommand = sql_command;
            sql_command.ExecuteNonQuery();
        }
        public void sqladapterDelete()//public function codes in mediating the language or world of C# and MSSQL DELETE command
        {
            sql_dataadapter = new SqlDataAdapter();
            sql_dataadapter.DeleteCommand = sql_command;
            sql_command.ExecuteNonQuery();
        }
        public void sqladapterUpdate()//public function codes in mediating the language or world of C# and MSSQL UPDATE command
        {
            sql_dataadapter = new SqlDataAdapter();
            sql_dataadapter.UpdateCommand = sql_command;
            sql_command.ExecuteNonQuery();
        }
        public void sqldatasetSELECT()//codes for mirroring the contents of the database inside the MSSQL going to C# or Visual Studio
        {
            sql_dataset = new DataSet();
            sql_dataadapter.Fill(sql_dataset, "studentTbl");
        }
    }

}
