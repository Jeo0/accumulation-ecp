using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace projectNamin
{
    public partial class employee_registration : Form
    {
        string picpath;
        employee_dbconnection empdb_connect = new employee_dbconnection();
        public employee_registration()
        {
            empdb_connect.employee_connString();
            InitializeComponent();
        }

        private void cleartextboxes()
        {
            empnumtxtbox.Clear();
            fnametxtbox.Clear();
            mnametxtbox.Clear();
            snametxtbox.Clear();
            ssstxtbox.Clear();
            tintxtbox.Clear();
            philhealthtxtbox.Clear();
            pagibigtxtbox.Clear();
            weighttxtbox.Clear();
            heighttxtbox.Clear();
            yearstxtbox.Clear();
            housenumtxtbox.Clear();
            subditxtbox.Clear();
            phasenumtxtbox.Clear();
            streettxtbox.Clear();
            brgytxtbox.Clear();
            municipalitytxtbox.Clear();
            citytxtbox.Clear();
            countrytxtbox.Clear();
            statetxtbox.Clear();
            ziptxtbox.Clear();
            elemschooltxtbox.Clear();
            elem_addtxtbox.Clear();
            elem_awardtxtbox.Clear();
            jhstxtbox.Clear();
            jhs_addtxtbox.Clear();
            jhs_awardtxtbox.Clear();
            shstxtbox.Clear();
            shs_addtxtbox.Clear();
            shs_tracktxtbox.Clear();
            shs_awardtxtbox.Clear();
            collegetxtbox.Clear();
            col_addtxtbox.Clear();
            coursetxtbox.Clear();
            col_awardtxtbox.Clear();
            otherstxtbox.Clear();
            postxtbox.Clear();
            empstatustxtbox.Clear();
            depttxtbox.Clear();
            numofdeptxtbox.Clear();
            pictureBox1.Image = System.Drawing.Image.FromFile("C:\\Users\\Jude\\OneDrive - Lyceum of the Philippines " +
                "University\\Documents\\MIDTERMS_ECP_ERALDO_GUARINO\\accumulation-ecp-main-updated\\images\\default.jpg");
        }

        private void employee_registration_Load(object sender, EventArgs e)
        {
            picpathtxtbox.Hide();
            empdb_connect.employee_sql = "SELECT * FROM pos_empRegTbl";
            empdb_connect.employee_cmd();
            empdb_connect.employee_sqladapterSelect();
            empdb_connect.employee_sqldatasetSELECT();
            dataGridView1.DataSource = empdb_connect.employee_sql_dataset.Tables[0];
            empdb_connect.employee_sql_connection.Close();

            // Populate ageComboBox with values from 18 to 65
            for (int i = 18; i <= 65; i++)
            {
                agecombobox.Items.Add(i.ToString());
            }

            gendercombobox.Items.Add("Male");
            gendercombobox.Items.Add("Female");
            gendercombobox.Items.Add("Other");

            statuscombobox.Items.Add("Single");
            statuscombobox.Items.Add("Married");
            statuscombobox.Items.Add("Widowed");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image File | *.gif; *.jpg; *.png; *.jfif; *.bmp";
            openFileDialog1.ShowDialog();
            pictureBox1.Image = System.Drawing.Image.FromFile(openFileDialog1.FileName);
            picpath = openFileDialog1.FileName;
            picpathtxtbox.Text = picpath;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            empdb_connect.employee_sql = "INSERT INTO pos_empRegTbl (" +
            "emp_id, emp_fname, emp_mname, emp_surname, emp_age, emp_gender, emp_sss_no, emp_tin_no, emp_philhealth_no, emp_pagibig_no, emp_status, " +
            "emp_height, emp_weight, add_yrs_stay, add_house_no, add_sub_name, add_phase_no, add_street, add_barangay, add_municipality, add_city, " +
            "add_state_province, add_country, add_zipcode, elem_name, elem_address, elem_yr_grad, elem_award, junior_high_name, junior_high_address, " +
            "junior_high_yr_grad, junior_high_award, senior_high_name, senior_high_address, senior_high_yr_grad, senior_high_award, track, " +
            "college_school_name, college_address, college_yr_grad, college_award, college_course, others, position, emp_work_status, emp_date_hired, " +
            "emp_department, emp_no_of_dependents, picpath" +
            ") VALUES('" + empnumtxtbox.Text + "', '" + fnametxtbox.Text + "', '" + mnametxtbox.Text +
            "', '" + snametxtbox.Text + "', '" + agecombobox.Text + "', '" + gendercombobox.Text + "', " +
            "'" + ssstxtbox.Text + "', '" + tintxtbox.Text + "', '" + philhealthtxtbox.Text + "', '" +
            pagibigtxtbox.Text + "', '" + statuscombobox.Text + "', '" + heighttxtbox.Text + "', '" +
            weighttxtbox.Text + "', '" + yearstxtbox.Text + "', '" + housenumtxtbox.Text + "', '" + subditxtbox.Text +
            "', '" + phasenumtxtbox.Text + "', '" + streettxtbox.Text + "', '" + brgytxtbox.Text + "', '" +
            municipalitytxtbox.Text + "', '" + citytxtbox.Text + "', '" + statetxtbox.Text + "', '" +
            countrytxtbox.Text + "', '" + ziptxtbox.Text + "', '" + elemschooltxtbox.Text + "', '" +
            elem_addtxtbox.Text + "', '" + dateTimePicker1.Text + "', '" + elem_awardtxtbox.Text + "', '" +
            jhstxtbox.Text + "', '" + jhs_addtxtbox.Text + "', '" + dateTimePicker2.Text + "', '" +
            jhs_awardtxtbox.Text + "', '" + shstxtbox.Text + "', '" + shs_addtxtbox.Text + "', '" +
            dateTimePicker3.Text + "', '" + shs_awardtxtbox.Text + "', '" + shs_tracktxtbox.Text + "', '" +
            collegetxtbox.Text + "', '" + col_addtxtbox.Text + "', '" + dateTimePicker4.Text + "', '" +
            col_awardtxtbox.Text + "', '" + coursetxtbox.Text + "', '" + otherstxtbox.Text + "', '" + postxtbox.Text +
            "', '" + empstatustxtbox.Text + "', '" + dateTimePicker5.Text + "', '" + depttxtbox.Text + "', '" +
            numofdeptxtbox.Text + "', '" + picpathtxtbox.Text + "')";
            empdb_connect.employee_cmd();
            empdb_connect.employee_sqladapterInsert();
            empdb_connect.employee_sql = "SELECT * FROM pos_empRegTbl";
            empdb_connect.employee_cmd();
            empdb_connect.employee_sqladapterSelect();
            empdb_connect.employee_sqldatasetSELECT();
            dataGridView1.DataSource = empdb_connect.employee_sql_dataset.Tables[0];
            cleartextboxes();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            empdb_connect.employee_sql = "SELECT * FROM pos_empRegTbl WHERE emp_id = '" + empnumtxtbox.Text + "'";
            empdb_connect.employee_cmd();
            empdb_connect.employee_sqladapterSelect();
            empdb_connect.employee_sqldatasetSELECT();
            dataGridView1.DataSource = empdb_connect.employee_sql_dataset.Tables[0];
            // Assign values to each control based on the dataset
            fnametxtbox.Text = empdb_connect.employee_sql_dataset.Tables[0].Rows[0][2].ToString();
            mnametxtbox.Text = empdb_connect.employee_sql_dataset.Tables[0].Rows[0][3].ToString();
            snametxtbox.Text = empdb_connect.employee_sql_dataset.Tables[0].Rows[0][4].ToString();
            agecombobox.Text = empdb_connect.employee_sql_dataset.Tables[0].Rows[0][5].ToString();
            gendercombobox.Text = empdb_connect.employee_sql_dataset.Tables[0].Rows[0][6].ToString();
            ssstxtbox.Text = empdb_connect.employee_sql_dataset.Tables[0].Rows[0][7].ToString();
            tintxtbox.Text = empdb_connect.employee_sql_dataset.Tables[0].Rows[0][8].ToString();
            philhealthtxtbox.Text = empdb_connect.employee_sql_dataset.Tables[0].Rows[0][9].ToString();
            pagibigtxtbox.Text = empdb_connect.employee_sql_dataset.Tables[0].Rows[0][10].ToString();
            statuscombobox.Text = empdb_connect.employee_sql_dataset.Tables[0].Rows[0][11].ToString();
            heighttxtbox.Text = empdb_connect.employee_sql_dataset.Tables[0].Rows[0][12].ToString();
            weighttxtbox.Text = empdb_connect.employee_sql_dataset.Tables[0].Rows[0][13].ToString();
            yearstxtbox.Text = empdb_connect.employee_sql_dataset.Tables[0].Rows[0][14].ToString();
            housenumtxtbox.Text = empdb_connect.employee_sql_dataset.Tables[0].Rows[0][15].ToString();
            subditxtbox.Text = empdb_connect.employee_sql_dataset.Tables[0].Rows[0][16].ToString();
            phasenumtxtbox.Text = empdb_connect.employee_sql_dataset.Tables[0].Rows[0][17].ToString();
            streettxtbox.Text = empdb_connect.employee_sql_dataset.Tables[0].Rows[0][18].ToString();
            brgytxtbox.Text = empdb_connect.employee_sql_dataset.Tables[0].Rows[0][19].ToString();
            municipalitytxtbox.Text = empdb_connect.employee_sql_dataset.Tables[0].Rows[0][20].ToString();
            citytxtbox.Text = empdb_connect.employee_sql_dataset.Tables[0].Rows[0][21].ToString();
            statetxtbox.Text = empdb_connect.employee_sql_dataset.Tables[0].Rows[0][22].ToString();
            countrytxtbox.Text = empdb_connect.employee_sql_dataset.Tables[0].Rows[0][23].ToString();
            ziptxtbox.Text = empdb_connect.employee_sql_dataset.Tables[0].Rows[0][24].ToString();
            elemschooltxtbox.Text = empdb_connect.employee_sql_dataset.Tables[0].Rows[0][25].ToString();
            elem_addtxtbox.Text = empdb_connect.employee_sql_dataset.Tables[0].Rows[0][26].ToString();
            dateTimePicker1.Text = empdb_connect.employee_sql_dataset.Tables[0].Rows[0][27].ToString();
            elem_awardtxtbox.Text = empdb_connect.employee_sql_dataset.Tables[0].Rows[0][28].ToString();
            jhstxtbox.Text = empdb_connect.employee_sql_dataset.Tables[0].Rows[0][29].ToString();
            jhs_addtxtbox.Text = empdb_connect.employee_sql_dataset.Tables[0].Rows[0][30].ToString();
            dateTimePicker2.Text = empdb_connect.employee_sql_dataset.Tables[0].Rows[0][31].ToString();
            jhs_awardtxtbox.Text = empdb_connect.employee_sql_dataset.Tables[0].Rows[0][32].ToString();
            shstxtbox.Text = empdb_connect.employee_sql_dataset.Tables[0].Rows[0][33].ToString();
            shs_addtxtbox.Text = empdb_connect.employee_sql_dataset.Tables[0].Rows[0][34].ToString();
            dateTimePicker3.Text = empdb_connect.employee_sql_dataset.Tables[0].Rows[0][35].ToString();
            shs_awardtxtbox.Text = empdb_connect.employee_sql_dataset.Tables[0].Rows[0][36].ToString();
            shs_tracktxtbox.Text = empdb_connect.employee_sql_dataset.Tables[0].Rows[0][37].ToString();
            collegetxtbox.Text = empdb_connect.employee_sql_dataset.Tables[0].Rows[0][38].ToString();
            col_addtxtbox.Text = empdb_connect.employee_sql_dataset.Tables[0].Rows[0][39].ToString();
            dateTimePicker4.Text = empdb_connect.employee_sql_dataset.Tables[0].Rows[0][40].ToString();
            col_awardtxtbox.Text = empdb_connect.employee_sql_dataset.Tables[0].Rows[0][41].ToString();
            coursetxtbox.Text = empdb_connect.employee_sql_dataset.Tables[0].Rows[0][42].ToString();
            otherstxtbox.Text = empdb_connect.employee_sql_dataset.Tables[0].Rows[0][43].ToString();
            postxtbox.Text = empdb_connect.employee_sql_dataset.Tables[0].Rows[0][44].ToString();
            empstatustxtbox.Text = empdb_connect.employee_sql_dataset.Tables[0].Rows[0][45].ToString();
            dateTimePicker5.Text = empdb_connect.employee_sql_dataset.Tables[0].Rows[0][46].ToString();
            depttxtbox.Text = empdb_connect.employee_sql_dataset.Tables[0].Rows[0][47].ToString();
            numofdeptxtbox.Text = empdb_connect.employee_sql_dataset.Tables[0].Rows[0][48].ToString();
            picpathtxtbox.Text = empdb_connect.employee_sql_dataset.Tables[0].Rows[0][49].ToString();
            pictureBox1.Image = System.Drawing.Image.FromFile(picpathtxtbox.Text);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            empdb_connect.employee_sql = "DELETE FROM pos_empRegTbl WHERE emp_id = '" + empnumtxtbox.Text + "'";
            empdb_connect.employee_cmd();
            empdb_connect.employee_sqladapterDelete();
            empdb_connect.employee_sql = "SELECT * FROM pos_empRegTbl";
            empdb_connect.employee_cmd();
            empdb_connect.employee_sqladapterSelect();
            empdb_connect.employee_sqldatasetSELECT();
            dataGridView1.DataSource = empdb_connect.employee_sql_dataset.Tables[0];
            cleartextboxes();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            empdb_connect.employee_sql = "UPDATE pos_empRegTbl SET " +
            "emp_fname = '" + fnametxtbox.Text + "', " +
            "emp_mname = '" + mnametxtbox.Text + "', " +
            "emp_surname = '" + snametxtbox.Text + "', " +
            "emp_age = '" + agecombobox.Text + "', " +
            "emp_gender = '" + gendercombobox.Text + "', " +
            "emp_sss_no = '" + ssstxtbox.Text + "', " +
            "emp_tin_no = '" + tintxtbox.Text + "', " +
            "emp_philhealth_no = '" + philhealthtxtbox.Text + "', " +
            "emp_pagibig_no = '" + pagibigtxtbox.Text + "', " +
            "emp_status = '" + statuscombobox.Text + "', " +
            "emp_height = '" + heighttxtbox.Text + "', " +
            "emp_weight = '" + weighttxtbox.Text + "', " +
            "add_yrs_stay = '" + yearstxtbox.Text + "', " +
            "add_house_no = '" + housenumtxtbox.Text + "', " +
            "add_sub_name = '" + subditxtbox.Text + "', " +
            "add_phase_no = '" + phasenumtxtbox.Text + "', " +
            "add_street = '" + streettxtbox.Text + "', " +
            "add_barangay = '" + brgytxtbox.Text + "', " +
            "add_municipality = '" + municipalitytxtbox.Text + "', " +
            "add_city = '" + citytxtbox.Text + "', " +
            "add_state_province = '" + statetxtbox.Text + "', " +
            "add_country = '" + countrytxtbox.Text + "', " +
            "add_zipcode = '" + ziptxtbox.Text + "', " +
            "elem_name = '" + elemschooltxtbox.Text + "', " +
            "elem_address = '" + elem_addtxtbox.Text + "', " +
            "elem_yr_grad = '" + dateTimePicker1.Text + "', " +
            "elem_award = '" + elem_awardtxtbox.Text + "', " +
            "junior_high_name = '" + jhstxtbox.Text + "', " +
            "junior_high_address = '" + jhs_addtxtbox.Text + "', " +
            "junior_high_yr_grad = '" + dateTimePicker2.Text + "', " +
            "junior_high_award = '" + jhs_awardtxtbox.Text + "', " +
            "senior_high_name = '" + shstxtbox.Text + "', " +
            "senior_high_address = '" + shs_addtxtbox.Text + "', " +
            "senior_high_yr_grad = '" + dateTimePicker3.Text + "', " +
            "senior_high_award = '" + shs_awardtxtbox.Text + "', " +
            "track = '" + shs_tracktxtbox.Text + "', " +
            "college_school_name = '" + collegetxtbox.Text + "', " +
            "college_address = '" + col_addtxtbox.Text + "', " +
            "college_yr_grad = '" + dateTimePicker4.Text + "', " +
            "college_award = '" + col_awardtxtbox.Text + "', " +
            "college_course = '" + coursetxtbox.Text + "', " +
            "others = '" + otherstxtbox.Text + "', " +
            "position = '" + postxtbox.Text + "', " +
            "emp_work_status = '" + empstatustxtbox.Text + "', " +
            "emp_date_hired = '" + dateTimePicker5.Text + "', " +
            "emp_department = '" + depttxtbox.Text + "', " +
            "emp_no_of_dependents = '" + numofdeptxtbox.Text + "', " +
            "picpath = '" + picpathtxtbox.Text + "' " +
            "WHERE emp_id = '" + empnumtxtbox.Text + "'";
            empdb_connect.employee_cmd();
            empdb_connect.employee_sqladapterUpdate();
            empdb_connect.employee_sql = "SELECT * FROM pos_empRegTbl";
            empdb_connect.employee_cmd();
            empdb_connect.employee_sqladapterSelect();
            empdb_connect.employee_sqldatasetSELECT();
            dataGridView1.DataSource = empdb_connect.employee_sql_dataset.Tables[0];
            cleartextboxes();
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            cleartextboxes();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            cleartextboxes();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image File | *.gif; *.jpg; *.png; *.jfif; *.bmp";
            openFileDialog1.ShowDialog();
            pictureBox1.Image = System.Drawing.Image.FromFile(openFileDialog1.FileName);
            picpath = openFileDialog1.FileName;
            picpathtxtbox.Text = picpath;
        }
    }
}
