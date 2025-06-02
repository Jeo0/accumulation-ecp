using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using AForge.Video;
using AForge.Video.DirectShow;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using ZXing.QrCode;
using ZXing.Windows.Compatibility;
using projectNamin;

namespace lesson3___example3
{
    public partial class Proj_pos2 : Form
    {

        pos_dbconnection posdb_connect = new pos_dbconnection();
        Price_Item_Value price_item_value = new Price_Item_Value();
        Variables variables = new Variables();

        // Declare global variables for the camera
        private FilterInfoCollection videoDevices; // List of available webcams
        private VideoCaptureDevice videoSource;   // Selected webcam
        private bool scanning = false;
        private System.Windows.Forms.Timer timer;

        // form and can be access for one object to another

        Plesson3_class class3 = new Plesson3_class();


        public void setPriceAndAddListbox(double price, object namename)
        {
            discountAmountTxtBox.Text = "0.00";
            priceTxtBox.Text = Convert.ToString(price);

            // option 1: check before typecasting
            if (namename is System.Windows.Forms.CheckBox checkBox)
            {
                displayListBox.Items.Add(checkBox.Text + " " + priceTxtBox.Text);
            }

            // option 2: direct casting assuming that namename is always a checkbox
            //displayListBox.Items.Add((System.Windows.Forms.CheckBox)namename.Text);

            quantityTxtBox.Text = "0";
            quantityTxtBox.Focus();
        }
        /// //////////////////////////////////////////
        /// //////////////////////////////////////////
        /// //////////////////////////////////////////
        /// //////////////////////////////////////////
        /// //////////////////////////////////////////
        /// //////////////////////////////////////////
        ///
        /// initial components
        ///
        /// //////////////////////////////////////////
        /// //////////////////////////////////////////
        /// //////////////////////////////////////////
        /// //////////////////////////////////////////
        /// //////////////////////////////////////////


        public Proj_pos2()
        {
            posdb_connect.pos_connString();
            InitializeComponent();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 500; // Set interval to 500ms
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (scanning)
            {
                ScanQRCode();
            }
        }

        /// //////////////////////////////////////////
        ///
        /// qrcode functions
        ///
        /// //////////////////////////////////////////

        private void ScanQRCode()
        {
            if (qrbox.Image != null)
            {
                // with the help from chatgpt
                try
                {
                    // Create a BarcodeReader to decode the image
                    BarcodeReader reader = new BarcodeReader();
                    Result result = reader.Decode((Bitmap)qrbox.Image);

                    if (result != null)
                    {
                        // Safely update the UI (Invoke required because QRBOX.Image and Cash_renderedtxtbox are UI controls)
                        this.Invoke((Action)(() =>
                        {
                            cashGivenTxtBox.Text = result.Text; // Display the scanned amount
                            StopCamera(); // Stop scanning after a successful read
                        }));
                    }
                }

                catch (Exception ex)
                {
                    // Handle any exceptions during decoding
                    Console.WriteLine("Error scanning QR code: " + ex.Message);
                }

            }
        }

        private void StartCamera()
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (videoDevices.Count > 0)
            {
                videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString); // Select first camera
                videoSource.NewFrame += new NewFrameEventHandler(Video_NewFrame);
                videoSource.Start();
                scanning = true;
            }
            else
            {
                MessageBox.Show("No camera found!");
            }
        }

        private void Video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            // with the help from chatgpt
            try
            {
                // Update the QR code box image in the UI thread
                this.Invoke((Action)(() =>
                {
                    qrbox.Image = (Bitmap)eventArgs.Frame.Clone();
                }));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error handling new frame: " + ex.Message);
            }
        }

        private void StopCamera()
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource = null;
                scanning = false;
            }
        }

        private void scanqrbtn_Click(object sender, EventArgs e)
        {
            // Reset the picture box
            if (qrbox.Image != null)
            {
                qrbox.Image.Dispose();
                qrbox.Image = null;
            }

            StopCamera();
            StartCamera();
            timer.Start();

            newbtn.Enabled = true;
        }

        private void cleartextboxes()
        {
            
            priceTxtBox.Clear();
            quantityTxtBox.Clear();
            discountAmountTxtBox.Clear();
            discountedAmounttxtBox.Clear();
            changeTxtBox.Clear();
            cashGivenTxtBox.Clear();
            totalBillsTxtBox.Clear();
            totalQtyTxtBox.Clear();
        }
        /// ////////////////////////////////////////////////
        ///
        /// code proper
        ///
        /// ////////////////////////////////////////////////


        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // codes for disabling the textboxes
                priceTxtBox.Enabled = false;
                discountedAmounttxtBox.Enabled = false;
                totalQtyTxtBox.Enabled = false;
                discountAmountTxtBox.Enabled = false;
                changeTxtBox.Enabled = false;
                totalBillsTxtBox.Enabled = false;
                
                //code for hiding the picture location of the image thrown inside the textboxes
                picpathtxtbox1.Hide(); picpathtxtbox2.Hide(); picpathtxtbox3.Hide();
                picpathtxtbox4.Hide(); picpathtxtbox5.Hide(); picpathtxtbox6.Hide();
                picpathtxtbox7.Hide(); picpathtxtbox8.Hide(); picpathtxtbox9.Hide();
                picpathtxtbox10.Hide(); picpathtxtbox11.Hide();
                picpathtxtbox12.Hide(); picpathtxtbox13.Hide();
                picpathtxtbox14.Hide(); picpathtxtbox15.Hide();
                picpathtxtbox16.Hide(); picpathtxtbox17.Hide();
                picpathtxtbox18.Hide(); picpathtxtbox19.Hide();
                picpathtxtbox20.Hide();

                //codes for retrieving data from the database and display it in the interface objects
                posdb_connect.pos_select_cashier1();
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterSelect();
                posdb_connect.pos_sqldatasetSELECT();
                //codes for throwing data from tables inside the database to the textboxes
                namelbl1.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][2].ToString();
                namelbl2.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][3].ToString();
                namelbl3.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][4].ToString();
                namelbl4.Text =
               posdb_connect.pos_sql_dataset.Tables[0].Rows[0][5].ToString();
                namelbl5.Text =
               posdb_connect.pos_sql_dataset.Tables[0].Rows[0][6].ToString();
                namelbl6.Text =
               posdb_connect.pos_sql_dataset.Tables[0].Rows[0][7].ToString();
                namelbl7.Text =
               posdb_connect.pos_sql_dataset.Tables[0].Rows[0][8].ToString();
                namelbl8.Text =
               posdb_connect.pos_sql_dataset.Tables[0].Rows[0][9].ToString();
                namelbl9.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][10].ToString();
                namelbl10.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][11].ToString();
                namelbl11.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][12].ToString();
                namelbl12.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][13].ToString();
                namelbl13.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][14].ToString();
                namelbl14.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][15].ToString();
                namelbl15.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][16].ToString();
                namelbl16.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][17].ToString();
                namelbl17.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][18].ToString();
                namelbl18.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][19].ToString();
                namelbl19.Text =
                posdb_connect.pos_sql_dataset.Tables[0].Rows[0][20].ToString();
                namelbl20.Text =
                 posdb_connect.pos_sql_dataset.Tables[0].Rows[0][21].ToString();

                picpathtxtbox1.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][24].ToString();
                pizzaPic1.Image = System.Drawing.Image.FromFile(picpathtxtbox1.Text);

                picpathtxtbox2.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][25].ToString();
                pizzaPic2.Image = System.Drawing.Image.FromFile(picpathtxtbox2.Text);

                picpathtxtbox3.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][26].ToString();
                pizzaPic3.Image = System.Drawing.Image.FromFile(picpathtxtbox3.Text);

                picpathtxtbox4.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][27].ToString();
                pizzaPic4.Image = System.Drawing.Image.FromFile(picpathtxtbox4.Text);

                picpathtxtbox5.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][28].ToString();
                pizzaPic5.Image = System.Drawing.Image.FromFile(picpathtxtbox5.Text);

                picpathtxtbox6.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][29].ToString();
                pizzaPic6.Image = System.Drawing.Image.FromFile(picpathtxtbox6.Text);

                picpathtxtbox7.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][30].ToString();
                pizzaPic7.Image = System.Drawing.Image.FromFile(picpathtxtbox7.Text);

                picpathtxtbox8.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][31].ToString();
                pizzaPic8.Image = System.Drawing.Image.FromFile(picpathtxtbox8.Text);

                picpathtxtbox9.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][32].ToString();
                pizzaPic9.Image = System.Drawing.Image.FromFile(picpathtxtbox9.Text);

                picpathtxtbox10.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][33].ToString();
                pizzaPic10.Image = System.Drawing.Image.FromFile(picpathtxtbox10.Text);

                picpathtxtbox11.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][34].ToString();
                pizzaPic11.Image = System.Drawing.Image.FromFile(picpathtxtbox11.Text);

                picpathtxtbox12.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][35].ToString();
                pizzaPic12.Image = System.Drawing.Image.FromFile(picpathtxtbox12.Text);

                picpathtxtbox13.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][36].ToString();
                pizzaPic13.Image = System.Drawing.Image.FromFile(picpathtxtbox13.Text);

                picpathtxtbox14.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][37].ToString();
                pizzaPic14.Image = System.Drawing.Image.FromFile(picpathtxtbox14.Text);

                picpathtxtbox15.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][38].ToString();
                pizzaPic15.Image = System.Drawing.Image.FromFile(picpathtxtbox15.Text);

                picpathtxtbox16.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][39].ToString();
                pizzaPic16.Image = System.Drawing.Image.FromFile(picpathtxtbox16.Text);

                picpathtxtbox17.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][40].ToString();
                pizzaPic17.Image = System.Drawing.Image.FromFile(picpathtxtbox17.Text);

                picpathtxtbox18.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][41].ToString();
                pizzaPic18.Image = System.Drawing.Image.FromFile(picpathtxtbox18.Text);

                picpathtxtbox19.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][42].ToString();
                pizzaPic19.Image = System.Drawing.Image.FromFile(picpathtxtbox19.Text);

                picpathtxtbox20.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][43].ToString();
                pizzaPic20.Image = System.Drawing.Image.FromFile(picpathtxtbox20.Text);
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
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your adminitrator!");
            }
            this.BackColor = Color.LightGoldenrodYellow;
            //disabling textboxes
            priceTxtBox.Enabled = false;
            discountAmountTxtBox.Enabled = false;
            changeTxtBox.Enabled = false;
            totalBillsTxtBox.Enabled = false;
            discountAmountTxtBox.Enabled = false;
            totalQtyTxtBox.Enabled = false;



            // for inserting image to a picturebox
            // same thing from the checkbox
            System.Windows.Forms.PictureBox[] pictureboxArr = {
              pizzaPic1,
              pizzaPic2,
              pizzaPic3,
              pizzaPic4,
              pizzaPic5,
              pizzaPic6,
              pizzaPic7,
              pizzaPic8,
              pizzaPic9,
              pizzaPic10,
              pizzaPic11,
              pizzaPic12,
              pizzaPic13,
              pizzaPic14,
              pizzaPic15,
              pizzaPic16,
              pizzaPic17,
              pizzaPic18,
              pizzaPic19,
              pizzaPic20
            };
            for (int iii = 0; iii < pictureboxArr.Length; iii++)
            {
                pictureboxArr[iii].Image = System.Drawing.Image.FromFile(class3.imagePath + "d" + Convert.ToString(iii + 1) + ".jfif");

            }

            // to disable to checkboxes
            // A
            friedchickenCheckBox.Enabled = false;
            friesCheckbox.Enabled = false;
            cokeCheckBox.Enabled = false;
            sidedishCheckBox.Enabled = false;
            specialpizzaCheckbox.Enabled = false;

            // B
            halohaloCheckbox.Enabled = false;
            chickenCheckbox.Enabled = false;
            carbonaraCheckBox.Enabled = false;
            famfriesCheckBox.Enabled = false;
            hawaiianCheckBox.Enabled = false;
        }

        /// ////////////////////////////////////////////////
        /// ////////////////////////////////////////////////
        /// ////////////////////////////////////////////////
        /// ////////////////////////////////////////////////
        /// ////////////////////////////////////////////////
        /// ////////////////////////////////////////////////
        /// 
        /// bundle option radio button
        ///
        /// ////////////////////////////////////////////////
        /// ////////////////////////////////////////////////
        /// ////////////////////////////////////////////////
        /// ////////////////////////////////////////////////
        /// ////////////////////////////////////////////////
        /// ////////////////////////////////////////////////
        /// ////////////////////////////////////////////////
        /// ////////////////////////////////////////////////

        private void FoodBundleAradiobtn_CheckedChanged(object sender, EventArgs e)
        {
            displayListBox.Items.Clear();
            double price;

            this.BackColor = Color.LightCyan;       // for changing the form background
            FoodBundleBradiobtn.Checked = false;    // for food bundle B not to be selected

            //inserting image inside picturebox
            displayPictureBox.Image = System.Drawing.Image.FromFile(class3.imagePath + "fb1.jfif");

            // to check the checkboxes for A
            friedchickenCheckBox.Checked = true;
            friesCheckbox.Checked = true;
            cokeCheckBox.Checked = true;
            sidedishCheckBox.Checked = true;
            specialpizzaCheckbox.Checked = true;

            // to uncheck checkboxes for B
            halohaloCheckbox.Checked = false;
            chickenCheckbox.Checked = false;
            carbonaraCheckBox.Checked = false;
            famfriesCheckBox.Checked = false;
            hawaiianCheckBox.Checked = false;

            // for displaying data inside the textboxes
            priceTxtBox.Text = "1,000.00";
            discountAmountTxtBox.Text = "200.00";
            price = Convert.ToDouble(priceTxtBox.Text);

            // for inserting data inside the listbox
            displayListBox.Items.Add(FoodBundleAradiobtn.Text + " " + priceTxtBox.Text);
            displayListBox.Items.Add(" Discount Amount: " + " " + discountAmountTxtBox.Text);

            quantityTxtBox.Text = "0";
            quantityTxtBox.Focus();

        }

        private void FoodBundleBradiobtn_CheckedChanged(object sender, EventArgs e)
        {
            displayListBox.Items.Clear();
            double price;

            this.BackColor = Color.LightBlue;           // for changing the form background
            FoodBundleAradiobtn.Checked = false;        // for food bundle B not to be selected

            displayPictureBox.Image = System.Drawing.Image.FromFile(class3.imagePath + "fb2.jfif");        //inserting image inside picturebox

            // to check the checkboxes for A
            friedchickenCheckBox.Checked = false;
            friesCheckbox.Checked = false;
            cokeCheckBox.Checked = false;
            sidedishCheckBox.Checked = false;
            specialpizzaCheckbox.Checked = false;

            // to uncheck checkboxes for B
            halohaloCheckbox.Checked = true;
            chickenCheckbox.Checked = true;
            carbonaraCheckBox.Checked = true;
            famfriesCheckBox.Checked = true;
            hawaiianCheckBox.Checked = true;

            // for displaying data inside the textboxes
            priceTxtBox.Text = "1,299.00";
            discountAmountTxtBox.Text = "194.85";

            // for inserting data inside the listbox
            displayListBox.Items.Add(FoodBundleBradiobtn.Text + " " + priceTxtBox.Text);
            displayListBox.Items.Add(" Discount Amount: " + " " + discountAmountTxtBox.Text);

            quantityTxtBox.Text = "0";
            quantityTxtBox.Focus();
        }


        /// /////////////////////////////////////////////////////////
        /// /////////////////////////////////////////////////////////
        /// /////////////////////////////////////////////////////////
        /// /////////////////////////////////////////////////////////
        /// /////////////////////////////////////////////////////////
        /// /////////////////////////////////////////////////////////
        ///
        /// below shows the unique buttons
        ///
        /// /////////////////////////////////////////////////////////
        /// /////////////////////////////////////////////////////////
        /// /////////////////////////////////////////////////////////
        /// /////////////////////////////////////////////////////////
        /// /////////////////////////////////////////////////////////
        /// /////////////////////////////////////////////////////////
        /// /////////////////////////////////////////////////////////

        private void calcbills_Click_1(object sender, EventArgs e)
        {
            double cash_given = 0, change = 0, total_amountPaid = 0;

            // for total amount paid bills
            try
            {
                total_amountPaid = Convert.ToDouble(totalBillsTxtBox.Text);
            }
            catch (Exception asd)
            {
                MessageBox.Show(asd.Message);
                totalBillsTxtBox.Focus();
            }

            // cash given
            try
            {
                cash_given = Convert.ToDouble(cashGivenTxtBox.Text);
            }
            catch (Exception asd)
            {
                MessageBox.Show(asd.Message);
                cashGivenTxtBox.Focus();
            }

            // change
            try
            {
                change = cash_given - total_amountPaid;
            }
            catch (Exception asd)
            {
                MessageBox.Show(asd.Message);
            }

            // process
            changeTxtBox.Text = change.ToString("n");                                 // safe
            displayListBox.Items.Add("Total Bills:  " + totalBillsTxtBox.Text);
            displayListBox.Items.Add("Cash Given:  " + cashGivenTxtBox.Text);
            displayListBox.Items.Add("Total No. of Items:  " + totalQtyTxtBox.Text);  // safe

            if (cash_given < total_amountPaid)
            {
                MessageBox.Show("Insufficient cash! Please enter an amount greater than or equal to the total bill.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Stop further execution
            }
        }


        private void printbtn_Click(object sender, EventArgs e)
        {
            // codes for calling the other form connected to the current form
            Proj_pos2_printfrms print = new Proj_pos2_printfrms();

            // codes for displaying the contents of the listbox from other form to the
            // current form.
            print.printDisplayListBox.Items.AddRange(this.displayListBox.Items);

            // code for displaying the other form
            print.Show();

        }


        private void removebtn_Click(object sender, EventArgs e)
        {
            // codes to remove selected data inside the listbox
            displayListBox.Items.RemoveAt(displayListBox.SelectedIndex);
        }


        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void newbtn_Click(object sender, EventArgs e)
        {

            //codes to uncheck all given checkboxes
            FoodBundleAradiobtn.Checked = false;
            FoodBundleBradiobtn.Checked = false;

            //code for inserting default image inside the picturebox

            //code for unchecking
            cokeCheckBox.Checked = false;
            friedchickenCheckBox.Checked = false;
            friesCheckbox.Checked = false;
            sidedishCheckBox.Checked = false;
            specialpizzaCheckbox.Checked = false;

            carbonaraCheckBox.Checked = false;
            chickenCheckbox.Checked = false;
            famfriesCheckBox.Checked = false;
            halohaloCheckbox.Checked = false;
            hawaiianCheckBox.Checked = false;

            //codes for clearing the textboxes
            priceTxtBox.Clear();
            quantityTxtBox.Clear();

            System.Windows.Forms.CheckBox[] checkboxArr = {
              checkBox2,
              checkBox3,
              checkBox4,
              checkBox5,
              checkBox6,
              checkBox7,
              checkBox8,
              checkBox9,
              checkBox10,
              checkBox11,
              checkBox12,
              checkBox13,
              checkBox14,
              checkBox15,
              checkBox16,
              checkBox17,
              checkBox18,
              checkBox19,
              checkBox20,
              checkBox21
            };

            // range-based loop
            // uncheck all the checkboxes
            foreach (System.Windows.Forms.CheckBox iii in checkboxArr)
            {
                iii.Checked = false;
            }


            discountAmountTxtBox.Clear();
            displayPictureBox.Image = null;
            displayListBox.Items.Clear();

        }

        private void quantityTxtBox_TextChanged(object sender, EventArgs e)
        {
            double price = 0, discounted_amount = 0, discount_amount = 0;
            int qty = 0;

            // Ensure input values are not empty before conversion
            try
            {
                if (!string.IsNullOrWhiteSpace(priceTxtBox.Text))
                    price = Convert.ToDouble(priceTxtBox.Text);
            }
            catch (Exception asd)
            {
                MessageBox.Show(asd.Message);
                priceTxtBox.Focus();
            }


            try
            {
                if (!string.IsNullOrWhiteSpace(quantityTxtBox.Text))
                    qty = Convert.ToInt32(quantityTxtBox.Text);
            }
            catch (Exception asd)
            {
                MessageBox.Show(asd.Message);
                quantityTxtBox.Focus();
            }


            try
            {
                if (!string.IsNullOrWhiteSpace(discountAmountTxtBox.Text))
                    discount_amount = Convert.ToDouble(discountAmountTxtBox.Text);
            }
            catch (Exception asd)
            {
                MessageBox.Show(asd.Message);
                discountAmountTxtBox.Focus();
            }

            // Prevent negative calculations
            if (qty > 0)
            {
                discounted_amount = (price * qty) - (discount_amount * qty);
                class3.accumulateTotalQty(qty);
                class3.accumulateTotalAmount(discounted_amount);
            }
            else
            {
                discounted_amount = 0;
            }

            // Display results
            totalQtyTxtBox.Text = Convert.ToString(class3.getTotalQty());
            totalBillsTxtBox.Text = class3.getTotalAmount().ToString("n");
            // totalBillsTxtBox.Text = total_amount.ToString("n");
            discountedAmounttxtBox.Text = discounted_amount.ToString("n");


        }



        /// ////////////////////////////////////////////////////////////////////////
        /// ////////////////////////////////////////////////////////////////////////
        /// ////////////////////////////////////////////////////////////////////////
        /// ////////////////////////////////////////////////////////////////////////
        /// ////////////////////////////////////////////////////////////////////////
        /// ////////////////////////////////////////////////////////////////////////
        /// ////////////////////////////////////////////////////////////////////////
        /// ////////////////////////////////////////////////////////////////////////
        /// ////////////////////////////////////////////////////////////////////////
        /// ////////////////////////////////////////////////////////////////////////
        ///
        /// checkboxes setting the price
        ///
        /// ////////////////////////////////////////////////////////////////////////
        /// ////////////////////////////////////////////////////////////////////////
        /// ////////////////////////////////////////////////////////////////////////
        /// ////////////////////////////////////////////////////////////////////////
        /// ////////////////////////////////////////////////////////////////////////
        /// ////////////////////////////////////////////////////////////////////////
        /// ////////////////////////////////////////////////////////////////////////
        /// ////////////////////////////////////////////////////////////////////////
        /// ////////////////////////////////////////////////////////////////////////


        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            setPriceAndAddListbox(500.99, checkBox2);
        }


        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            setPriceAndAddListbox(550.50, checkBox3);

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

            setPriceAndAddListbox(600.99, checkBox4);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

            setPriceAndAddListbox(750.00, checkBox5);
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

            setPriceAndAddListbox(500.00, checkBox6);
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

            setPriceAndAddListbox(750.00, checkBox7);
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

            setPriceAndAddListbox(700.00, checkBox8);
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

            setPriceAndAddListbox(850.00, checkBox9);
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {

            setPriceAndAddListbox(450.00, checkBox10);
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {

            setPriceAndAddListbox(650.00, checkBox11);
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {

            setPriceAndAddListbox(575.00, checkBox12);
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {

            setPriceAndAddListbox(565.50, checkBox13);
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {

            setPriceAndAddListbox(580.50, checkBox14);
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {

            setPriceAndAddListbox(600.00, checkBox15);
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {

            setPriceAndAddListbox(545.00, checkBox16);
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            setPriceAndAddListbox(505.00, checkBox17);
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            setPriceAndAddListbox(490.00, checkBox18);
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            setPriceAndAddListbox(555.00, checkBox19);
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            setPriceAndAddListbox(615.00, checkBox20);
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            setPriceAndAddListbox(605.00, checkBox21);
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (FoodBundleAradiobtn.Checked == true)
            {
                posdb_connect.pos_sql = "INSERT INTO salesTbl (product_name," +
                    "product_quantity_per_transaction, product_price, discount_option," +
                    "discount_amount_per_transaction, discounted_amount_per_transaction," +
                    "summary_total_quantity, summary_total_disc_given,summary_total_discounted_amount, " +
                    "terminal_no, time_date, emp_id)VALUES('Food Bundle A', '" +
                    quantityTxtBox.Text + "', '" + priceTxtBox.Text + "', '" + FoodBundleAradiobtn.Text + "', '" +
                    discountAmountTxtBox.Text + "', '" + discountedAmounttxtBox.Text + "', '" + totalQtyTxtBox.Text +
                    "', '" + discountAmountTxtBox.Text + "', '" + discountedAmounttxtBox.Text + "', '" + terminal_noLbl.Text + "', '" +
                        time_dateLbl.Text + "', '" + emp_idLbl.Text + "')";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterInsert();
                cleartextboxes();
            }
            else if (FoodBundleBradiobtn.Checked == true)
            {
                posdb_connect.pos_sql = "INSERT INTO salesTbl (product_name," +
                     "product_quantity_per_transaction, product_price, discount_option," +
                     "discount_amount_per_transaction, discounted_amount_per_transaction," +
                     "summary_total_quantity, summary_total_disc_given,summary_total_discounted_amount, " +
                     "terminal_no, time_date, emp_id)VALUES('Food Bundle B', '" +
                     quantityTxtBox.Text + "', '" + priceTxtBox.Text + "', '" + FoodBundleBradiobtn.Text + "', '" +
                     discountAmountTxtBox.Text + "', '" + discountedAmounttxtBox.Text + "', '" + totalQtyTxtBox.Text +
                     "', '" + discountAmountTxtBox.Text + "', '" + discountedAmounttxtBox.Text + "', '" + terminal_noLbl.Text + "', '" +
                        time_dateLbl.Text + "', '" + emp_idLbl.Text + "')";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterInsert();
                cleartextboxes();
            }
            else
                MessageBox.Show("No selected discount option");
        }

        /// ////////////////////////////////////////////////////////////////////////
    }
}
