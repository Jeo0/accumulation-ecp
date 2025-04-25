using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Net.Mime.MediaTypeNames;

namespace projectNamin
{
    public partial class Flesson13 : Form
    {
        String picpath;//a string variable use to hold the location of the image inside the table
        String connectionString = null;//a string variable with initial value which use to hold the SQL Connection Object
        SqlConnection connection;//a variable use to hold the SQL Connection Object
        SqlCommand command;//a variable use to hold the SQL Command or query
        DataSet dset; // a variable use to hold the mirror copy of the database contents reside inside the.NET Framework
        SqlDataAdapter adaptersql;//a variable use to hold the SQL DATA ADAPTER object
        string sql = null;
        public Flesson13()
        {
            // codes in creating and establishing SQL Connection Object
            connectionString = "Data Source = JUDEE\\SQLEXPRESS; Initial Catalog = SampleDatabaseDB; user id = qwer; password = qwer";
            connection = new SqlConnection(connectionString);

            InitializeComponent();
        }


        private void Flesson13_Load(object sender, EventArgs e)
        {
        }
        
        
        private void saveBtn_Click(object sender, EventArgs e)
        {
            //code to open the connection between c# and ms sql
            connection.Open();

            //mssql query to insert or save data from GUI interface to the student table located inside the database
            sql = "INSERT INTO studentTbl (student_id, student_name, department, picpath) VALUES ('" + studentNumTxtBox.Text + "', '" + studentNameTxtBox.Text + "', '" + departmentTxtBox.Text + "', '" + picturepathTxtBox.Text + "') ";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;
            //codes for mediating the language or world of C# and MSSQL
            adaptersql = new SqlDataAdapter();
            adaptersql.InsertCommand = command;
            command.ExecuteNonQuery();

            //mssql query to display the contents of student table located inside the database
            sql = "SELECT * FROM studentTbl ";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            //codes for mediating the language or world of C# and MSSQL
            adaptersql = new SqlDataAdapter();
            adaptersql.SelectCommand = command;
            command.ExecuteNonQuery();

            //codes for mirroring the contents of the database inside the MSSQL going to C# or Visual Studio
            dset = new DataSet();
            adaptersql.Fill(dset, "studentTbl");

            //codes for displaying the contents of student table to the inside of data grid view
            dataGridView.DataSource = dset.Tables[0];

            //clearing of text boxes after saving the data to the database
            
            pictureBox.Image = System.Drawing.Image.FromFile("C:\\Users\\Jude\\OneDrive - Lyceum of the Philippines University\\Documents\\MIDTERMS_ECP_ERALDO_GUARINO\\accumulation-ecp-main-updated\\images\\images-lesson3(POS 2)\\fb2.jfif");
            studentNumTxtBox.Clear();
            studentNameTxtBox.Clear();
            departmentTxtBox.Clear();
            picturepathTxtBox.Clear();
            //codes for closing the connection between the database inside MSSQL to Visual Studio
            connection.Close();
        }
    }
}
