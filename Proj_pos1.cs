using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing.QrCode.Internal;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace projectNamin
{
    public partial class Proj_pos1 : Form
    {
        //codes for accessing the class variables and methods inside the class
        pos_dbconnection posdb_connect = new pos_dbconnection();
        Price_Item_Value price_item_value = new Price_Item_Value();
        Variables variables = new Variables();

        public Proj_pos1()
        {
            posdb_connect.pos_connString();
            InitializeComponent();
        }
        //function methods for clearing quantity textbox putting the cursor inside
        private void quantityTxtbox()
        {
            quantitytxtbox.Clear();
            quantitytxtbox.Focus();
        }
        //function methods for converting quantity and price input from string to numeric value
        private void quantity_price_Convert()
        {
            variables.quantity = Convert.ToInt32(quantitytxtbox.Text);
            variables.price = Convert.ToDouble(pricetxtbox.Text);
        }
        // function methods for the formula needed in the program computations
        private void computation_Formula_and_DisplayData()
        {
            variables.discounted_amt = (variables.quantity * variables.price) -
            variables.discount_amt;
            discounttxtbox.Text = variables.discount_amt.ToString("n");
            discountedtxtbox.Text = variables.discounted_amt.ToString("n");
        }
        //function with return value for item name and price textbox
        public void GetPriceItemValue()
        {
            itemnametxtbox.Text = (price_item_value.GetItemName());
            pricetxtbox.Text = (price_item_value.GetPrice());
        }
        private void cleartextboxes()
        {
            itemnametxtbox.Clear();
            pricetxtbox.Clear();
            quantitytxtbox.Clear();
            discountedtxtbox.Clear();
            discounttxtbox.Clear();
            changetxtbox.Clear();
            cashrenderedtxtbox.Clear();
        }

        private void Proj_pos1_Load(object sender, EventArgs e)
        {
            try
            {
                // codes for disabling the textboxes
                itemnametxtbox.Enabled = false;
                pricetxtbox.Enabled = false;
                discountedtxtbox.Enabled = false;
                qty_totaltxtbox.Enabled = false;
                discount_totaltxtbox.Enabled = false;
                discounted_totaltxtbox.Enabled = false;
                changetxtbox.Enabled = false;
                discounttxtbox.Enabled = false;
                //code for hiding the picture location of the image thrown inside the textboxes
                picpathTxtbox1.Hide(); picpathTxtbox2.Hide(); picpathTxtbox3.Hide();
                picpathTxtbox4.Hide(); picpathTxtbox5.Hide(); picpathTxtbox6.Hide();
                picpathTxtbox7.Hide(); picpathTxtbox8.Hide(); picpathTxtbox9.Hide();
                picpathTxtbox10.Hide(); picpathTxtbox11.Hide();
                picpathTxtbox12.Hide(); picpathTxtbox13.Hide();
                picpathTxtbox14.Hide(); picpathTxtbox15.Hide();
                picpathTxtbox16.Hide(); picpathTxtbox17.Hide();
                picpathTxtbox18.Hide(); picpathTxtbox19.Hide();
                picpathTxtbox20.Hide();

                //codes for retrieving data from the database and display it in the interface objects
                posdb_connect.pos_select_cashier();
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterSelect();
                posdb_connect.pos_sqldatasetSELECT();
                //codes for throwing data from tables inside the database to the textboxes
                name1lbl.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][2].ToString();
                name2lbl.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][3].ToString();
                name3lbl.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][4].ToString();
                name4lbl.Text =
               posdb_connect.pos_sql_dataset.Tables[0].Rows[0][5].ToString();
                name5lbl.Text =
               posdb_connect.pos_sql_dataset.Tables[0].Rows[0][6].ToString();
                name6lbl.Text =
               posdb_connect.pos_sql_dataset.Tables[0].Rows[0][7].ToString();
                name7lbl.Text =
               posdb_connect.pos_sql_dataset.Tables[0].Rows[0][8].ToString();
                name8lbl.Text =
               posdb_connect.pos_sql_dataset.Tables[0].Rows[0][9].ToString();
                name9lbl.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][10].ToString();
                name10lbl.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][11].ToString();
                name11lbl.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][12].ToString();
                name12lbl.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][13].ToString();
                name13lbl.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][14].ToString();
                name14lbl.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][15].ToString();
                name15lbl.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][16].ToString();
                name16lbl.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][17].ToString();
                name17lbl.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][18].ToString();
                name18lbl.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][19].ToString();
                name19lbl.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][20].ToString();
                name20lbl.Text =
                 posdb_connect.pos_sql_dataset.Tables[0].Rows[0][21].ToString();
                picpathTxtbox1.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][24].ToString();
                pictureBox1.Image = Image.FromFile(picpathTxtbox1.Text);
                picpathTxtbox2.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][25].ToString();
                pictureBox2.Image = Image.FromFile(picpathTxtbox2.Text);
                picpathTxtbox3.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][26].ToString();
                pictureBox3.Image = Image.FromFile(picpathTxtbox3.Text);
                picpathTxtbox4.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][27].ToString();
                pictureBox4.Image = Image.FromFile(picpathTxtbox4.Text);
                picpathTxtbox5.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][28].ToString();
                pictureBox5.Image = Image.FromFile(picpathTxtbox5.Text);
                picpathTxtbox6.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][29].ToString();
                pictureBox6.Image = Image.FromFile(picpathTxtbox6.Text);
                picpathTxtbox7.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][30].ToString();
                pictureBox7.Image = Image.FromFile(picpathTxtbox7.Text);
                picpathTxtbox8.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][31].ToString();
                pictureBox8.Image = Image.FromFile(picpathTxtbox8.Text);
                picpathTxtbox9.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][32].ToString();
                pictureBox9.Image = Image.FromFile(picpathTxtbox9.Text);
                picpathTxtbox10.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][33].ToString();
                pictureBox10.Image = Image.FromFile(picpathTxtbox10.Text);
                picpathTxtbox11.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][34].ToString();
                pictureBox11.Image = Image.FromFile(picpathTxtbox11.Text);
                picpathTxtbox12.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][35].ToString();
                pictureBox12.Image = Image.FromFile(picpathTxtbox12.Text);
                picpathTxtbox13.Text =
               posdb_connect.pos_sql_dataset.Tables[0].Rows[0][36].ToString();
                pictureBox13.Image = Image.FromFile(picpathTxtbox13.Text);
                picpathTxtbox14.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][37].ToString();
                pictureBox14.Image = Image.FromFile(picpathTxtbox14.Text);
                picpathTxtbox15.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][38].ToString();
                pictureBox15.Image = Image.FromFile(picpathTxtbox15.Text);
                picpathTxtbox16.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][39].ToString();
                pictureBox16.Image = Image.FromFile(picpathTxtbox16.Text);
                picpathTxtbox17.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][40].ToString();
                pictureBox17.Image = Image.FromFile(picpathTxtbox17.Text);
                picpathTxtbox18.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][41].ToString();
                pictureBox18.Image = Image.FromFile(picpathTxtbox18.Text);
                picpathTxtbox19.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][42].ToString();
                pictureBox19.Image = Image.FromFile(picpathTxtbox19.Text);
                picpathTxtbox20.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][43].ToString();
                pictureBox20.Image = Image.FromFile(picpathTxtbox20.Text);
                pricelbl1.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][46].ToString();
                pricelbl2.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][47].ToString();
                pricelbl3.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][48].ToString();
                pricelbl4.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][49].ToString();
                pricelbl5.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][50].ToString();
                pricelbl6.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][51].ToString();
                pricelbl7.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][52].ToString();
                pricelbl8.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][53].ToString();
                pricelbl9.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][54].ToString();
                pricelbl10.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][55].ToString();
                pricelbl11.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][56].ToString();
                pricelbl12.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][57].ToString();
                pricelbl13.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][58].ToString();
                pricelbl14.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][59].ToString();
                pricelbl15.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][60].ToString();
                pricelbl16.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][61].ToString();
                pricelbl17.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][62].ToString();
                pricelbl18.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][63].ToString();
                pricelbl19.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][64].ToString();
                pricelbl20.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][65].ToString();
                //codes for retrieving data from the database and display it in the interface objects
                posdb_connect.pos_select_cashier_display();
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterSelect();
                posdb_connect.pos_select_cashier_SELECTdisplay();
                //codes for throwing data from tables inside the database to the textboxes
                terminal_noLbl.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][3].ToString();
                emp_idLbl.Text =
        posdb_connect.pos_sql_dataset.Tables[0].Rows[0][0].ToString();
                emp_fnameLbl.Text =
        posdb_connect.pos_sql_dataset.Tables[0].Rows[0][1].ToString();
                emp_surnameLbl.Text =
        posdb_connect.pos_sql_dataset.Tables[0].Rows[0][2].ToString();
                DateTime dateTime = DateTime.Now;
                time_dateLbl.Text = dateTime.ToString("MMMM dd, yyyy");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurs in this area. Please contact your adminitrator!");
            }
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (seniorRbtn.Checked == true)
                {
                    posdb_connect.pos_sql = "INSERT INTO salesTbl (product_name," +
                        "product_quantity_per_transaction, product_price, discount_option," +
                        "discount_amount_per_transaction, discounted_amount_per_transaction," +
                        "summary_total_quantity, summary_total_disc_given,summary_total_discounted_amount, " +
                        "terminal_no, time_date, emp_id)VALUES('" + itemnametxtbox.Text + "', '" +
                        quantitytxtbox.Text + "', '" + pricetxtbox.Text + "', '" + seniorRbtn.Text + "', '" +
                        discounttxtbox.Text + "', '" + discountedtxtbox.Text + "', '" + qty_totaltxtbox.Text +
                        "', '" + discount_totaltxtbox.Text + "', '" + discounted_totaltxtbox.Text +
                        "', '" + terminal_noLbl.Text + "', '" + time_dateLbl.Text + "', '" + emp_idLbl.Text + "')";
                    posdb_connect.pos_cmd();
                    posdb_connect.pos_sqladapterInsert();
                    cleartextboxes();
                }
                else if (withdiscRbtn.Checked == true)
                {
                    posdb_connect.pos_sql = "INSERT INTO salesTbl (product_name," +
                        "product_quantity_per_transaction, product_price, discount_option," +
                        "discount_amount_per_transaction, discounted_amount_per_transaction," +
                        "summary_total_quantity, summary_total_disc_given," +
                        "summary_total_discounted_amount, terminal_no, time_date, emp_id)" +
                        "VALUES('" + itemnametxtbox.Text + "', '" + quantitytxtbox.Text +
                        "', '" + pricetxtbox.Text + "', '" + withdiscRbtn.Text + "', '" +
                        discounttxtbox.Text + "', '" + discountedtxtbox.Text + "', '" +
                        qty_totaltxtbox.Text + "', '" + discount_totaltxtbox.Text + "', '" +
                        discounted_totaltxtbox.Text + "', '" + terminal_noLbl.Text + "', '" +
                        time_dateLbl.Text + "', '" + emp_idLbl.Text + "')";
                    posdb_connect.pos_cmd();
                    posdb_connect.pos_sqladapterInsert();
                    cleartextboxes();
                }
                else if (employeeRbtn.Checked == true)
                {
                    posdb_connect.pos_sql = "INSERT INTO salesTbl (product_name," +
                        "product_quantity_per_transaction, product_price, discount_option," +
                        "discount_amount_per_transaction, discounted_amount_per_transaction," +
                        "summary_total_quantity, summary_total_disc_given," +
                        "summary_total_discounted_amount, terminal_no, time_date, emp_id)" +
                        "VALUES('" + itemnametxtbox.Text + "', '" + quantitytxtbox.Text +
                        "', '" + pricetxtbox.Text + "', '" + employeeRbtn.Text + "', '" +
                        discounttxtbox.Text + "', '" + discountedtxtbox.Text + "', '" +
                        qty_totaltxtbox.Text + "', '" + discount_totaltxtbox.Text + "', '" +
                        discounted_totaltxtbox.Text + "', '" + terminal_noLbl.Text + "', '" +
                        time_dateLbl.Text + "', '" + emp_idLbl.Text + "')";
                    posdb_connect.pos_cmd();
                    posdb_connect.pos_sqladapterInsert();
                    cleartextboxes();
                }
                else if (nodiscRbtn.Checked == true)
                {
                    posdb_connect.pos_sql = "INSERT INTO salesTbl (product_name," +
                        "product_quantity_per_transaction, product_price, discount_option," +
                        "discount_amount_per_transaction, discounted_amount_per_transaction," +
                        "summary_total_quantity, summary_total_disc_given," +
                        "summary_total_discounted_amount, terminal_no, time_date, emp_id)" +
                        "VALUES('" + itemnametxtbox.Text + "', '" + quantitytxtbox.Text +
                        "', '" + pricetxtbox.Text + "', '" + nodiscRbtn.Text + "', '" +
                        discounttxtbox.Text + "', '" + discountedtxtbox.Text + "', '" +
                        qty_totaltxtbox.Text + "', '" + discount_totaltxtbox.Text + "', '" +
                        discounted_totaltxtbox.Text + "', '" + terminal_noLbl.Text + "', '" +
                        time_dateLbl.Text + "', '" + emp_idLbl.Text + "')";
                    posdb_connect.pos_cmd();
                    posdb_connect.pos_sqladapterInsert();
                    cleartextboxes();
                }
                else
                    MessageBox.Show("No selected discount option");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator for this matter!!!");
            }
        }

        private void seniorRbtn_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                // accessing the function with methods to convert string inputs to numeric values from the quantity and price textboxes
                quantity_price_Convert();
                variables.discount_amt = (variables.quantity * variables.price) * 0.30;
                //accessing the function with methods for the computation formula of the program and displaying the computed output
                computation_Formula_and_DisplayData();
                //codes for unchecking the other radio buttons in the interface
                withdiscRbtn.Checked = false;
                employeeRbtn.Checked = false;
                nodiscRbtn.Checked = false;

            }
            catch (Exception)
            {
                MessageBox.Show("Input is invalid");
                //accessing the function with methods to clear the quantity textbox and automatically place the cursor inside the textbox
                quantityTxtbox();
            }
        }

        private void withdiscRbtn_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //accessing the function with methods to convert string inputs to numeric values from the quantity and price textboxes
                quantity_price_Convert();
                variables.discount_amt = (variables.quantity * variables.price) * 0.10;
                //accessing function with methods for the computation formula of the program and displaying the computed output
                computation_Formula_and_DisplayData();
                seniorRbtn.Checked = false;
                employeeRbtn.Checked = false;
                nodiscRbtn.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Input is invalid");
                // function with methods to clear the quantity textbox and automatically place the cursor inside the textbox
                quantityTxtbox();
            }

        }

        private void employeeRbtn_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                quantity_price_Convert();
                variables.discount_amt = (variables.quantity * variables.price) * 0.15;
                computation_Formula_and_DisplayData();
                seniorRbtn.Checked = false;
                withdiscRbtn.Checked = false;
                nodiscRbtn.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Input is invalid");
                // function with methods to clear the quantity textbox and automatically place the cursor inside the textbox
                quantityTxtbox();
            }
        }

        private void nodiscRbtn_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                variables.discount_amt = (variables.quantity * variables.price) * 0;
                computation_Formula_and_DisplayData();
                seniorRbtn.Checked = false;
                withdiscRbtn.Checked = false;
                employeeRbtn.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Input is invalid");
                // function with methods to clear the quantity textbox and automatically place the cursor inside the textbox
                quantityTxtbox();
            }
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            try
            {
                variables.quantity = Convert.ToInt32(quantitytxtbox.Text);
                variables.discount_amt = Convert.ToDouble(discounttxtbox.Text);
                variables.discounted_amt = Convert.ToDouble(discountedtxtbox.Text);
                variables.cash_given = Convert.ToDouble(cashrenderedtxtbox.Text);
                variables.qty_total += variables.quantity;
                variables.discount_totalgiven += variables.discount_amt;
                variables.discounted_total += variables.discounted_amt;
                variables.change = variables.cash_given - variables.discounted_amt;
                qty_totaltxtbox.Text = variables.qty_total.ToString();
                discount_totaltxtbox.Text = variables.discount_totalgiven.ToString("n");
                discounted_totaltxtbox.Text = variables.discounted_total.ToString("n");
                changetxtbox.Text = variables.change.ToString("n");
                cashrenderedtxtbox.Text = variables.cash_given.ToString("n");
            }
            catch (Exception)
            {
                MessageBox.Show("Make sure cash given textbox is not empty invalid ");
                cashrenderedtxtbox.Clear();
                cashrenderedtxtbox.Focus();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // codes for setting the value of item name and price inside the parameters located within the class
            price_item_value.SetPriceItemValue(name1lbl.Text, pricelbl1.Text);//the code should be inserted
                                                                              // codes for accessing the function, whose instruction is to get the returning values of price and item name individually
            GetPriceItemValue();//this code should be inserted
            quantityTxtbox();//this codes is already existing and should be retain. 
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(name2lbl.Text, pricelbl2.Text);
            GetPriceItemValue();
            quantityTxtbox();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(name3lbl.Text, pricelbl3.Text);
            GetPriceItemValue();
            quantityTxtbox();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(name4lbl.Text, pricelbl4.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(name5lbl.Text, pricelbl5.Text);
            GetPriceItemValue();
            quantityTxtbox();

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(name6lbl.Text, pricelbl6.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(name7lbl.Text, pricelbl7.Text);
            GetPriceItemValue();
            quantityTxtbox();

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(name8lbl.Text, pricelbl8.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(name9lbl.Text, pricelbl9.Text);
            GetPriceItemValue();
            quantityTxtbox();

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(name10lbl.Text, pricelbl10.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(name11lbl.Text, pricelbl11.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(name12lbl.Text, pricelbl12.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(name13lbl.Text, pricelbl13.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(name14lbl.Text, pricelbl4.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(name15lbl.Text, pricelbl15.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(name16lbl.Text, pricelbl16.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(name17lbl.Text, pricelbl7.Text);
            GetPriceItemValue();
            quantityTxtbox();

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(name18lbl.Text, pricelbl18.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(name18lbl.Text, pricelbl18.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(name20lbl.Text, pricelbl20.Text);
            GetPriceItemValue();
            quantityTxtbox();
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

    }
}
