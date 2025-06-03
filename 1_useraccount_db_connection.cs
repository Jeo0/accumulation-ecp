using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic;

namespace projectNamin
{
    internal class useraccount_db_connection
    {
        public String useraccount_connectionString = null;
        public SqlConnection useraccount_sql_connection;
        public SqlCommand useraccount_sql_command;
        public DataSet useraccount_sql_dataset;
        public SqlDataAdapter useraccount_sql_dataadapter;
        public string useraccount_sql = null;

        public void useraccount_connString()
        {
            //codes to establish connection from C# forms to the SQL Server database
            useraccount_sql_connection = new SqlConnection();
            useraccount_connectionString = "Data Source = JUDEE\\SQLEXPRESS; Initial Catalog = POSDB; user id = qwer; password = qwer";
            //useraccount_connectionString = "Data Source = JR\\SEQUEL2022X; Initial Catalog = POSDB; user id = qwer; password = qwer";
            useraccount_sql_connection.ConnectionString = useraccount_connectionString;
            useraccount_sql_connection.Open();
        }
        public void useraccount_cmd()//public function codes that support the mssql query
        {
            useraccount_sql_command = new SqlCommand(useraccount_sql, useraccount_sql_connection);
            useraccount_sql_command.CommandType = CommandType.Text;
        }
        public void useraccount_sqladapterSelect()//public function codes for mediating between C# language and the MSSQL SELECT command
         {
            useraccount_sql_dataadapter = new SqlDataAdapter();
            useraccount_sql_dataadapter.SelectCommand = useraccount_sql_command;
            useraccount_sql_command.ExecuteNonQuery();
         }
         public void useraccount_sqladapterInsert()//public function codes for mediating between C# language and the MSSQL INSERT command
         {
            useraccount_sql_dataadapter = new SqlDataAdapter();
            useraccount_sql_dataadapter.InsertCommand = useraccount_sql_command;
            useraccount_sql_command.ExecuteNonQuery();
         }
        public void useraccount_sqladapterDelete()//public function codes for mediating between C# language and the MSSQL DELETE command
         {
            useraccount_sql_dataadapter = new SqlDataAdapter();
            useraccount_sql_dataadapter.DeleteCommand = useraccount_sql_command;
            useraccount_sql_command.ExecuteNonQuery();
         }
         public void useraccount_sqladapterUpdate()//public function codes for mediating between C# language and the MSSQL UPDATE command
         {
            useraccount_sql_dataadapter = new SqlDataAdapter();
            useraccount_sql_dataadapter.UpdateCommand = useraccount_sql_command;
            useraccount_sql_command.ExecuteNonQuery();
         }
         public void useraccount_sqldatasetSELECT()//codes for mirroring the contents of the database inside MSSQL to C# or Visual Studio
         {
            useraccount_sql_dataset = new DataSet();
            useraccount_sql_dataadapter.Fill(useraccount_sql_dataset, "pos_empRegTbl");
         }
         public void useraccount_sqldatasetSELECT_Account()//codes for mirroring the contents of the database inside the MSSQL going to C# or Visual Studio
         {
            useraccount_sql_dataset = new DataSet();
            useraccount_sql_dataadapter.Fill(useraccount_sql_dataset, "useraccountTbl");
         }

    }
}
