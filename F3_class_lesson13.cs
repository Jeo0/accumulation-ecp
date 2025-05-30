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
using static System.ComponentModel.Design.ObjectSelectorEditor;
using Microsoft.VisualBasic.Devices;
using System.Collections;

namespace projectNamin
{
    public partial class F3_class_lesson13 : Form
    {
        String picpath;//a string variable use to hold the location of the image inside the table
        db_connection db_connect = new db_connection();
        public F3_class_lesson13()
        {
            db_connect.connString();

            InitializeComponent();
        }


        private void cleartextboxes()
        { //function for clearing all textboxes
            picturepathTxtBox.Clear();
            studentNumTxtBox.Clear();
            studentNameTxtBox.Clear();
            departmentTxtBox.Clear();
            //code for assigning the cursor to be inside the student number textbox
            studentNumTxtBox.Focus();
            //code for setting an image inside the picturebox
            pictureBox.Image = System.Drawing.Image.FromFile("C:\\Users\\Jude\\OneDrive - Lyceum of the Philippines University" +
                "\\Documents\\MIDTERMS_ECP_ERALDO_GUARINO\\accumulation-ecp-main-updated\\images\\Default.jpg");
        }
        private void F3_class_lesson13_Load(object sender, EventArgs e)
        {
            picturepathTxtBox.Hide();//code to hide the textbox
                                     //codes that access the class db_connection.cs that support the query needed
            db_connect.sql = "SELECT * FROM studentTbl";
            db_connect.cmd();
            //code that access the class db_connection to support the sql dataadapter needed for the sql query
            
             db_connect.sqladapterSelect();
            //code that access the class db_connection to mirror the database from SQL Server to Visual Studio
            
             db_connect.sqldatasetSELECT();
            //code used to display the query results inside the DataGridView as name as griddisplay

            dataGridView.DataSource = db_connect.sql_dataset.Tables[0];
            //connection.Close();//code for closing the C# form connection to the database

        }


        private void saveBtn_Click(object sender, EventArgs e)
        {
            db_connect.sql = "INSERT INTO studentTbl (student_id, student_name, department, picpath) VALUES('" + studentNumTxtBox.Text + "', '" + studentNameTxtBox.Text + "', '" + departmentTxtBox.Text + "', '" + picturepathTxtBox.Text + "')";
            db_connect.cmd();
            db_connect.sqladapterInsert();
            db_connect.sql = "SELECT * FROM studentTbl";
            db_connect.cmd();
            db_connect.sqladapterSelect();
            db_connect.sqldatasetSELECT();
            dataGridView.DataSource = db_connect.sql_dataset.Tables[0];
            cleartextboxes();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            db_connect.sql = "SELECT * FROM studentTbl WHERE student_id = '" + studentNumTxtBox.Text + "'";
            db_connect.cmd();
            db_connect.sqladapterSelect();
            db_connect.sqldatasetSELECT();
            dataGridView.DataSource = db_connect.sql_dataset.Tables[0];
            studentNameTxtBox.Text =
            db_connect.sql_dataset.Tables[0].Rows[0][1].ToString();
            departmentTxtBox.Text =
            db_connect.sql_dataset.Tables[0].Rows[0][2].ToString();
            picturepathTxtBox.Text =
            db_connect.sql_dataset.Tables[0].Rows[0][3].ToString();
            pictureBox.Image = System.Drawing.Image.FromFile(picturepathTxtBox.Text);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            db_connect.sql = "DELETE FROM studentTbl WHERE student_id = '" +
 studentNumTxtBox.Text + "'";
            db_connect.cmd();
            db_connect.sqladapterDelete();
            db_connect.sql = "SELECT * FROM studentTbl";
            db_connect.cmd();
            db_connect.sqladapterSelect();
            db_connect.sqldatasetSELECT();
            dataGridView.DataSource = db_connect.sql_dataset.Tables[0];
            cleartextboxes();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            db_connect.sql = "UPDATE studentTBL SET student_name = '" + studentNameTxtBox.Text + "', department = '" + departmentTxtBox.Text + "', picpath = '" + picturepathTxtBox.Text + "' WHERE student_id = '" + studentNumTxtBox.Text + "'";
            db_connect.cmd();
            db_connect.sqladapterUpdate();
            db_connect.sql = "SELECT * FROM studentTbl";
            db_connect.cmd();
            db_connect.sqladapterSelect();
            db_connect.sqldatasetSELECT();
            dataGridView.DataSource = db_connect.sql_dataset.Tables[0];
            cleartextboxes();

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            pictureBox.Image = System.Drawing.Image.FromFile("C:\\Users\\Jude\\OneDrive - Lyceum of the Philippines University" +
                "\\Documents\\MIDTERMS_ECP_ERALDO_GUARINO\\accumulation-ecp-main-updated\\images\\Default.jpg");
            studentNumTxtBox.Clear();
            studentNameTxtBox.Clear();
            departmentTxtBox.Clear();
            picturepathTxtBox.Clear();
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            pictureBox.Image = System.Drawing.Image.FromFile("C:\\Users\\Jude\\OneDrive - Lyceum of the Philippines University" +
                "\\Documents\\MIDTERMS_ECP_ERALDO_GUARINO\\accumulation-ecp-main-updated\\images\\Default.jpg");
            studentNumTxtBox.Clear();
            studentNameTxtBox.Clear();
            departmentTxtBox.Clear();
            picturepathTxtBox.Clear();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            //codes for inserting picture from the local file to the picturebox
            openFileDialog1.Filter = "Image File | *.gif; *.jpg; *.png; *.bmp";
            //filtering of image display using specific file extension
            openFileDialog1.ShowDialog();//displaying the file dialogbox where the posible image located
            pictureBox.Image = System.Drawing.Image.FromFile(openFileDialog1.FileName);//inserting of selected image to the picturebox shwon in the GUI interface
            picpath = openFileDialog1.FileName;//storing the file location of the selected image inserted in picturebox to a variable
            picturepathTxtBox.Text = picpath;//displaying the file location of the image stored in a variable to the textbox

        }
}
}
