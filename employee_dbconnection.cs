using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Microsoft.VisualBasic.ApplicationServices;
using System.Windows.Forms;

namespace projectNamin
{
    class employee_dbconnection
    {
        //declaration of variables for database connections and queries to access from one form to another
        public String employee_connectionString = null;
        public SqlConnection employee_sql_connection;
        public SqlCommand employee_sql_command;
        public DataSet employee_sql_dataset;
        public SqlDataAdapter employee_sql_dataadapter;
        public string employee_sql = null;
        public void employee_connString()
        {
            //codes to establish a connection from C# forms to the SQL Server database
            employee_sql_connection = new SqlConnection();

            //employee_connectionString = "Data Source = JR\\SEQUEL2022X; Initial Catalog = POSDB; user id = qwer; password = qwer";
            employee_connectionString = "Data Source = JUDEE\\SQLEXPRESS; Initial Catalog = POSDB; user id = qwer; password = qwer";

            employee_sql_connection = new SqlConnection(employee_connectionString);
            employee_sql_connection.ConnectionString = employee_connectionString;
            employee_sql_connection.Open();
        }
        public void employee_cmd()//public function code that supports the MS SQL query
        {
            employee_sql_command = new SqlCommand(employee_sql, employee_sql_connection);
            employee_sql_command.CommandType = CommandType.Text;
        }

        public void employee_sqladapterSelect()//public function codes for mediating between C# language and the MSSQL SELECT command
        {
            employee_sql_dataadapter = new SqlDataAdapter();
            employee_sql_dataadapter.SelectCommand = employee_sql_command;
            // Make sure the connection is open
            if (employee_sql_command.Connection.State == ConnectionState.Closed)
            {
                employee_sql_command.Connection.Open();
            }

            employee_sql_command.ExecuteNonQuery();
        }
        public void employee_sqladapterInsert()//public function codes for mediating between C# language and the MSSQL INSERT command
        {
            employee_sql_dataadapter = new SqlDataAdapter();
            employee_sql_dataadapter.InsertCommand = employee_sql_command;

            // Make sure the connection is open
            if (employee_sql_command.Connection.State == ConnectionState.Closed)
            {
                employee_sql_command.Connection.Open();
            }

            employee_sql_command.ExecuteNonQuery();
        }
        public void employee_sqladapterDelete()//public function codes for mediating between C# language and the MSSQL DELETE command
        {
            employee_sql_dataadapter = new SqlDataAdapter();
            employee_sql_dataadapter.DeleteCommand = employee_sql_command;
            // Make sure the connection is open
            if (employee_sql_command.Connection.State == ConnectionState.Closed)
            {
                employee_sql_command.Connection.Open();
            }

            employee_sql_command.ExecuteNonQuery();
        }
        public void employee_sqladapterUpdate()//public function codes for mediating between C# language and the MSSQL UPDATE command
        {
            employee_sql_dataadapter = new SqlDataAdapter();
            employee_sql_dataadapter.UpdateCommand = employee_sql_command;
            // Make sure the connection is open
            if (employee_sql_command.Connection.State == ConnectionState.Closed)
            {
                employee_sql_command.Connection.Open();
            }

            employee_sql_command.ExecuteNonQuery();
        }
        public void employee_sqldatasetSELECT()//codes for mirroring the contents of the database inside the MSSQL going to C# or Visual Studio
        {
            employee_sql_dataset = new DataSet();
            employee_sql_dataadapter.Fill(employee_sql_dataset, "pos_empRegTbl");
        }
        
    }
}
