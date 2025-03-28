using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing.QrCode;
using ZXing.Windows.Compatibility;
using System.Diagnostics;

namespace New_POS_Application
{
    public partial class Pquiz1_form_replica : Form
    {
        // GLOBAL VARIABLES
        double price1 = 0.0;
        double price2 = 0.0;
        double price3 = 0.0;
        double price4 = 0.0;
        double price5 = 0.0;
        double price6 = 0.0;
        double price7 = 0.0;
        double price8 = 0.0;
        double price9 = 0.0;
        double price10 = 0.0;
        double price11 = 0.0;
        double price12 = 0.0;
        double price13 = 0.0;
        double price14 = 0.0;
        double price15 = 0.0;
        double price16 = 0.0;
        double price17 = 0.0;
        double price18 = 0.0;
        double price19 = 0.0;
        double price20 = 0.0;
        string mealType;
        private bool isNewOrder = false;

        // summarize total group
        int summary_total_qty = 0;
        double summary_total_discount = 0, summary_total_discounted = 0;

        // for lesson 3 onwards
        private double total_amount = 0;
        private int total_qty = 0;

        String baseString = "C:\\Users\\Jude\\Downloads\\MIDTERMS_3RD YEAR_2ND SEM\\quiz1_images"; // change accordingly

        private System.Windows.Forms.Timer timer;
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        private bool scanning = false; // Default to false


        public Pquiz1_form_replica()
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
                            cash_renderedtxtbox.Text = result.Text; // Display the scanned amount
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

        //codes for accessing the class created earlier
        Variables variables = new Variables();


        //function codes for putting Text value property of item and price textbox
        private void displayTxtbox(string itemname, string price)
        {
            itemnametxtbox.Text = itemname;
            pricetextbox.Text = price;
        }
        //function codes for clearing and putting the cursor inside the qunaittiy textbox
        private void quantityTxtbox()
        {
            quantitytxtbox.Enabled = true;
            quantitytxtbox.Focus();
        }

        private void setState()
        {
            // disable 
            // buttons
            calcbtn.Enabled = false;

            // discounts
            senior_discount_button.Enabled = false;
            with_discountCard_button.Enabled = false;
            employee_discount_button.Enabled = false;
            no_discount_button.Enabled = false;
        }
        //Function in updating labels
        private void UpdateLabels(string whatPack)
        {
            namelbl1.Text = whatPack + " 1";
            namelbl2.Text = whatPack + " 2";
            namelbl3.Text = whatPack + " 3";
            namelbl4.Text = whatPack + " 4";
            namelbl5.Text = whatPack + " 5";
            namelbl6.Text = whatPack + " 6";
            namelbl7.Text = whatPack + " 7";
            namelbl8.Text = whatPack + " 8";
            namelbl9.Text = whatPack + " 9";
            namelbl10.Text = whatPack + " 10";
            namelbl11.Text = whatPack + " 11";
            namelbl12.Text = whatPack + " 12";
            namelbl13.Text = whatPack + " 13";
            namelbl14.Text = whatPack + " 14";
            namelbl15.Text = whatPack + " 15";
            namelbl16.Text = whatPack + " 16";
            namelbl17.Text = whatPack + " 17";
            namelbl18.Text = whatPack + " 18";
            namelbl19.Text = whatPack + " 19";
            namelbl20.Text = whatPack + " 20";
        }
        // Function to update meal type based on customer selection
        private void setMealType(string type)
        {
            mealType = type;
        }
        private void CN_picbox()
        {
            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
            pictureBox5.Enabled = true;
            pictureBox6.Enabled = true;
            pictureBox7.Enabled = true;
            pictureBox8.Enabled = true;
            pictureBox9.Enabled = true;
            pictureBox9.Enabled = true;
            pictureBox10.Enabled = true;
            pictureBox11.Enabled = true;
            pictureBox12.Enabled = true;
            pictureBox13.Enabled = true;
            pictureBox14.Enabled = true;
            pictureBox15.Enabled = true;
            pictureBox16.Enabled = true;
            pictureBox17.Enabled = true;
            pictureBox18.Enabled = true;
            pictureBox19.Enabled = true;
            pictureBox20.Enabled = true;
        }
        private void pricelabel()
        {

            pricelbl1.Text = Convert.ToString(price1);
            pricelbl2.Text = Convert.ToString(price2);
            pricelbl3.Text = Convert.ToString(price3);
            pricelbl4.Text = Convert.ToString(price4);
            pricelbl5.Text = Convert.ToString(price5);
            pricelbl6.Text = Convert.ToString(price10);
            pricelbl7.Text = Convert.ToString(price9);
            pricelbl8.Text = Convert.ToString(price8);
            pricelbl9.Text = Convert.ToString(price7);
            pricelbl10.Text = Convert.ToString(price6);
            pricelbl11.Text = Convert.ToString(price15);
            pricelbl12.Text = Convert.ToString(price14);
            pricelbl13.Text = Convert.ToString(price13);
            pricelbl14.Text = Convert.ToString(price12);
            pricelbl15.Text = Convert.ToString(price11);
            pricelbl16.Text = Convert.ToString(price20);
            pricelbl17.Text = Convert.ToString(price19);
            pricelbl18.Text = Convert.ToString(price18);
            pricelbl19.Text = Convert.ToString(price17);
            pricelbl20.Text = Convert.ToString(price16);
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = Color.YellowGreen;
            this.Text = "Point of Sale Interface";

            // disable all 
            itemnametxtbox.Enabled = false;
            pricetextbox.Enabled = false;
            discountedtxtbox.Enabled = false;
            quantitytxtbox.Enabled = false;
            discounttxtbox.Enabled = false;
            discountedtxtbox.Enabled = false;

            // summary box group
            total_quantity_txtbox.Enabled = false;
            total_discount_txtbox.Enabled = false;
            total_discounted_txtbox.Enabled = false;

            // cash renedered x change
            changetxtbox.Enabled = false;
            cash_renderedtxtbox.Enabled = false;

            // discounts
            senior_discount_button.Enabled = false;
            with_discountCard_button.Enabled = false;
            employee_discount_button.Enabled = false;
            no_discount_button.Enabled = false;

            // buttons disabled except exit button 
            calcbtn.Enabled = false;
            newbtn.Enabled = false;
            cancelbtn.Enabled = false;
            exitbtn.Enabled = true;

        }
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dinnerBtn_Click(object sender, EventArgs e)
        {
            setMealType("Dinner");
            price1 = 150.00;
            price2 = 200.00;
            price3 = 250.00;
            price4 = 195.00;
            price5 = 275.00;
            price6 = 150.00;
            price7 = 175.00;
            price8 = 200.00;
            price9 = 150.00;
            price10 = 100.00;
            price11 = 125.00;
            price12 = 300.00;
            price13 = 125.00;
            price14 = 150.00;
            price15 = 165.00;
            price16 = 135.00;
            price17 = 155.00;
            price18 = 120.00;
            price19 = 250.00;
            price20 = 130.00;

            String specificContext = "\\dinner\\d";
            String whatPack = "Dinner Pack";
            pictureBox1.Image = Image.FromFile(baseString + specificContext + "1.jfif");
            pictureBox2.Image = Image.FromFile(baseString + specificContext + "2.jfif");
            pictureBox3.Image = Image.FromFile(baseString + specificContext + "3.jfif");
            pictureBox4.Image = Image.FromFile(baseString + specificContext + "4.jfif");
            pictureBox5.Image = Image.FromFile(baseString + specificContext + "5.jfif");
            pictureBox6.Image = Image.FromFile(baseString + specificContext + "6.jfif");
            pictureBox7.Image = Image.FromFile(baseString + specificContext + "7.jfif");
            pictureBox8.Image = Image.FromFile(baseString + specificContext + "8.jfif");
            pictureBox9.Image = Image.FromFile(baseString + specificContext + "9.jfif");
            pictureBox10.Image = Image.FromFile(baseString + specificContext + "10.jfif");
            pictureBox11.Image = Image.FromFile(baseString + specificContext + "11.jfif");
            pictureBox12.Image = Image.FromFile(baseString + specificContext + "12.jfif");
            pictureBox13.Image = Image.FromFile(baseString + specificContext + "13.jfif");
            pictureBox14.Image = Image.FromFile(baseString + specificContext + "14.jfif");
            pictureBox15.Image = Image.FromFile(baseString + specificContext + "15.jfif");
            pictureBox16.Image = Image.FromFile(baseString + specificContext + "16.jfif");
            pictureBox17.Image = Image.FromFile(baseString + specificContext + "17.jfif");
            pictureBox18.Image = Image.FromFile(baseString + specificContext + "18.jfif");
            pictureBox19.Image = Image.FromFile(baseString + specificContext + "19.jfif");
            pictureBox20.Image = Image.FromFile(baseString + specificContext + "20.jfif");
            UpdateLabels(whatPack);
            pricelabel();
        }
        private void lunchBtn_Click(object sender, EventArgs e)
        {
            setMealType("Lunch");
            price1 = 189.00;
            price2 = 100.00;
            price3 = 120.00;
            price4 = 175.00;
            price5 = 165.00;
            price6 = 180.00;
            price7 = 295.00;
            price8 = 200.00;
            price9 = 250.00;
            price10 = 175.00;
            price11 = 190.00;
            price12 = 205.00;
            price13 = 100.00;
            price14 = 195.00;
            price15 = 215.00;
            price16 = 199.00;
            price17 = 169.00;
            price18 = 190.00;
            price19 = 315.00;
            price20 = 225.00;

            String specificContext = "\\lunch\\l";
            String whatPack = "Lunch Pack";
            pictureBox1.Image = Image.FromFile(baseString + specificContext + "1.jfif");
            pictureBox2.Image = Image.FromFile(baseString + specificContext + "2.jfif");
            pictureBox3.Image = Image.FromFile(baseString + specificContext + "3.jfif");
            pictureBox4.Image = Image.FromFile(baseString + specificContext + "4.jfif");
            pictureBox5.Image = Image.FromFile(baseString + specificContext + "5.jfif");
            pictureBox6.Image = Image.FromFile(baseString + specificContext + "6.jfif");
            pictureBox7.Image = Image.FromFile(baseString + specificContext + "7.jfif");
            pictureBox8.Image = Image.FromFile(baseString + specificContext + "8.jfif");
            pictureBox9.Image = Image.FromFile(baseString + specificContext + "9.jfif");
            pictureBox10.Image = Image.FromFile(baseString + specificContext + "10.jfif");
            pictureBox11.Image = Image.FromFile(baseString + specificContext + "11.jfif");
            pictureBox12.Image = Image.FromFile(baseString + specificContext + "12.jfif");
            pictureBox13.Image = Image.FromFile(baseString + specificContext + "13.jfif");
            pictureBox14.Image = Image.FromFile(baseString + specificContext + "14.jfif");
            pictureBox15.Image = Image.FromFile(baseString + specificContext + "15.jfif");
            pictureBox16.Image = Image.FromFile(baseString + specificContext + "16.jfif");
            pictureBox17.Image = Image.FromFile(baseString + specificContext + "17.jfif");
            pictureBox18.Image = Image.FromFile(baseString + specificContext + "18.jfif");
            pictureBox19.Image = Image.FromFile(baseString + specificContext + "19.jfif");
            pictureBox20.Image = Image.FromFile(baseString + specificContext + "20.jfif");
            UpdateLabels(whatPack);
            pricelabel();

        }

        private void dessertsBtn_Click(object sender, EventArgs e)
        {
            setMealType("Dessert");
            price1 = 250.00;
            price2 = 200.00;
            price3 = 285.00;
            price4 = 275.00;
            price5 = 300.00;
            price6 = 290.00;
            price7 = 195.00;
            price8 = 399.00;
            price9 = 400.00;
            price10 = 415.00;
            price11 = 350.00;
            price12 = 388.00;
            price13 = 265.00;
            price14 = 375.00;
            price15 = 300.00;
            price16 = 220.00;
            price17 = 425.00;
            price18 = 365.00;
            price19 = 395.00;
            price20 = 210.00;

            String specificContext = "\\dessert\\s";
            String whatPack = "Dessert Pack";
            pictureBox1.Image = Image.FromFile(baseString + specificContext + "1.jfif");
            pictureBox2.Image = Image.FromFile(baseString + specificContext + "2.jfif");
            pictureBox3.Image = Image.FromFile(baseString + specificContext + "3.jfif");
            pictureBox4.Image = Image.FromFile(baseString + specificContext + "4.jfif");
            pictureBox5.Image = Image.FromFile(baseString + specificContext + "5.jfif");
            pictureBox6.Image = Image.FromFile(baseString + specificContext + "6.jfif");
            pictureBox7.Image = Image.FromFile(baseString + specificContext + "7.jfif");
            pictureBox8.Image = Image.FromFile(baseString + specificContext + "8.jfif");
            pictureBox9.Image = Image.FromFile(baseString + specificContext + "9.jfif");
            pictureBox10.Image = Image.FromFile(baseString + specificContext + "10.jfif");
            pictureBox11.Image = Image.FromFile(baseString + specificContext + "11.jfif");
            pictureBox12.Image = Image.FromFile(baseString + specificContext + "12.jfif");
            pictureBox13.Image = Image.FromFile(baseString + specificContext + "13.jfif");
            pictureBox14.Image = Image.FromFile(baseString + specificContext + "14.jfif");
            pictureBox15.Image = Image.FromFile(baseString + specificContext + "15.jfif");
            pictureBox16.Image = Image.FromFile(baseString + specificContext + "16.jfif");
            pictureBox17.Image = Image.FromFile(baseString + specificContext + "17.jfif");
            pictureBox18.Image = Image.FromFile(baseString + specificContext + "18.jfif");
            pictureBox19.Image = Image.FromFile(baseString + specificContext + "19.jfif");
            pictureBox20.Image = Image.FromFile(baseString + specificContext + "20.jfif");
            UpdateLabels(whatPack);
            pricelabel();
        }

        private void breakfastBrn_Click(object sender, EventArgs e)
        {
            setMealType("Breakfast");
            price1 = 199.00;
            price2 = 300.00;
            price3 = 125.00;
            price4 = 95.00;
            price5 = 150.00;
            price6 = 225.00;
            price7 = 299.00;
            price8 = 120.00;
            price9 = 310.00;
            price10 = 155.00;
            price11 = 265.00;
            price12 = 325.00;
            price13 = 375.00;
            price14 = 140.00;
            price15 = 100.00;
            price16 = 230.00;
            price17 = 180.00;
            price18 = 190.00;
            price19 = 360.00;
            price20 = 105.00;

            String specificContext = "\\breakfast\\b";
            String whatPack = "Breakfast Pack";
            pictureBox1.Image = Image.FromFile(baseString + specificContext + "1.jfif");
            pictureBox2.Image = Image.FromFile(baseString + specificContext + "2.jfif");
            pictureBox3.Image = Image.FromFile(baseString + specificContext + "3.jfif");
            pictureBox4.Image = Image.FromFile(baseString + specificContext + "4.jfif");
            pictureBox5.Image = Image.FromFile(baseString + specificContext + "5.jfif");
            pictureBox6.Image = Image.FromFile(baseString + specificContext + "6.jfif");
            pictureBox7.Image = Image.FromFile(baseString + specificContext + "7.jfif");
            pictureBox8.Image = Image.FromFile(baseString + specificContext + "8.jfif");
            pictureBox9.Image = Image.FromFile(baseString + specificContext + "9.jfif");
            pictureBox10.Image = Image.FromFile(baseString + specificContext + "10.jfif");
            pictureBox11.Image = Image.FromFile(baseString + specificContext + "11.jfif");
            pictureBox12.Image = Image.FromFile(baseString + specificContext + "12.jfif");
            pictureBox13.Image = Image.FromFile(baseString + specificContext + "13.jfif");
            pictureBox14.Image = Image.FromFile(baseString + specificContext + "14.jfif");
            pictureBox15.Image = Image.FromFile(baseString + specificContext + "15.jfif");
            pictureBox16.Image = Image.FromFile(baseString + specificContext + "16.jfif");
            pictureBox17.Image = Image.FromFile(baseString + specificContext + "17.jfif");
            pictureBox18.Image = Image.FromFile(baseString + specificContext + "18.jfif");
            pictureBox19.Image = Image.FromFile(baseString + specificContext + "19.jfif");
            pictureBox20.Image = Image.FromFile(baseString + specificContext + "20.jfif");
            UpdateLabels(whatPack);
            pricelabel();
        }

        private void beveragesBtn_Click(object sender, EventArgs e)
        {
            setMealType("Beverages");
            price1 = 110.00;
            price2 = 89.00;
            price3 = 75.00;
            price4 = 100.00;
            price5 = 98.00;
            price6 = 85.00;
            price7 = 78.00;
            price8 = 120.00;
            price9 = 110.00;
            price10 = 80.00;
            price11 = 90.00;
            price12 = 99.00;
            price13 = 110.00;
            price14 = 77.00;
            price15 = 75.00;
            price16 = 92.00;
            price17 = 78.00;
            price18 = 125.00;
            price19 = 108.00;
            price20 = 89.00;

            String specificContext = "\\beverages\\";
            String whatPack = "Beverage Pack";
            pictureBox1.Image = Image.FromFile(baseString + specificContext + "beer1.jfif");
            pictureBox2.Image = Image.FromFile(baseString + specificContext + "beer2.jfif");
            pictureBox3.Image = Image.FromFile(baseString + specificContext + "beer3.jfif");
            pictureBox4.Image = Image.FromFile(baseString + specificContext + "beer4.jfif");
            pictureBox5.Image = Image.FromFile(baseString + specificContext + "beer5.jfif");
            pictureBox6.Image = Image.FromFile(baseString + specificContext + "juice1.jfif");
            pictureBox7.Image = Image.FromFile(baseString + specificContext + "juice2.jfif");
            pictureBox8.Image = Image.FromFile(baseString + specificContext + "juice3.jfif");
            pictureBox9.Image = Image.FromFile(baseString + specificContext + "juice4.jfif");
            pictureBox10.Image = Image.FromFile(baseString + specificContext + "juice5.jfif");
            pictureBox11.Image = Image.FromFile(baseString + specificContext + "soda1.jfif");
            pictureBox12.Image = Image.FromFile(baseString + specificContext + "soda2.jfif");
            pictureBox13.Image = Image.FromFile(baseString + specificContext + "soda3.jfif");
            pictureBox14.Image = Image.FromFile(baseString + specificContext + "soda4.jfif");
            pictureBox15.Image = Image.FromFile(baseString + specificContext + "tea1.jfif");
            pictureBox16.Image = Image.FromFile(baseString + specificContext + "tea2.jfif");
            pictureBox17.Image = Image.FromFile(baseString + specificContext + "tea3.jfif");
            pictureBox18.Image = Image.FromFile(baseString + specificContext + "tea5.jfif");
            pictureBox19.Image = Image.FromFile(baseString + specificContext + "tea6.jfif");
            pictureBox20.Image = Image.FromFile(baseString + specificContext + "tea7.jfif");
            UpdateLabels(whatPack);
            pricelabel();
        }

        private void coffeeBtn_Click(object sender, EventArgs e)
        {
            setMealType("Coffee");
            price1 = 55.00;
            price2 = 45.00;
            price3 = 70.00;
            price4 = 59.00;
            price5 = 54.00;
            price6 = 65.00;
            price7 = 110.00;
            price8 = 90.00;
            price9 = 66.00;
            price10 = 51.00;
            price11 = 99.00;
            price12 = 105.00;
            price13 = 90.00;
            price14 = 68.00;
            price15 = 105.00;
            price16 = 70.00;
            price17 = 115.00;
            price18 = 50.00;
            price19 = 88.00;
            price20 = 77.00;

            String specificContext = "\\coffee\\c";
            String whatPack = "Coffee Pack";
            pictureBox1.Image = Image.FromFile(baseString + specificContext + "1.jfif");
            pictureBox2.Image = Image.FromFile(baseString + specificContext + "2.jfif");
            pictureBox3.Image = Image.FromFile(baseString + specificContext + "3.jfif");
            pictureBox4.Image = Image.FromFile(baseString + specificContext + "4.jfif");
            pictureBox5.Image = Image.FromFile(baseString + specificContext + "5.jfif");
            pictureBox6.Image = Image.FromFile(baseString + specificContext + "6.jfif");
            pictureBox7.Image = Image.FromFile(baseString + specificContext + "7.jfif");
            pictureBox8.Image = Image.FromFile(baseString + specificContext + "8.jfif");
            pictureBox9.Image = Image.FromFile(baseString + specificContext + "9.jfif");
            pictureBox10.Image = Image.FromFile(baseString + specificContext + "10.jfif");
            pictureBox11.Image = Image.FromFile(baseString + specificContext + "11.jfif");
            pictureBox12.Image = Image.FromFile(baseString + specificContext + "12.jfif");
            pictureBox13.Image = Image.FromFile(baseString + specificContext + "13.jfif");
            pictureBox14.Image = Image.FromFile(baseString + specificContext + "14.jfif");
            pictureBox15.Image = Image.FromFile(baseString + specificContext + "15.jfif");
            pictureBox16.Image = Image.FromFile(baseString + specificContext + "16.jfif");
            pictureBox17.Image = Image.FromFile(baseString + specificContext + "17.jfif");
            pictureBox18.Image = Image.FromFile(baseString + specificContext + "18.jfif");
            pictureBox19.Image = Image.FromFile(baseString + specificContext + "19.jfif");
            pictureBox20.Image = Image.FromFile(baseString + specificContext + "20.jfif");
            UpdateLabels(whatPack);
            pricelabel();
        }
        /// <summary>
        /// behaviour for picture boxes
        /// </summary>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (mealType == "Lunch")
            {
                displayTxtbox("Lunch Pack", "189");
            }
            else if (mealType == "Dinner")
            {
                displayTxtbox("Dinner Pack 1", "150");
            }
            else if (mealType == "Dessert")
            {
                displayTxtbox("Dessert Pack 1", "250");
            }
            else if (mealType == "Breakfast")
            {
                displayTxtbox("Breakfast Pack 1", "199");
            }
            else if (mealType == "Beverages")
            {
                displayTxtbox("Beverage Pack 1", "110");
            }
            else if (mealType == "Coffee")
            {
                displayTxtbox("Coffee Pack 1", "55");
            }
            quantityTxtbox();
            setState();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (mealType == "Lunch")
            {
                displayTxtbox("Lunch Pack 2", "100");
            }
            else if (mealType == "Dinner")
            {
                displayTxtbox("Dinner Pack 2", "200");
            }
            else if (mealType == "Dessert")
            {
                displayTxtbox("Dessert Pack 2", "200");
            }
            else if (mealType == "Breakfast")
            {
                displayTxtbox("Breakfast Pack 2", "300");
            }
            else if (mealType == "Beverages")
            {
                displayTxtbox("Beverage Pack 2", "89");
            }
            else if (mealType == "Coffee")
            {
                displayTxtbox("Coffee Pack 2", "45");
            }
            quantityTxtbox();
            setState();

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (mealType == "Lunch")
            {
                displayTxtbox("Lunch Pack 3", "189");
            }
            else if (mealType == "Dinner")
            {
                displayTxtbox("Dinner Pack 3", "250");
            }
            else if (mealType == "Dessert")
            {
                displayTxtbox("Dessert Pack 3", "285");
            }
            else if (mealType == "Breakfast")
            {
                displayTxtbox("Breakfast Pack 3", "125");
            }
            else if (mealType == "Beverages")
            {
                displayTxtbox("Beverage Pack 3", "75");
            }
            else if (mealType == "Coffee")
            {
                displayTxtbox("Coffee Pack 3", "70");
            }

            quantityTxtbox();
            setState();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (mealType == "Lunch")
            {
                displayTxtbox("Lunch Pack 4", "175");
                
            }
            else if (mealType == "Dinner")
            {
                displayTxtbox("Dinner Pack 4", "195");
            }
            else if (mealType == "Dessert")
            {
                displayTxtbox("Dessert Pack 4", "275");
            }
            else if (mealType == "Breakfast")
            {
                displayTxtbox("Breakfast Pack 4", "95");
            }
            else if (mealType == "Beverages")
            {
                displayTxtbox("Beverage Pack 4", "100");
            }
            else if (mealType == "Coffee")
            {
                displayTxtbox("Coffee Pack 4", "59");
            }

            quantityTxtbox();
            setState();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (mealType == "Lunch")
            {
                displayTxtbox("Lunch Pack 5", "165");
            }
            else if (mealType == "Dinner")
            {
                displayTxtbox("Dinner Pack 5", "275");
            }
            else if (mealType == "Dessert")
            {
                displayTxtbox("Dessert Pack 5", "300");
            }
            else if (mealType == "Breakfast")
            {
                displayTxtbox("Breakfast Pack 5", "150");
            }
            else if (mealType == "Beverages")
            {
                displayTxtbox("Beverage Pack 5", "98");
            }
            else if (mealType == "Coffee")
            {
                displayTxtbox("Coffee Pack 5", "54");
            }

            quantityTxtbox();
            setState();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (mealType == "Lunch")
            {
                displayTxtbox("Lunch Pack 10", "180");
            }
            else if (mealType == "Dinner")
            {
                displayTxtbox("Dinner Pack 10", "150");
            }
            else if (mealType == "Dessert")
            {
                displayTxtbox("Dessert Pack 10", "290");
            }
            else if (mealType == "Breakfast")
            {
                displayTxtbox("Breakfast Pack 10", "255");
            }
            else if (mealType == "Beverages")
            {
                displayTxtbox("Beverage Pack 10", "85");
            }
            else if (mealType == "Coffee")
            {
                displayTxtbox("Coffee Pack 10", "65");
            }

            quantityTxtbox();
            setState();
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (mealType == "Lunch")
            {
                displayTxtbox("Lunch Pack 9", "295");
            }
            else if (mealType == "Dinner")
            {
                displayTxtbox("Dinner Pack 9", "175");
            }
            else if (mealType == "Dessert")
            {
                displayTxtbox("Dessert Pack 9", "195");
            }
            else if (mealType == "Breakfast")
            {
                displayTxtbox("Breakfast Pack 9", "299");
            }
            else if (mealType == "Beverages")
            {
                displayTxtbox("Beverage Pack 9", "78");
            }
            else if (mealType == "Coffee")
            {
                displayTxtbox("Coffee Pack 9", "110");
            }

            quantityTxtbox();
            setState();
        }
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (mealType == "Lunch")
            {
                displayTxtbox("Lunch Pack 8", "200");
            }
            else if (mealType == "Dinner")
            {
                displayTxtbox("Dinner Pack 8", "200");
            }
            else if (mealType == "Dessert")
            {
                displayTxtbox("Dessert Pack 8", "399");
            }
            else if (mealType == "Breakfast")
            {
                displayTxtbox("Breakfast Pack 8", "120");
            }
            else if (mealType == "Beverages")
            {
                displayTxtbox("Beverage Pack 8", "120");
            }
            else if (mealType == "Coffee")
            {
                displayTxtbox("Coffee Pack 8", "90");
            }

            quantityTxtbox();
            setState();
        }
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (mealType == "Lunch")
            {
                displayTxtbox("Lunch Pack 7", "250");
            }
            else if (mealType == "Dinner")
            {
                displayTxtbox("Dinner Pack 7", "150");
            }
            else if (mealType == "Dessert")
            {
                displayTxtbox("Dessert Pack 7", "400");
            }
            else if (mealType == "Breakfast")
            {
                displayTxtbox("Breakfast Pack 7", "310");
            }
            else if (mealType == "Beverages")
            {
                displayTxtbox("Beverage Pack 7", "78");
            }
            else if (mealType == "Coffee")
            {
                displayTxtbox("Coffee Pack 7", "66");
            }

            quantityTxtbox();
            setState();
        }
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (mealType == "Lunch")
            {
                displayTxtbox("Lunch Pack 6", "175");
            }
            else if (mealType == "Dinner")
            {
                displayTxtbox("Dinner Pack 6", "100");
            }
            else if (mealType == "Dessert")
            {
                displayTxtbox("Dessert Pack 6", "415");
            }
            else if (mealType == "Breakfast")
            {
                displayTxtbox("Breakfast Pack 6", "155");
            }
            else if (mealType == "Beverages")
            {
                displayTxtbox("Beverage Pack 6", "80");
            }
            else if (mealType == "Coffee")
            {
                displayTxtbox("Coffee Pack 6", "51");
            }

            quantityTxtbox();
            setState();
        }
        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (mealType == "Lunch")
            {
                displayTxtbox("Lunch Pack 15", "190");
            }
            else if (mealType == "Dinner")
            {
                displayTxtbox("Dinner Pack 15", "125");
            }
            else if (mealType == "Dessert")
            {
                displayTxtbox("Dessert Pack 15", "350");
            }
            else if (mealType == "Breakfast")
            {
                displayTxtbox("Breakfast Pack 15", "265");
            }
            else if (mealType == "Beverages")
            {
                displayTxtbox("Beverage Pack 15", "75");
            }
            else if (mealType == "Coffee")
            {
                displayTxtbox("Coffee Pack 15", "99");
            }

            quantityTxtbox();
            setState();
        }
        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (mealType == "Lunch")
            {
                displayTxtbox("Lunch Pack 14", "175");
            }
            else if (mealType == "Dinner")
            {
                displayTxtbox("Dinner Pack 14", "300");
            }
            else if (mealType == "Dessert")
            {
                displayTxtbox("Dessert Pack 14", "388");
            }
            else if (mealType == "Breakfast")
            {
                displayTxtbox("Breakfast Pack 14", "325");
            }
            else if (mealType == "Beverages")
            {
                displayTxtbox("Beverage Pack 14", "99");
            }
            else if (mealType == "Coffee")
            {
                displayTxtbox("Coffee Pack 14", "105");
            }

            quantityTxtbox();
            setState();
        }
        private void pictureBox13_Click(object sender, EventArgs e)
        {
            if (mealType == "Lunch")
            {
                displayTxtbox("Lunch Pack 13", "100");
            }
            else if (mealType == "Dinner")
            {
                displayTxtbox("Dinner Pack 13", "125");
            }
            else if (mealType == "Dessert")
            {
                displayTxtbox("Dessert Pack 13", "265");
            }
            else if (mealType == "Breakfast")
            {
                displayTxtbox("Breakfast Pack 13", "375");
            }
            else if (mealType == "Beverages")
            {
                displayTxtbox("Beverage Pack 13", "110");
            }
            else if (mealType == "Coffee")
            {
                displayTxtbox("Coffee Pack 13", "90");
            }

            quantityTxtbox();
            setState();
        }
        private void pictureBox14_Click(object sender, EventArgs e)
        {
            if (mealType == "Lunch")
            {
                displayTxtbox("Lunch Pack 12", "195");
            }
            else if (mealType == "Dinner")
            {
                displayTxtbox("Dinner Pack 12", "150");
            }
            else if (mealType == "Dessert")
            {
                displayTxtbox("Dessert Pack 12", "375");
            }
            else if (mealType == "Breakfast")
            {
                displayTxtbox("Breakfast Pack 12", "140");
            }
            else if (mealType == "Beverages")
            {
                displayTxtbox("Beverage Pack 12", "77");
            }
            else if (mealType == "Coffee")
            {
                displayTxtbox("Coffee Pack 12", "68");
            }

            quantityTxtbox();
            setState();
        }
        private void pictureBox15_Click(object sender, EventArgs e)
        {
            if (mealType == "Lunch")
            {
                displayTxtbox("Lunch Pack 11", "215");
            }
            else if (mealType == "Dinner")
            {
                displayTxtbox("Dinner Pack 11", "165");
            }
            else if (mealType == "Dessert")
            {
                displayTxtbox("Dessert Pack 11", "300");
            }
            else if (mealType == "Breakfast")
            {
                displayTxtbox("Breakfast Pack 11", "100");
            }
            else if (mealType == "Beverages")
            {
                displayTxtbox("Beverage Pack 11", "75");
            }
            else if (mealType == "Coffee")
            {
                displayTxtbox("Coffee Pack 11", "105");
            }

            quantityTxtbox();
            setState();
        }
        private void pictureBox16_Click(object sender, EventArgs e)
        {
            if (mealType == "Lunch")
            {
                displayTxtbox("Lunch Pack 20", "199");
            }
            else if (mealType == "Dinner")
            {
                displayTxtbox("Dinner Pack 20", "135");
            }
            else if (mealType == "Dessert")
            {
                displayTxtbox("Dessert Pack 20", "220");
            }
            else if (mealType == "Breakfast")
            {
                displayTxtbox("Breakfast Pack 20", "230");
            }
            else if (mealType == "Beverages")
            {
                displayTxtbox("Beverage Pack 20", "92");
            }
            else if (mealType == "Coffee")
            {
                displayTxtbox("Coffee Pack 20", "70");
            }

            quantityTxtbox();
            setState();
        }
        private void pictureBox17_Click(object sender, EventArgs e)
        {
            if (mealType == "Lunch")
            {
                displayTxtbox("Lunch Pack 19", "169");
            }
            else if (mealType == "Dinner")
            {
                displayTxtbox("Dinner Pack 19", "155");
            }
            else if (mealType == "Dessert")
            {
                displayTxtbox("Dessert Pack 19", "425");
            }
            else if (mealType == "Breakfast")
            {
                displayTxtbox("Breakfast Pack 19", "180");
            }
            else if (mealType == "Beverages")
            {
                displayTxtbox("Beverage Pack 19", "78");
            }
            else if (mealType == "Coffee")
            {
                displayTxtbox("Coffee Pack 19", "115");
            }

            quantityTxtbox();
            setState();
        }
        private void pictureBox18_Click(object sender, EventArgs e)
        {
            if (mealType == "Lunch")
            {
                displayTxtbox("Lunch Pack 18", "190");
            }
            else if (mealType == "Dinner")
            {
                displayTxtbox("Dinner Pack 18", "120");
            }
            else if (mealType == "Dessert")
            {
                displayTxtbox("Dessert Pack 18", "365");
            }
            else if (mealType == "Breakfast")
            {
                displayTxtbox("Breakfast Pack 18", "190");
            }
            else if (mealType == "Beverages")
            {
                displayTxtbox("Beverage Pack 18", "125");
            }
            else if (mealType == "Coffee")
            {
                displayTxtbox("Coffee Pack 18", "50");
            }

            quantityTxtbox();
            setState();
        }
        private void pictureBox19_Click(object sender, EventArgs e)
        {
            if (mealType == "Lunch")
            {
                displayTxtbox("Lunch Pack 17", "315");
            }
            else if (mealType == "Dinner")
            {
                displayTxtbox("Dinner Pack 17", "395");
            }
            else if (mealType == "Dessert")
            {
                displayTxtbox("Dessert Pack 17", "425");
            }
            else if (mealType == "Breakfast")
            {
                displayTxtbox("Breakfast Pack 17", "360");
            }
            else if (mealType == "Beverages")
            {
                displayTxtbox("Beverage Pack 17", "108");
            }
            else if (mealType == "Coffee")
            {
                displayTxtbox("Coffee Pack 17", "88");
            }

            quantityTxtbox();
            setState();
        }
        private void pictureBox20_Click(object sender, EventArgs e)
        {
            if (mealType == "Lunch")
            {
                displayTxtbox("Lunch Pack 16", "225");
            }
            else if (mealType == "Dinner")
            {
                displayTxtbox("Dinner Pack 16", "130");
            }
            else if (mealType == "Dessert")
            {
                displayTxtbox("Dessert Pack 16", "210");
            }
            else if (mealType == "Breakfast")
            {
                displayTxtbox("Breakfast Pack 16", "105");
            }
            else if (mealType == "Beverages")
            {
                displayTxtbox("Beverage Pack 16", "89");
            }
            else if (mealType == "Coffee")
            {
                displayTxtbox("Coffee Pack 16", "77");
            }

            quantityTxtbox();
            setState();
        }
        /// for processing the discount checkboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void seniordiscount_radiobtn_changed(object sender, EventArgs e)
        {
           
            //convert string data from textboxes to numeric and place it as value of the variable
            try
            {
                variables.qty = Convert.ToInt32(quantitytxtbox.Text);
                // set new states
                cash_renderedtxtbox.Enabled = true;
                cash_renderedtxtbox.Focus();
            }
            catch (Exception asd)
            {
                MessageBox.Show(asd.Message);
                quantitytxtbox.Focus();
                senior_discount_button.Checked = false;
            }

            variables.price = Convert.ToDouble(pricetextbox.Text);
            //create a formula needed for computation
            variables.discount_amt = (variables.qty * variables.price) * 0.30;
            variables.discounted_amt = (variables.qty * variables.price) - variables.discount_amt;
            //converting numeric data to string and display it inside the textboxes
            discounttxtbox.Text = variables.discount_amt.ToString("n");
            discountedtxtbox.Text = variables.discounted_amt.ToString("n");

        }

        private void withdiscount_radiobtn_changed(object sender, EventArgs e)
        {
            //convert string data from textboxes to numeric and place it as value of the variable
            try
            {
                variables.qty = Convert.ToInt32(quantitytxtbox.Text);

                // set new states
                cash_renderedtxtbox.Enabled = true;
                cash_renderedtxtbox.Focus();

            }
            catch (Exception asd)
            {
                MessageBox.Show(asd.Message);
                quantitytxtbox.Focus();
                with_discountCard_button.Checked = false;
            }
            variables.price = Convert.ToDouble(pricetextbox.Text);
            //create a formula needed for computation
            variables.discount_amt = (variables.qty * variables.price) * 0.10;
            variables.discounted_amt = (variables.qty * variables.price) - variables.discount_amt;
            //converting numeric data to string and display it inside the textboxes
            discounttxtbox.Text = variables.discount_amt.ToString("n");
            discountedtxtbox.Text = variables.discounted_amt.ToString("n");
            //codes for unchecking the other radio buttons in the interface once With disc. card method executed
            senior_discount_button.Checked = false;
            employee_discount_button.Checked = false;
            no_discount_button.Checked = false;
        }

        private void EmployeeRdbtn_CheckedChanged(object sender, EventArgs e)
        {
            //convert string data from textboxes to numeric and place it as valu of the variable
            try
            {
                variables.qty = Convert.ToInt32(quantitytxtbox.Text);

                // set new states
                cash_renderedtxtbox.Enabled = true;
                cash_renderedtxtbox.Focus();
            }
            catch (Exception asd)
            {
                //MessageBox.Show(asd.Message);
                MessageBox.Show(asd.Message);
                quantitytxtbox.Focus();
                employee_discount_button.Checked = false;
            }
            variables.price = Convert.ToDouble(pricetextbox.Text);

            //create a formula needed for computation
            variables.discount_amt = (variables.qty * variables.price) * 0.15;
            variables.discounted_amt = (variables.qty * variables.price) - variables.discount_amt;
            //converting numeric data to string and display it inside the textboxes
            discounttxtbox.Text = variables.discount_amt.ToString("n");
            discountedtxtbox.Text = variables.discounted_amt.ToString("n");

            //codes for unchecking the other radio buttons in the interface once Employee disc method executed
            senior_discount_button.Checked = false;
            with_discountCard_button.Checked = false;
            no_discount_button.Checked = false;
        }

        private void nodiscount_radiobtn_changed(object sender, EventArgs e)
        {
            //convert string data from textboxes to numeric and place it as value of the variable
            try
            {
                variables.qty = Convert.ToInt32(quantitytxtbox.Text);

                // set new states
                cash_renderedtxtbox.Enabled = true;
                cash_renderedtxtbox.Focus();
            }
            catch (Exception asd)
            {
                MessageBox.Show(asd.Message);
                quantitytxtbox.Focus();
                no_discount_button.Checked = false;
            }

            variables.price = Convert.ToDouble(pricetextbox.Text);
            //create a formula needed for computation
            variables.discount_amt = (variables.qty * variables.price) * 0;
            variables.discounted_amt = (variables.qty * variables.price) - variables.discount_amt;
            //converting numeric data to string and display it inside the textboxes
            discounttxtbox.Text = variables.discount_amt.ToString("n");
            discountedtxtbox.Text = variables.discounted_amt.ToString("n");

            //codes for unchecking the other radio buttons in the interface once No method executed
            senior_discount_button.Checked = false;
            with_discountCard_button.Checked = false;
            employee_discount_button.Checked = false;
        }

        /// <summary>
        /// for processing the calculations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calcbtn_Click(object sender, EventArgs e)
        {
           
            // make sure quantity text box is 0 if it is empty
            try
            {
                variables.qty = string.IsNullOrEmpty(quantitytxtbox.Text) ? 0 : Convert.ToInt32(quantitytxtbox.Text);
            }
            catch (Exception asd)
            {
                MessageBox.Show(asd.Message);
                quantitytxtbox.Clear();
                quantitytxtbox.Focus();
            }
            variables.discount_amt = string.IsNullOrEmpty(discounttxtbox.Text) ? 0 : Convert.ToDouble(discounttxtbox.Text);
            variables.discounted_amt = string.IsNullOrEmpty(discountedtxtbox.Text) ? 0 : Convert.ToDouble(discountedtxtbox.Text);

            try
            {
                variables.cash_rendered = string.IsNullOrEmpty(cash_renderedtxtbox.Text) ? 0 : Convert.ToDouble(cash_renderedtxtbox.Text);
                // codes to accumulate the value of the quantity, discount given and discounted amount from one transaction to another.
                variables.summary_total_qty += variables.qty;
                variables.summary_total_discount += variables.discount_amt;
                variables.summary_total_discounted += variables.discounted_amt;
                variables.change = variables.cash_rendered - variables.discounted_amt;

                // convert string data form textboxes to numeric and place it as value of the variable
                total_quantity_txtbox.Text = variables.summary_total_qty.ToString();
                total_discount_txtbox.Text = variables.summary_total_discount.ToString("n");
                total_discounted_txtbox.Text = variables.summary_total_discounted.ToString("n");
                changetxtbox.Text = variables.change.ToString("n");
                cash_renderedtxtbox.Text = variables.cash_rendered.ToString("n");

                // disable other buttons

                // process group
                quantitytxtbox.Enabled = false;

                // buttons
                calcbtn.Enabled = false;

                // discounts
                senior_discount_button.Enabled = false;
                with_discountCard_button.Enabled = false;
                employee_discount_button.Enabled = false;
                no_discount_button.Enabled = false;

                // meal packs
                dinnerBtn.Enabled = false;
                lunchBtn.Enabled = false;
                dessertsBtn.Enabled = false;
                breakfastBtn.Enabled = false;
                beveragesBtn.Enabled = false;
                coffeeBtn.Enabled = false;

                // pictures
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;
                pictureBox4.Enabled = false;
                pictureBox5.Enabled = false;
                pictureBox6.Enabled = false;
                pictureBox7.Enabled = false;
                pictureBox8.Enabled = false;
                pictureBox9.Enabled = false;
                pictureBox9.Enabled = false;
                pictureBox10.Enabled = false;
                pictureBox11.Enabled = false;
                pictureBox12.Enabled = false;
                pictureBox13.Enabled = false;
                pictureBox14.Enabled = false;
                pictureBox15.Enabled = false;
                pictureBox16.Enabled = false;
                pictureBox17.Enabled = false;
                pictureBox18.Enabled = false;
                pictureBox19.Enabled = false;
                pictureBox20.Enabled = false;

                // render
                cash_renderedtxtbox.Enabled = false;
                /////
                ///// set new state
                /////
                newbtn.Enabled = true;

            }
            catch (Exception asd)
            {
                MessageBox.Show(asd.Message);
                cash_renderedtxtbox.Clear();
                cash_renderedtxtbox.Focus();
            }
        }

        private void newbtn_Click(object sender, EventArgs e)
        {
            isNewOrder = true; // Prevent QR scanning temporarily

            // discount disable 1st;
            // if discount button is on, it calculates the empty quantity box
            senior_discount_button.Checked = false; senior_discount_button.Enabled = false;
            with_discountCard_button.Checked = false; with_discountCard_button.Enabled = false;
            employee_discount_button.Checked = false; employee_discount_button.Enabled = false;
            no_discount_button.Checked = false; no_discount_button.Enabled = false;

            // Disable event handlers to prevent calculations
            quantitytxtbox.TextChanged -= quantitytxtbox_TextChanged;
            pricetextbox.TextChanged -= pricetextbox_TextChanged;

            // clear the process boxes
            itemnametxtbox.Clear();
            pricetextbox.Clear();
            quantitytxtbox.Clear(); quantitytxtbox.Enabled = false;
            discounttxtbox.Clear();
            discountedtxtbox.Clear();

            // Re-enable event handlers
            quantitytxtbox.TextChanged += quantitytxtbox_TextChanged;
            pricetextbox.TextChanged += pricetextbox_TextChanged;

            // and cash rendered
            changetxtbox.Clear();
            cash_renderedtxtbox.Clear();
            // buttons
            calcbtn.Enabled = false;
            newbtn.Enabled = false;

            ///// set new state enable(meal packs)
            dinnerBtn.Enabled = true;
            lunchBtn.Enabled = true;
            dessertsBtn.Enabled = true;
            breakfastBtn.Enabled = true;
            beveragesBtn.Enabled = true;
            coffeeBtn.Enabled = true;

            // pictures
            CN_picbox();
            isNewOrder = false; // Re-enable QR scanning for future changes
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            /////
            ///// clear all 
            /////
            isNewOrder = true; // Prevent QR scanning temporarily
            // pictures
            CN_picbox();
            dinnerBtn.Enabled = true;
            lunchBtn.Enabled = true;
            dessertsBtn.Enabled = true;
            breakfastBtn.Enabled = true;
            beveragesBtn.Enabled = true;
            coffeeBtn.Enabled = true;

            // discount disable 1st;
            // if discount button is on, it calculates the empty quantity box
            senior_discount_button.Checked = false; senior_discount_button.Enabled = false;
            with_discountCard_button.Checked = false; with_discountCard_button.Enabled = false;
            employee_discount_button.Checked = false; employee_discount_button.Enabled = false;
            no_discount_button.Checked = false; no_discount_button.Enabled = false;

            // process group
            itemnametxtbox.Clear();
            pricetextbox.Clear();
            quantitytxtbox.Clear(); quantitytxtbox.Enabled = false;
            discounttxtbox.Clear();
            discountedtxtbox.Clear();

            // buttons 
            calcbtn.Enabled = false;
            newbtn.Enabled = false;
            cancelbtn.Enabled = false;

            // summary group
            total_quantity_txtbox.Clear(); summary_total_qty = 0;
            total_discount_txtbox.Clear(); summary_total_discount = 0;
            total_discounted_txtbox.Clear(); summary_total_discounted = 0;

            // render
            cash_renderedtxtbox.Clear(); cash_renderedtxtbox.Enabled = false;
            changetxtbox.Clear();

            isNewOrder = false; // Re-enable QR scanning for future changes
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

	///////////////////////////////////////////////////////////////////////////
	///////////////////////////////////////////////////////////////////////////
	///////////////////////////////////////////////////////////////////////////
	///////////////////////////////////////////////////////////////////////////
	///////////////////////////////////////////////////////////////////////////
	///////////////////////////////////////////////////////////////////////////
	///////////////////////////////////////////////////////////////////////////
	/// 
	/// 
	/// 
	///////////////////////////////////////////////////////////////////////////
	///////////////////////////////////////////////////////////////////////////
	///////////////////////////////////////////////////////////////////////////
	///////////////////////////////////////////////////////////////////////////
	///////////////////////////////////////////////////////////////////////////
	///////////////////////////////////////////////////////////////////////////
	///////////////////////////////////////////////////////////////////////////
	///////////////////////////////////////////////////////////////////////////

        private void quantitytxtbox_TextChanged(object sender, EventArgs e)
        {
            // set new state
            senior_discount_button.Enabled = true;
            with_discountCard_button.Enabled = true;
            employee_discount_button.Enabled = true;
            no_discount_button.Enabled = true;
            try
            {
                int temp_to_check_if_quantity_is_int;
                temp_to_check_if_quantity_is_int = Convert.ToInt32(quantitytxtbox.Text);

            }
            catch (Exception asd)
            {
                MessageBox.Show(asd.Message);
                quantitytxtbox.Clear();
                quantitytxtbox.Focus();
            }
        }

        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pricetextbox_TextChanged(object sender, EventArgs e)
        {
        }

        private void cash_renderedtxtbox_TextChanged(object sender, EventArgs e)
        {
            // set new state
            calcbtn.Enabled = true;
        }

        private void total_quantity_txtbox_TextChanged(object sender, EventArgs e)
        {
            cancelbtn.Enabled = true;
        }

        private void discountedtxtbox_TextChanged(object sender, EventArgs e)
        {
            if (isNewOrder) return; // Prevent QR scanning when "New" button is clicked

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

    }
}
