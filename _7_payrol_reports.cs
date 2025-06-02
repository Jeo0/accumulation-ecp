using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics.CodeAnalysis;

namespace projectNamin
{
    public partial class _7_payrol_reports : Form
    {
        payrol_dbconnection payrol_db_connect = new payrol_dbconnection();

        // just edit this
        string gl_whatTable = "payrolTbl";
        Dictionary<string, string> gl_optionsCombobox = new Dictionary<string, string> {
            { "rate/hr", "basic_rate_hr"},
            { "gross_income", "gross_income"},
            { "net_income", "net_income"},
            { "employee_number", "emp_id"},
        };

        /// /////////////////////////////////////////////////////////
        /// /////////////////////////////////////////////////////////
        /// /////////////////////////////////////////////////////////
        /// /////////////////////////////////////////////////////////
        public _7_payrol_reports()
        {
            payrol_db_connect.payrol_connString();
            InitializeComponent();
        }


        private void payrol_select()
        {
            payrol_db_connect.payrol_cmd();
            payrol_db_connect.payrol_sqladapterSelect();
            payrol_db_connect.payrol_sqldatasetSELECT();
            dataGridView1.DataSource = payrol_db_connect.payrol_sql_dataset.Tables[0];
        }

        private void cleartextboxes()
        {
            optionCombo.Text = "";
            optionInputTxtbox.Clear();
            optionCombo.Focus();
        }

        private void cleartextboxes1()
        {
            optionInputTxtbox.Clear();
            optionInputTxtbox.Focus();
        }


        /// /////////////////////////////////////////////////////////
        /// /////////////////////////////////////////////////////////
        /// /////////////////////////////////////////////////////////
        /// /////////////////////////////////////////////////////////
        private void _7_payrol_reports_Load(object sender, EventArgs e)
        {
            payrol_db_connect.payrol_sql = "SELECT * FROM " + gl_whatTable;
            payrol_select();


            // addition of the options (tiantamad ako magedit dun sa combobox, so lets handle this at runtime)
            foreach (var (optionForTheBox, columnName) in gl_optionsCombobox) 
                optionCombo.Items.Add(optionForTheBox);
        }

        /// /////////////////////////////////////////////////////////
        /// /////////////////////////////////////////////////////////
        /// /////////////////////////////////////////////////////////
        /// /////////////////////////////////////////////////////////

        private void search_button_Click(object sender, EventArgs e) {

            // handle empty combobox
            string columnName = "";
            try {
                columnName = gl_optionsCombobox[optionCombo.Text];

            } catch (Exception) {
                MessageBox.Show("Please select a valid option from the dropdown menu.");
                optionCombo.Focus();
                return;
            }


            // handle empty text input
            try {
                if (string.IsNullOrWhiteSpace(optionInputTxtbox.Text))
                    throw new Exception("Search input cannot be empty.");

            } catch (Exception) {
                MessageBox.Show("Please do not leave the text box empty");
                optionInputTxtbox.Focus();
                return;
            }


            payrol_db_connect.payrol_sql = "SELECT * FROM " + gl_whatTable + " WHERE " + columnName + " = '" + optionInputTxtbox.Text + "'";
            payrol_select();
            cleartextboxes1();
        }

        /// /////////////////////////////////////////////////////////
        /// /////////////////////////////////////////////////////////
        /// /////////////////////////////////////////////////////////
        /// /////////////////////////////////////////////////////////

        private void back_button_Click(object sender, EventArgs e)
        {
            try {
                payrol_db_connect.payrol_sql = "SELECT * FROM " + gl_whatTable;
                payrol_select();
                cleartextboxes();
            } catch (Exception) {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }
    }
}
