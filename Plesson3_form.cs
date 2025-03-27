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

namespace lesson3___example3
{
    public partial class Plesson3_form : Form
    {

        /// //////////////////////////////////////////
        /// //////////////////////////////////////////
        /// //////////////////////////////////////////
        /// //////////////////////////////////////////
        /// //////////////////////////////////////////
        /// //////////////////////////////////////////
        ///
        /// globals
        ///
        /// //////////////////////////////////////////
        /// //////////////////////////////////////////
        /// //////////////////////////////////////////
        /// //////////////////////////////////////////
        /// //////////////////////////////////////////

        // Declare global variables for the camera
        private FilterInfoCollection videoDevices; // List of available webcams
        private VideoCaptureDevice videoSource;   // Selected webcam
        private bool scanning = false;
        private System.Windows.Forms.Timer timer;

        // form and can be access for one object to another
        private double total_amount = 0;
        private int total_qty = 0;

        // change this if on another system
        string variable = "C:\\Users\\Jude\\Downloads\\MIDTERMS_3RD YEAR_2ND SEM\\images_d\\";
       // string imagePath = "E:\\school\\3rdyr\\2ndsem\\ecp\\midterm\\accumulation\\newnew\\projectNamin\\images\\images-lesson3(POS 2)\\";


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


        public Plesson3_form() {
            InitializeComponent();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 500; // Set interval to 500ms
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e) {
            if (scanning) {
                ScanQRCode();
            }
        }




        /// //////////////////////////////////////////
        /// //////////////////////////////////////////
        /// //////////////////////////////////////////
        /// //////////////////////////////////////////
        /// //////////////////////////////////////////
        /// //////////////////////////////////////////
        ///
        /// qrcode functions
        ///
        /// //////////////////////////////////////////
        /// //////////////////////////////////////////
        /// //////////////////////////////////////////
        /// //////////////////////////////////////////
        /// //////////////////////////////////////////


        private void ScanQRCode() {
            if (qrbox.Image != null) {
                // with the help from chatgpt
                try {
                    // Create a BarcodeReader to decode the image
                    BarcodeReader reader = new BarcodeReader();
                    Result result = reader.Decode((Bitmap)qrbox.Image);

                    if (result != null) {
                        // Safely update the UI (Invoke required because QRBOX.Image and Cash_renderedtxtbox are UI controls)
                        this.Invoke((Action)(() => {
                            cashGivenTxtBox.Text = result.Text; // Display the scanned amount
                            StopCamera(); // Stop scanning after a successful read
                        }));
                    }
                }

                catch (Exception ex) {
                    // Handle any exceptions during decoding
                    Console.WriteLine("Error scanning QR code: " + ex.Message);
                }

            }
        }

        private void StartCamera() {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (videoDevices.Count > 0) {
                videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString); // Select first camera
                videoSource.NewFrame += new NewFrameEventHandler(Video_NewFrame);
                videoSource.Start();
                scanning = true;
            }
            else {
                MessageBox.Show("No camera found!");
            }
        }

        private void Video_NewFrame(object sender, NewFrameEventArgs eventArgs) {
            // with the help from chatgpt
            try {
                // Update the QR code box image in the UI thread
                this.Invoke((Action)(() =>
                {
                    qrbox.Image = (Bitmap)eventArgs.Frame.Clone();
                }));
            }
            catch (Exception ex) {
                Console.WriteLine("Error handling new frame: " + ex.Message);
            }
        }

        private void StopCamera() {
            if (videoSource != null && videoSource.IsRunning) {
                videoSource.SignalToStop();
                videoSource = null;
                scanning = false;
            }
        }

        private void scanqrbtn_Click(object sender, EventArgs e) {
            // Reset the picture box
            if (qrbox.Image != null) {
                qrbox.Image.Dispose();
                qrbox.Image = null;
            }

            StopCamera();
            StartCamera();
            timer.Start();

            newbtn.Enabled = true;
        }

        /// ////////////////////////////////////////////////
        /// ////////////////////////////////////////////////
        /// ////////////////////////////////////////////////
        /// ////////////////////////////////////////////////
        /// ////////////////////////////////////////////////
        ///
        /// code proper
        ///
        /// ////////////////////////////////////////////////
        /// ////////////////////////////////////////////////
        /// ////////////////////////////////////////////////
        /// ////////////////////////////////////////////////
        /// ////////////////////////////////////////////////

        private void Form1_Load(object sender, EventArgs e)
        {
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
            for (int iii=0; iii < pictureboxArr.Length; iii++){
              pictureboxArr[iii].Image = System.Drawing.Image.FromFile(variable + "d" + Convert.ToString(iii+1) + ".jfif");
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
        
        private void FoodBundleAradiobtn_CheckedChanged(object sender, EventArgs e) {
            displayListBox.Items.Clear();
            double price;

            this.BackColor = Color.LightCyan;       // for changing the form background
            FoodBundleBradiobtn.Checked = false;    // for food bundle B not to be selected

            //inserting image inside picturebox
            displayPictureBox.Image = System.Drawing.Image.FromFile(variable + "fb1.jfif");

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

        private void FoodBundleBradiobtn_CheckedChanged(object sender, EventArgs e) {
            displayListBox.Items.Clear();
            double price;

            this.BackColor = Color.LightBlue;           // for changing the form background
            FoodBundleAradiobtn.Checked = false;        // for food bundle B not to be selected

            displayPictureBox.Image = System.Drawing.Image.FromFile(variable + "fb2.jfif");        //inserting image inside picturebox

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

        private void calcbills_Click_1(object sender, EventArgs e) {
            double cash_given = 0, change = 0, total_amountPaid = 0;

            // for total amount paid bills
            try {
                total_amountPaid = Convert.ToDouble(totalBillsTxtBox.Text);
            } catch (Exception asd) {
                MessageBox.Show(asd.Message);
                totalBillsTxtBox.Focus();
            }

            // cash given
            try {
                cash_given = Convert.ToDouble(cashGivenTxtBox.Text);
            } catch (Exception asd) {
                MessageBox.Show(asd.Message);
                cashGivenTxtBox.Focus();
            }

            // change
            try {
                change = cash_given - total_amountPaid;
            } catch (Exception asd) {
                MessageBox.Show(asd.Message);
            }

            // process
            changeTxtBox.Text = change.ToString("n");                                 // safe
            displayListBox.Items.Add("Total Bills:  " + totalBillsTxtBox.Text);
            displayListBox.Items.Add("Cash Given:  " + cashGivenTxtBox.Text);
            displayListBox.Items.Add("Total No. of Items:  " + totalQtyTxtBox.Text);  // safe

            if (cash_given < total_amountPaid) {
                MessageBox.Show("Insufficient cash! Please enter an amount greater than or equal to the total bill.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Stop further execution
            }
        }


        private void printbtn_Click(object sender, EventArgs e) {
            // codes for calling the other form connected to the current form
            Plesson3_printform print = new Plesson3_printform();

            // codes for displaying the contents of the listbox from other form to the
            // current form.
            print.printDisplayListBox.Items.AddRange(this.displayListBox.Items);

            // code for displaying the other form
            print.Show();

        }


        private void removebtn_Click(object sender, EventArgs e) {
            // codes to remove selected data inside the listbox
            displayListBox.Items.RemoveAt(displayListBox.SelectedIndex);
        }


        private void exitbtn_Click(object sender, EventArgs e) {
            this.Close();
        }


        private void newbtn_Click(object sender, EventArgs e) {

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
            foreach (System.Windows.Forms.CheckBox iii in checkboxArr){
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
            try {
                if (!string.IsNullOrWhiteSpace(priceTxtBox.Text))
                    price = Convert.ToDouble(priceTxtBox.Text);
            }
            catch (Exception asd) {
                MessageBox.Show(asd.Message);
                priceTxtBox.Focus();
            }


            try {
                if (!string.IsNullOrWhiteSpace(quantityTxtBox.Text))
                    qty = Convert.ToInt32(quantityTxtBox.Text);
            }
            catch (Exception asd) {
                MessageBox.Show(asd.Message);
                quantityTxtBox.Focus();
            }


            try {
                if (!string.IsNullOrWhiteSpace(discountAmountTxtBox.Text))
                    discount_amount = Convert.ToDouble(discountAmountTxtBox.Text);
            }
            catch (Exception asd) {
                MessageBox.Show(asd.Message);
                discountAmountTxtBox.Focus();
            }

            // Prevent negative calculations
            if (qty > 0) {
                discounted_amount = (price * qty) - (discount_amount * qty);
                total_qty += qty;
                total_amount += discounted_amount;
            }
            else {
                discounted_amount = 0;
            }

            // Display results
            totalQtyTxtBox.Text = total_qty.ToString();
            totalBillsTxtBox.Text = total_amount.ToString("n");
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
        
        private void setPriceAndAddListbox(double price, object namename){

          discountAmountTxtBox.Text = "0.00";
          priceTxtBox.Text = "P " + Convert.ToString(price);
          //priceTxtBox.Text = price.ToString("n"); // format to PHP

          // option 1: check before typecasting
          if(namename is System.Windows.Forms.CheckBox checkBox){
            displayListBox.Items.Add(checkBox.Text + " " + priceTxtBox.Text);
          }

          // option 2: direct casting assuming that namename is always a checkbox
          //displayListBox.Items.Add((System.Windows.Forms.CheckBox)namename.Text);

          quantityTxtBox.Text = "0";
          quantityTxtBox.Focus();

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e) {
            setPriceAndAddListbox(500.99, checkBox2);
        }


        private void checkBox3_CheckedChanged(object sender, EventArgs e) {
          setPriceAndAddListbox(550.50,checkBox3);

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e) {

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
        /// ////////////////////////////////////////////////////////////////////////
        /// ////////////////////////////////////////////////////////////////////////
        /// ////////////////////////////////////////////////////////////////////////
        /// ////////////////////////////////////////////////////////////////////////
        /// ////////////////////////////////////////////////////////////////////////
        /// ////////////////////////////////////////////////////////////////////////
        /// ////////////////////////////////////////////////////////////////////////
        /// ////////////////////////////////////////////////////////////////////////
        /// ////////////////////////////////////////////////////////////////////////


    }
}
