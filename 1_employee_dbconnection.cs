using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectNamin
{
    internal class employee_dbconnection
    {
        //declaration of variables for database connections and queries to acces from one form to another
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
            employee_connectionString = "Data Source = JUDEE\\SQLEXPRESS; Initial Catalog = POSDB; user id = qwer; password = qwer";
            //employee_connectionString = "Data Source = JR\\SEQUEL2022X; Initial Catalog = POSDB; user id = qwer; password = qwer";
            employee_sql_connection = new SqlConnection(employee_connectionString);
            employee_sql_connection.ConnectionString = employee_connectionString;
            employee_sql_connection.Open();
        }
        public void employee_cmd() // Prepares the SQL command
        {
            employee_sql_command = new SqlCommand(employee_sql, employee_sql_connection);
            employee_sql_command.CommandType = CommandType.Text;
        }

        public void employee_sqladapterSelect() // Executes SELECT query
        {
            employee_sql_connection.Open(); // Open connection before executing
            employee_sql_dataadapter = new SqlDataAdapter();
            employee_sql_dataadapter.SelectCommand = employee_sql_command;
            employee_sql_command.ExecuteNonQuery(); // Not always needed for SELECT, but keeping your format
            employee_sql_connection.Close(); // Close connection after executing
        }

        public void employee_sqladapterInsert() // Executes INSERT query
        {
            employee_sql_connection.Open();
            employee_sql_dataadapter = new SqlDataAdapter();
            employee_sql_dataadapter.InsertCommand = employee_sql_command;
            employee_sql_command.ExecuteNonQuery();
            employee_sql_connection.Close();
        }

        public void employee_sqladapterDelete() // Executes DELETE query
        {
            employee_sql_connection.Open();
            employee_sql_dataadapter = new SqlDataAdapter();
            employee_sql_dataadapter.DeleteCommand = employee_sql_command;
            employee_sql_command.ExecuteNonQuery();
            employee_sql_connection.Close();
        }

        public void employee_sqladapterUpdate() // Executes UPDATE query
        {
            employee_sql_connection.Open();
            employee_sql_dataadapter = new SqlDataAdapter();
            employee_sql_dataadapter.UpdateCommand = employee_sql_command;
            employee_sql_command.ExecuteNonQuery();
            employee_sql_connection.Close();
        }

        public void employee_sqldatasetSELECT() // Fills dataset with SELECT results
        {
            employee_sql_connection.Open();
            employee_sql_dataset = new DataSet();
            employee_sql_dataadapter.Fill(employee_sql_dataset, "pos_empRegTbl");
            employee_sql_connection.Close();
        }


    }
}
