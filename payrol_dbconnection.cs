using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectNamin
{
    class payrol_dbconnection
    {
        //declaration of variables for database connections and queries to access from one form to another
        public String payrol_connectionString = null;
        public SqlConnection payrol_sql_connection;
        public SqlCommand payrol_sql_command;
        public DataSet payrol_sql_dataset;
        public SqlDataAdapter payrol_sql_dataadapter;
        public string payrol_sql = null;
        public void payrol_connString()
        {
            //codes to establish connection from C# forms to the SQL Server database
            payrol_sql_connection = new SqlConnection();

            payrol_connectionString = "Data Source = JR\\SEQUEL2022X; Initial Catalog = POSDB; user id = qwer; password = qwer";
            //payrol_connectionString = "Data Source = JUDEE\\SQLEXPRESS; Initial Catalog = POSDB; user id = qwer; password = qwer";

            payrol_sql_connection = new SqlConnection(payrol_connectionString);
            payrol_sql_connection.ConnectionString = payrol_connectionString;
            payrol_sql_connection.Open();
        }
        public void payrol_cmd()//public function codes that support the mssql query
        {
            payrol_sql_command = new SqlCommand(payrol_sql, payrol_sql_connection);
            payrol_sql_command.CommandType = CommandType.Text;
        }
        public void payrol_sqladapterSelect()//public function codes for mediating between C# language and the MSSQL SELECT command
        {
            payrol_sql_dataadapter = new SqlDataAdapter();
            payrol_sql_dataadapter.SelectCommand = payrol_sql_command;
            payrol_sql_command.ExecuteNonQuery();
        }
        public void payrol_sqladapterInsert()//public function codes for mediating between C# language and the MSSQL INSERT command
        {
            payrol_sql_dataadapter = new SqlDataAdapter();
            payrol_sql_dataadapter.InsertCommand = payrol_sql_command;
            payrol_sql_command.ExecuteNonQuery();
        }
        public void payrol_sqladapterDelete()//public function codes for mediating between C# language and the MSSQL DELETE command
        {
            payrol_sql_dataadapter = new SqlDataAdapter();
            payrol_sql_dataadapter.DeleteCommand = payrol_sql_command;
            payrol_sql_command.ExecuteNonQuery();
        }
        public void payrol_sqladapterUpdate()//public function codes for mediating between C# language and the MSSQL UPDATE command
        {
            payrol_sql_dataadapter = new SqlDataAdapter();
            payrol_sql_dataadapter.UpdateCommand = payrol_sql_command;
            payrol_sql_command.ExecuteNonQuery();
        }
        public void payrol_sqldatasetSELECT()//codes for mirroring the contents of the database inside the MSSQL going to C# or Visual Studio
        {
            payrol_sql_dataset = new DataSet();
            payrol_sql_dataadapter.Fill(payrol_sql_dataset, "pos_empRegTbl");
        }


    }
}
