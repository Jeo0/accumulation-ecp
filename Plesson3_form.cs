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
        // Declare global variables for the camera
        private FilterInfoCollection videoDevices; // List of available webcams
        private VideoCaptureDevice videoSource;   // Selected webcam
        private bool scanning = false;
        private System.Windows.Forms.Timer timer;

        // codes for declaring a variables that is accessible to the whole
        // form and can be access for one object to another
        private double total_amount = 0;
        private int total_qty = 0;

        // 
        string imagePath = "E:\\school\\3rdyr\\2ndsem\\ecp\\midterm\\accumulation\\newnew\\projectNamin\\images\\images-lesson3(POS 2)\\";

        public Plesson3_form()
        {
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




        /// <summary>
        /// //////////////////////////////////////////
        /// //////////////////////////////////////////
        /// //////////////////////////////////////////
        /// //////////////////////////////////////////
        /// //////////////////////////////////////////
        /// //////////////////////////////////////////
        /// //////////////////////////////////////////
        /// //////////////////////////////////////////
        /// //////////////////////////////////////////
        /// //////////////////////////////////////////
        /// //////////////////////////////////////////
        /// qrcode functions
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

        /// <summary>
        /// ////////////////////////////////////////////////
        /// ////////////////////////////////////////////////
        /// ////////////////////////////////////////////////
        /// ////////////////////////////////////////////////
        /// ////////////////////////////////////////////////
        /// ////////////////////////////////////////////////
        /// ////////////////////////////////////////////////
        /// ////////////////////////////////////////////////
        /// ////////////////////////////////////////////////
        /// ////////////////////////////////////////////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

            //codes for inserting image to a picturebox
            //string variable = "C:\\Users\\Jude\\Downloads\\MIDTERMS_3RD YEAR_2ND SEM\\images_d\\";
            pizzaPic1.Image = System.Drawing.Image.FromFile(imagePath + "d1.jfif");
            pizzaPic2.Image = System.Drawing.Image.FromFile(imagePath + "d2.jfif");
            pizzaPic3.Image = System.Drawing.Image.FromFile(imagePath + "d3.jfif");
            pizzaPic4.Image = System.Drawing.Image.FromFile(imagePath + "d4.jfif");
            pizzaPic5.Image = System.Drawing.Image.FromFile(imagePath + "d5.jfif");
            pizzaPic6.Image = System.Drawing.Image.FromFile(imagePath + "d6.jfif");
            pizzaPic7.Image = System.Drawing.Image.FromFile(imagePath + "d7.jfif");
            pizzaPic8.Image = System.Drawing.Image.FromFile(imagePath + "d8.jfif");
            pizzaPic9.Image = System.Drawing.Image.FromFile(imagePath + "d9.jfif");
            pizzaPic10.Image = System.Drawing.Image.FromFile(imagePath + "d10.jfif");
            pizzaPic11.Image = System.Drawing.Image.FromFile(imagePath + "d11.jfif");
            pizzaPic12.Image = System.Drawing.Image.FromFile(imagePath + "d12.jfif");
            pizzaPic13.Image = System.Drawing.Image.FromFile(imagePath + "d13.jfif");
            pizzaPic14.Image = System.Drawing.Image.FromFile(imagePath + "d14.jfif");
            pizzaPic15.Image = System.Drawing.Image.FromFile(imagePath + "d15.jfif");
            pizzaPic16.Image = System.Drawing.Image.FromFile(imagePath + "d16.jfif");
            pizzaPic17.Image = System.Drawing.Image.FromFile(imagePath + "d17.jfif");
            pizzaPic18.Image = System.Drawing.Image.FromFile(imagePath + "d18.jfif");
            pizzaPic19.Image = System.Drawing.Image.FromFile(imagePath + "d19.jfif");
            pizzaPic20.Image = System.Drawing.Image.FromFile(imagePath + "d20.jfif");

            //codes to disable to checkboxes
            //A
            friedchickenCheckBox.Enabled = false;
            friesCheckbox.Enabled = false;
            cokeCheckBox.Enabled = false;
            sidedishCheckBox.Enabled = false;
            specialpizzaCheckbox.Enabled = false;
            //B
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
        /// ////////////////////////////////////////////////
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
            // string imagePath = "E:\\school\\3rdyr\\2ndsem\\ecp\\midterm\\accumulation\\newnew\\projectNamin\\images\\images-lesson3(POS 2)\\";
            double price;
            //code for changing the form background
            this.BackColor = Color.LightCyan;
            //code for food bundle B not to be selected
            FoodBundleBradiobtn.Checked = false;
            //inserting image inside picturebox
            displayPictureBox.Image = System.Drawing.Image.FromFile(imagePath + "fb1.jfif");
            //codes to check the checkboxes for A
            friedchickenCheckBox.Checked = true;
            friesCheckbox.Checked = true;
            cokeCheckBox.Checked = true;
            sidedishCheckBox.Checked = true;
            specialpizzaCheckbox.Checked = true;
            //codes to uncheck checkboxes for B
            halohaloCheckbox.Checked = false;
            chickenCheckbox.Checked = false;
            carbonaraCheckBox.Checked = false;
            famfriesCheckBox.Checked = false;
            hawaiianCheckBox.Checked = false;

            //codes for displaying data inside the textboxes
            priceTxtBox.Text = "1,000.00";
            discountAmountTxtBox.Text = "200.00";
            price = Convert.ToDouble(priceTxtBox.Text);
            //codes for inserting data inside the listbox
            displayListBox.Items.Add(FoodBundleAradiobtn.Text + " " + priceTxtBox.Text);
            displayListBox.Items.Add(" Discount Amount: " + " " + discountAmountTxtBox.Text);

            quantityTxtBox.Text = "0";
            quantityTxtBox.Focus();

        }

        private void FoodBundleBradiobtn_CheckedChanged(object sender, EventArgs e)
        {
            displayListBox.Items.Clear();
            double price;
            //code for changing the form background
            this.BackColor = Color.LightBlue;
            //code for food bundle B not to be selected
            FoodBundleAradiobtn.Checked = false;
            //inserting image inside picturebox
            displayPictureBox.Image = System.Drawing.Image.FromFile(imagePath + "fb2.jfif");
            //codes to check the checkboxes for A
            friedchickenCheckBox.Checked = false;
            friesCheckbox.Checked = false;
            cokeCheckBox.Checked = false;
            sidedishCheckBox.Checked = false;
            specialpizzaCheckbox.Checked = false;
            //codes to uncheck checkboxes for B
            halohaloCheckbox.Checked = true;
            chickenCheckbox.Checked = true;
            carbonaraCheckBox.Checked = true;
            famfriesCheckBox.Checked = true;
            hawaiianCheckBox.Checked = true;

            //codes for displaying data inside the textboxes
            priceTxtBox.Text = "1,299.00";
            discountAmountTxtBox.Text = "194.85";

            //codes for inserting data inside the listbox
            displayListBox.Items.Add(FoodBundleBradiobtn.Text + " " + priceTxtBox.Text);
            displayListBox.Items.Add(" Discount Amount: " + " " + discountAmountTxtBox.Text);

            quantityTxtBox.Text = "0";
            quantityTxtBox.Focus();
        }


        /// <summary>
        /// /////////////////////////////////////////////////////////
        /// /////////////////////////////////////////////////////////
        /// /////////////////////////////////////////////////////////
        /// /////////////////////////////////////////////////////////
        /// /////////////////////////////////////////////////////////
        /// /////////////////////////////////////////////////////////
        /// /////////////////////////////////////////////////////////
        /// /////////////////////////////////////////////////////////
        /// /////////////////////////////////////////////////////////
        /// /////////////////////////////////////////////////////////
        /// /////////////////////////////////////////////////////////
        /// /////////////////////////////////////////////////////////
        /// /////////////////////////////////////////////////////////
        /// below shows the unique buttons
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void calcbills_Click_1(object sender, EventArgs e)
        {
            double cash_given = 0, change = 0, total_amountPaid = 0;
            try
            {
                total_amountPaid = Convert.ToDouble(totalBillsTxtBox.Text);
            }
            catch (Exception asd)
            {
                MessageBox.Show(asd.Message);
                totalBillsTxtBox.Focus();
            }

            try
            {
                cash_given = Convert.ToDouble(cashGivenTxtBox.Text);
            }
            catch (Exception asd)
            {
                MessageBox.Show(asd.Message);
                cashGivenTxtBox.Focus();
            }

            try
            {
                change = cash_given - total_amountPaid;
            }
            catch (Exception asd)
            {
                MessageBox.Show(asd.Message);
            }

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
            //codes for calling the other form connected to the current form
            Plesson3_printform print = new Plesson3_printform();

            //codes for displaying the contents of the listbox from other form to the
            //current form.
            print.printDisplayListBox.Items.AddRange(this.displayListBox.Items);
            //code for displaying the other form
            print.Show();

        }

        private void removebtn_Click(object sender, EventArgs e)
        {
            //codes to remove selected data inside the listbox
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
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;
            checkBox17.Checked = false;
            checkBox18.Checked = false;
            checkBox19.Checked = false;
            checkBox20.Checked = false;
            checkBox21.Checked = false;

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



        /// <summary>
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
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void setPriceAndAddListbox(double price, object namename){

          discountAmountTxtBox.Text = "0.00";
          priceTxtBox.Text = Convert.ToString(price);

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
