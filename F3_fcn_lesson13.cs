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
using ZXing.QrCode.Internal;

namespace projectNamin
{
    public partial class F3_fcn_lesson13 : Form
    {
        String picpath;//a string variable use to hold the location of the image inside the table
        String connectionString = null;//a string variable with initial value which use to hold the SQL Connection Object
        SqlConnection connection;//a variable use to hold the SQL Connection Object
        SqlCommand command;//a variable use to hold the SQL Command or query
        DataSet dset; // a variable use to hold the mirror copy of the database contents reside inside the.NET Framework
        SqlDataAdapter adaptersql;//a variable use to hold the SQL DATA ADAPTER object
        string sql = null;
        public F3_fcn_lesson13()
        {
            // codes in creating and establishing SQL Connection Object
            connectionString = "Data Source = JUDEE\\SQLEXPRESS; Initial Catalog = SampleDatabaseDB; user id = qwer; password = qwer";
            connection = new SqlConnection(connectionString);

            InitializeComponent(); // This MUST be here


        }



        //Function for codes in clearing the four textboxes available in the interface
        private void clrtextboxes()
        {
            picturepathTxtBox.Clear();
            studentNameTxtBox.Clear();
            studentNumTxtBox.Clear();
            departmentTxtBox.Clear();
        }
        //Function for codes in SQLCommand 
        private void cmd()
        {
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;
        }
        //Function for codes in SQL query in retrieving data to the database 
        private void sqlSelect()
        {
            sql = "SELECT * FROM studentTbl";
        }
        //Function for codes in SQLDataAdapter SELECT sql command 
        private void sqladapterSelect()
        {
            adaptersql = new SqlDataAdapter();
            adaptersql.SelectCommand = command;
            command.ExecuteNonQuery();
        }
        //Function for codes in SQLDataAdapter DELETE sql command 
        private void sqladapterDelete()
        {
            adaptersql = new SqlDataAdapter();
            adaptersql.DeleteCommand = command;
            command.ExecuteNonQuery();
        }
        //Function for codes in SQLDataAdapter UPDATE sql command 
        private void sqladapterUpdate()
        {
            adaptersql = new SqlDataAdapter();
            adaptersql.UpdateCommand = command;
            command.ExecuteNonQuery();
        }
        //Function for codes in SQLDataAdapter INSERT sql command 
        private void sqladapterInsert()
        {
            adaptersql = new SqlDataAdapter();
            adaptersql.InsertCommand = command;
            command.ExecuteNonQuery();
        }
        //Function for codes in SQL DataSet 
        private void sqldataset()
        {
            dset = new DataSet();
            adaptersql.Fill(dset, "studentTbl");
            dataGridView.DataSource = dset.Tables[0];
        }
        private void cancelNew()
        {
            //codes for clearing the textboxes and picturebox
            studentNumTxtBox.Clear();
            studentNameTxtBox.Clear();
            departmentTxtBox.Clear();
            picturepathTxtBox.Clear();
            pictureBox.Image = System.Drawing.Image.FromFile("C:\\Users\\Jude\\OneDrive - Lyceum of the Philippines University" +
                "\\Documents\\MIDTERMS_ECP_ERALDO_GUARINO\\accumulation-ecp-main-updated\\images\\Default.jpg");
        }
        private void Flesson13_Load(object sender, EventArgs e)
        {
            picturepathTxtBox.Hide();//code in hiding the picturepathTxtBox 
            connection.Open();//code to open the connection between c# and ms sql 
            sqlSelect();//code that call the function in SQLCommand that will retrieved the data from the database and display it inside the DataGridView
            cmd();//codes that call the function in SQL command  
            sqladapterSelect();//code to call the SQLDataAdapter for SELECT SQL command 
            sqldataset();//code to call the SQLDataSet. This is applicable since the data retrieved will display at the DataGridView
            connection.Close();//code for closing the C# form connection to the database
        }


        private void pictureBox_Click(object sender, EventArgs e)
        {
            //codes for inserting picture from the local file to the picturebox 
            openFileDialog1.Filter = "Image File | *.gif; *.jpg; *.png; *.bmp";
            //filtering of image display using specific file extension 
            openFileDialog1.ShowDialog();//displaying the file dialogbox where the posible image located
            pictureBox.Image = System.Drawing.Image.FromFile(openFileDialog1.FileName);//inserting of  selected image to the picturebox shwon in the GUI interface
            picpath = openFileDialog1.FileName;//storing the file location of the  selected image inserted in picturebox to a variable
            picturepathTxtBox.Text = picpath;//displaying the file location of the image stored in a variable to the textbox
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {


            int studentId;
            if (!int.TryParse(studentNumTxtBox.Text.Trim(), out studentId) || studentId <= 0)
            {
                MessageBox.Show("Please enter a valid, non-zero Student Number.");
                return;
            }

            connection.Open();

            // Check for duplicates
            sql = "SELECT COUNT(*) FROM studentTbl WHERE student_id = '" + studentId + "'";
            command = new SqlCommand(sql, connection);
            int count = (int)command.ExecuteScalar();

            if (count > 0)
            {
                MessageBox.Show("This Student ID already exists. Please enter a different one.");
                connection.Close();
                return;
            }

            // Insert data
            sql = "INSERT INTO studentTbl (student_id, student_name, department, picpath) VALUES('"
                + studentId + "', '"
                + studentNameTxtBox.Text + "','"
                + departmentTxtBox.Text + "','"
                + picturepathTxtBox.Text + "')";

            cmd();
            sqladapterInsert();
            sqlSelect();
            cmd();
            sqladapterSelect();
            sqldataset();

            connection.Close();

            clrtextboxes();
            pictureBox.Image = System.Drawing.Image.FromFile("C:\\Users\\Jude\\OneDrive - Lyceum of the Philippines University" +
                "\\Documents\\MIDTERMS_ECP_ERALDO_GUARINO\\accumulation-ecp-main-updated\\images\\Default.jpg");
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            sql = "SELECT * FROM studentTbl WHERE student_id = '" + studentNumTxtBox.Text
            + "' ";
            cmd();
            sqladapterSelect();
            sqldataset();
            //codes for displaying the contents of the student table to the textboxes 
            studentNameTxtBox.Text = dset.Tables[0].Rows[0][1].ToString();
            departmentTxtBox.Text = dset.Tables[0].Rows[0][2].ToString();
            picturepathTxtBox.Text = dset.Tables[0].Rows[0][3].ToString();
            pictureBox.Image = System.Drawing.Image.FromFile(picturepathTxtBox.Text);//displaying the save image using the file location to the picturebox

            //codes for closing the connection between the database inside MSSQL to Visual Studio
            connection.Close();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            sql = "DELETE  FROM studentTBL WHERE student_id = '" + studentNumTxtBox.Text + "' ";
            cmd();
            sqladapterDelete();
            sqlSelect();
            cmd();
            sqladapterSelect();
            sqldataset();
            connection.Close();
            clrtextboxes();
            pictureBox.Image = System.Drawing.Image.FromFile("C:\\Users\\Jude\\OneDrive - Lyceum of the Philippines University" +
                "\\Documents\\MIDTERMS_ECP_ERALDO_GUARINO\\accumulation-ecp-main-updated\\images\\Default.jpg");
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            sql = "UPDATE studentTbl SET student_name = '" + studentNameTxtBox.Text +
                    "', department = '" + departmentTxtBox.Text + "', picpath = '" +
                    picturepathTxtBox.Text + "' WHERE student_id = '" +
                    studentNumTxtBox.Text + "'";
            cmd();
            sqladapterUpdate();
            sqlSelect();
            cmd();
            sqladapterSelect();
            sqldataset();
            connection.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            cancelNew();
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            cancelNew();
        }
    }
}

