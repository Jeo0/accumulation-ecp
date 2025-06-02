using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace projectNamin
{
    internal class loginDB_connections
    {
        //declaration of variables for database connections and query which to access from one form to another
        public String login_connectionString = null;
        public SqlConnection login_sql_connection;
        public SqlCommand login_sql_command;
        public DataSet login_sql_dataset;
        public SqlDataAdapter login_sql_dataadapter;
        public string login_sql = null;





        public void login_connString()
        {
            //codes to establish a connection from C# forms to the SQL Server database
            login_sql_connection = new SqlConnection();
            //login_connectionString = "Data Source = JUDEE\\SQLEXPRESS; Initial Catalog = POSDB; user id = qwer; password = qwer";
            login_connectionString = "Data Source = JR\\SEQUEL2022X; Initial Catalog = POSDB; user id = qwer; password = qwer";
            login_sql_connection = new SqlConnection(login_connectionString);
            login_sql_connection.ConnectionString = login_connectionString;
            login_sql_connection.Open();
        }
        public void login_cmd()//public function codes that support the mssql query
        {
            login_sql_command = new SqlCommand(login_sql, login_sql_connection);
            login_sql_command.CommandType = CommandType.Text;
        }
        public void login_sqladapterSelect()//public function codes for mediating between C# language and the MSSQL SELECT command
        {
            login_sql_dataadapter = new SqlDataAdapter();
            login_sql_dataadapter.SelectCommand = login_sql_command;
            login_sql_command.ExecuteNonQuery();
        }
        public void login_sqladapterInsert()//public function codes for mediating between C# language and the MSSQL INSERT command
        {
            login_sql_dataadapter = new SqlDataAdapter();
            login_sql_dataadapter.InsertCommand = login_sql_command;
            login_sql_command.ExecuteNonQuery();
        }
        public void login_sqladapterDelete()//public function codes for mediating between C# language and the MSSQL DELETE command
        {
            login_sql_dataadapter = new SqlDataAdapter();
            login_sql_dataadapter.DeleteCommand = login_sql_command;
            login_sql_command.ExecuteNonQuery();
        }
        public void login_sqladapterUpdate()//public function codes for mediating between C# language and the MSSQL UPDATE command
        {
            login_sql_dataadapter = new SqlDataAdapter();
            login_sql_dataadapter.UpdateCommand = login_sql_command;
            login_sql_command.ExecuteNonQuery();
        }
        public void login_sqldatasetSELECT()//codes for mirroring the contents of the database inside the MSSQL going to C# or Visual Studio
        {
            login_sql_dataset = new DataSet();
            login_sql_dataadapter.Fill(login_sql_dataset, "pos_empRegTbl");
        }
    }
}

