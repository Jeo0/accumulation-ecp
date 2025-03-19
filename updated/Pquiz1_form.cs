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


namespace New_POS_Application
{
    public partial class Pquiz1_form : Form
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

        public Pquiz1_form()
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

        private void scanqrbtn_Click(object sender, EventArgs e)
        {
            
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

            /*
            // disable food group and bundles
            button_bundle_a.Enabled = false;
            button_bundle_b.Enabled = false;
            checkbox_a1.Enabled = false;
            checkbox_a2.Enabled = false;
            checkbox_b1.Enabled = false;
            checkbox_b2.Enabled = false;
            displayListBox.Enabled = false;
            picturebox_orderimage.Enabled = false;
            */


        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// //////////////////////////////////////////////////////////////////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dinnerBtn_Click(object sender, EventArgs e)
        {
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
        private void lunchBtn_Click(object sender, EventArgs e)
        {
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

        private void dessertsBtn_Click(object sender, EventArgs e)
        {
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

        private void breakfastBrn_Click(object sender, EventArgs e)
        {
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

        private void beveragesBtn_Click(object sender, EventArgs e)
        {
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

        private void coffeeBtn_Click(object sender, EventArgs e)
        {

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



        /// <summary>
        /// behaviour for picture boxes
        /// </summary>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = namelbl1.Text;
            pricetextbox.Text = Convert.ToString(price1);

            // disable 
            // buttons
            calcbtn.Enabled = false;

            // discounts
            senior_discount_button.Enabled = false;
            with_discountCard_button.Enabled = false;
            employee_discount_button.Enabled = false;
            no_discount_button.Enabled = false;

            // set other states
            quantitytxtbox.Enabled = true;
            quantitytxtbox.Focus();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = namelbl2.Text;
            pricetextbox.Text = Convert.ToString(price2);

            // disable 
            // buttons
            calcbtn.Enabled = false;

            // discounts
            senior_discount_button.Enabled = false;
            with_discountCard_button.Enabled = false;
            employee_discount_button.Enabled = false;
            no_discount_button.Enabled = false;

            // set other states
            quantitytxtbox.Enabled = true;
            quantitytxtbox.Focus();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = namelbl3.Text;
            pricetextbox.Text = Convert.ToString(price3);

            // disable 
            // buttons
            calcbtn.Enabled = false;

            // discounts
            senior_discount_button.Enabled = false;
            with_discountCard_button.Enabled = false;
            employee_discount_button.Enabled = false;
            no_discount_button.Enabled = false;

            // set other states
            quantitytxtbox.Enabled = true;
            quantitytxtbox.Focus();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = namelbl4.Text;
            pricetextbox.Text = Convert.ToString(price4);

            // disable 
            // buttons
            calcbtn.Enabled = false;

            // discounts
            senior_discount_button.Enabled = false;
            with_discountCard_button.Enabled = false;
            employee_discount_button.Enabled = false;
            no_discount_button.Enabled = false;

            // set other states
            quantitytxtbox.Enabled = true;
            quantitytxtbox.Focus();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = namelbl5.Text;
            pricetextbox.Text = Convert.ToString(price5);

            // disable 
            // buttons
            calcbtn.Enabled = false;

            // discounts
            senior_discount_button.Enabled = false;
            with_discountCard_button.Enabled = false;
            employee_discount_button.Enabled = false;
            no_discount_button.Enabled = false;

            // set other states
            quantitytxtbox.Enabled = true;
            quantitytxtbox.Focus();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = namelbl6.Text;
            pricetextbox.Text = Convert.ToString(price6);

            // disable 
            // buttons
            calcbtn.Enabled = false;

            // discounts
            senior_discount_button.Enabled = false;
            with_discountCard_button.Enabled = false;
            employee_discount_button.Enabled = false;
            no_discount_button.Enabled = false;

            // set other states
            quantitytxtbox.Enabled = true;
            quantitytxtbox.Focus();
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = namelbl7.Text;
            pricetextbox.Text = Convert.ToString(price7);

            // disable 
            // buttons
            calcbtn.Enabled = false;

            // discounts
            senior_discount_button.Enabled = false;
            with_discountCard_button.Enabled = false;
            employee_discount_button.Enabled = false;
            no_discount_button.Enabled = false;

            // set other states
            quantitytxtbox.Enabled = true;
            quantitytxtbox.Focus();
        }
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = namelbl8.Text;
            pricetextbox.Text = Convert.ToString(price8);

            // disable 
            // buttons
            calcbtn.Enabled = false;

            // discounts
            senior_discount_button.Enabled = false;
            with_discountCard_button.Enabled = false;
            employee_discount_button.Enabled = false;
            no_discount_button.Enabled = false;

            // set other states
            quantitytxtbox.Enabled = true;
            quantitytxtbox.Focus();
        }
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = namelbl9.Text;
            pricetextbox.Text = Convert.ToString(price9);

            // disable 
            // buttons
            calcbtn.Enabled = false;

            // discounts
            senior_discount_button.Enabled = false;
            with_discountCard_button.Enabled = false;
            employee_discount_button.Enabled = false;
            no_discount_button.Enabled = false;

            // set other states
            quantitytxtbox.Enabled = true;
            quantitytxtbox.Focus();
        }
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = namelbl10.Text;
            pricetextbox.Text = Convert.ToString(price10);

            // disable 
            // buttons
            calcbtn.Enabled = false;

            // discounts
            senior_discount_button.Enabled = false;
            with_discountCard_button.Enabled = false;
            employee_discount_button.Enabled = false;
            no_discount_button.Enabled = false;

            // set other states
            quantitytxtbox.Enabled = true;
            quantitytxtbox.Focus();
        }
        private void pictureBox11_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = namelbl11.Text;
            pricetextbox.Text = Convert.ToString(price11);

            // disable 
            // buttons
            calcbtn.Enabled = false;

            // discounts
            senior_discount_button.Enabled = false;
            with_discountCard_button.Enabled = false;
            employee_discount_button.Enabled = false;
            no_discount_button.Enabled = false;

            // set other states
            quantitytxtbox.Enabled = true;
            quantitytxtbox.Focus();
        }
        private void pictureBox12_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = namelbl12.Text;
            pricetextbox.Text = Convert.ToString(price12);

            // disable 
            // buttons
            calcbtn.Enabled = false;

            // discounts
            senior_discount_button.Enabled = false;
            with_discountCard_button.Enabled = false;
            employee_discount_button.Enabled = false;
            no_discount_button.Enabled = false;

            // set other states
            quantitytxtbox.Enabled = true;
            quantitytxtbox.Focus();
        }
        private void pictureBox13_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = namelbl13.Text;
            pricetextbox.Text = Convert.ToString(price13);

            // disable 
            // buttons
            calcbtn.Enabled = false;

            // discounts
            senior_discount_button.Enabled = false;
            with_discountCard_button.Enabled = false;
            employee_discount_button.Enabled = false;
            no_discount_button.Enabled = false;

            // set other states
            quantitytxtbox.Enabled = true;
            quantitytxtbox.Focus();
        }
        private void pictureBox14_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = namelbl14.Text;
            pricetextbox.Text = Convert.ToString(price14);

            // disable 
            // buttons
            calcbtn.Enabled = false;

            // discounts
            senior_discount_button.Enabled = false;
            with_discountCard_button.Enabled = false;
            employee_discount_button.Enabled = false;
            no_discount_button.Enabled = false;

            // set other states
            quantitytxtbox.Enabled = true;
            quantitytxtbox.Focus();
        }
        private void pictureBox15_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = namelbl15.Text;
            pricetextbox.Text = Convert.ToString(price15);

            // disable 
            // buttons
            calcbtn.Enabled = false;

            // discounts
            senior_discount_button.Enabled = false;
            with_discountCard_button.Enabled = false;
            employee_discount_button.Enabled = false;
            no_discount_button.Enabled = false;

            // set other states
            quantitytxtbox.Enabled = true;
            quantitytxtbox.Focus();
        }
        private void pictureBox16_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = namelbl16.Text;
            pricetextbox.Text = Convert.ToString(price16);

            // disable 
            // buttons
            calcbtn.Enabled = false;

            // discounts
            senior_discount_button.Enabled = false;
            with_discountCard_button.Enabled = false;
            employee_discount_button.Enabled = false;
            no_discount_button.Enabled = false;

            // set other states
            quantitytxtbox.Enabled = true;
            quantitytxtbox.Focus();
        }
        private void pictureBox17_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = namelbl17.Text;
            pricetextbox.Text = Convert.ToString(price17);

            // disable 
            // buttons
            calcbtn.Enabled = false;

            // discounts
            senior_discount_button.Enabled = false;
            with_discountCard_button.Enabled = false;
            employee_discount_button.Enabled = false;
            no_discount_button.Enabled = false;

            // set other states
            quantitytxtbox.Enabled = true;
            quantitytxtbox.Focus();
        }
        private void pictureBox18_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = namelbl18.Text;
            pricetextbox.Text = Convert.ToString(price18);

            // disable 
            // buttons
            calcbtn.Enabled = false;

            // discounts
            senior_discount_button.Enabled = false;
            with_discountCard_button.Enabled = false;
            employee_discount_button.Enabled = false;
            no_discount_button.Enabled = false;

            // set other states
            quantitytxtbox.Enabled = true;
            quantitytxtbox.Focus();
        }
        private void pictureBox19_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = namelbl19.Text;
            pricetextbox.Text = Convert.ToString(price19);

            // disable 
            // buttons
            calcbtn.Enabled = false;

            // discounts
            senior_discount_button.Enabled = false;
            with_discountCard_button.Enabled = false;
            employee_discount_button.Enabled = false;
            no_discount_button.Enabled = false;

            // set other states
            quantitytxtbox.Enabled = true;
            quantitytxtbox.Focus();
        }
        private void pictureBox20_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = namelbl20.Text;
            pricetextbox.Text = Convert.ToString(price20);

            // disable 
            // buttons
            calcbtn.Enabled = false;

            // discounts
            senior_discount_button.Enabled = false;
            with_discountCard_button.Enabled = false;
            employee_discount_button.Enabled = false;
            no_discount_button.Enabled = false;

            // set other states
            quantitytxtbox.Enabled = true;
            quantitytxtbox.Focus();
        }

        /// <summary>
        /// for processing the discount checkboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void seniordiscount_radiobtn_changed(object sender, EventArgs e)
        {
            //Declaration of variables within a method of an object
            int qty = 0;
            double price, discount_amt, discounted_amt;
            //convert string data from textboxes to numeric and place it as value of the variable
            try
            {
                qty = Convert.ToInt32(quantitytxtbox.Text);
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

            price = Convert.ToDouble(pricetextbox.Text);
            //create a formula needed for computation
            discount_amt = (qty * price) * 0.30;
            discounted_amt = (qty * price) - discount_amt;
            //converting numeric data to string and display it inside the textboxes
            discounttxtbox.Text = discount_amt.ToString("n");
            discountedtxtbox.Text = discounted_amt.ToString("n");


            //codes for unchecking the other radio buttons in the interface once the senior citizen method executed
            with_discountCard_button.Checked = false;
            employee_discount_button.Checked = false;
            no_discount_button.Checked = false;





        }

        private void withdiscount_radiobtn_changed(object sender, EventArgs e)
        {
            int qty = 0;
            double price, discount_amt, discounted_amt;
            //convert string data from textboxes to numeric and place it as value of the variable
            try
            {
                qty = Convert.ToInt32(quantitytxtbox.Text);

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
            price = Convert.ToDouble(pricetextbox.Text);
            //create a formula needed for computation
            discount_amt = (qty * price) * 0.10;
            discounted_amt = (qty * price) - discount_amt;
            //converting numeric data to string and display it inside the textboxes
            discounttxtbox.Text = discount_amt.ToString("n");
            discountedtxtbox.Text = discounted_amt.ToString("n");


            //codes for unchecking the other radio buttons in the interface once With disc. card method executed
            senior_discount_button.Checked = false;
            employee_discount_button.Checked = false;
            no_discount_button.Checked = false;


        }

        private void EmployeeRdbtn_CheckedChanged(object sender, EventArgs e)
        {
            //Declaration of variables within a method of an object
            int qty = 0;
            double price = 0, discount_amt = 0, discounted_amt = 0;
            //convert string data from textboxes to numeric and place it as valu of the variable
            try
            {
                qty = Convert.ToInt32(quantitytxtbox.Text);

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
            price = Convert.ToDouble(pricetextbox.Text);

            //create a formula needed for computation
            discount_amt = (qty * price) * 0.15;
            discounted_amt = (qty * price) - discount_amt;
            //converting numeric data to string and display it inside the textboxes
            discounttxtbox.Text = discount_amt.ToString("n");
            discountedtxtbox.Text = discounted_amt.ToString("n");

            //codes for unchecking the other radio buttons in the interface once Employee disc method executed
            senior_discount_button.Checked = false;
            with_discountCard_button.Checked = false;
            no_discount_button.Checked = false;



        }

        private void nodiscount_radiobtn_changed(object sender, EventArgs e)
        {
            int qty = 0;
            double price, discount_amt, discounted_amt;
            //convert string data from textboxes to numeric and place it as value of the variable
            try
            {
                qty = Convert.ToInt32(quantitytxtbox.Text);

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

            price = Convert.ToDouble(pricetextbox.Text);
            //create a formula needed for computation
            discount_amt = (qty * price) * 0;
            discounted_amt = (qty * price) - discount_amt;
            //converting numeric data to string and display it inside the textboxes
            discounttxtbox.Text = discount_amt.ToString("n");
            discountedtxtbox.Text = discounted_amt.ToString("n");


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
            // declaration of variables with data types
            int qty = 0;
            double discount_amt, discounted_amt, cash_rendered = 0, change;


            // make sure quantity text box is 0 if it is empty
            try
            {
                qty = string.IsNullOrEmpty(quantitytxtbox.Text) ? 0 : Convert.ToInt32(quantitytxtbox.Text);
            }
            catch (Exception asd)
            {
                MessageBox.Show(asd.Message);
                quantitytxtbox.Clear();
                quantitytxtbox.Focus();
            }
            discount_amt = string.IsNullOrEmpty(discounttxtbox.Text) ? 0 : Convert.ToDouble(discounttxtbox.Text);
            discounted_amt = string.IsNullOrEmpty(discountedtxtbox.Text) ? 0 : Convert.ToDouble(discountedtxtbox.Text);

            try
            {
                cash_rendered = string.IsNullOrEmpty(cash_renderedtxtbox.Text) ? 0 : Convert.ToDouble(cash_renderedtxtbox.Text);
                // codes to accumulate the value of the quantity, discount given and discounted amount from one transaction to another.
                summary_total_qty += qty;
                summary_total_discount += discount_amt;
                summary_total_discounted += discounted_amt;
                change = cash_rendered - discounted_amt;

                // convert string data form textboxes to numeric and place it as value of the variable
                total_quantity_txtbox.Text = summary_total_qty.ToString();
                total_discount_txtbox.Text = summary_total_discount.ToString("n");
                total_discounted_txtbox.Text = summary_total_discounted.ToString("n");
                changetxtbox.Text = change.ToString("n");
                cash_renderedtxtbox.Text = cash_rendered.ToString("n");


                /////
                ///// disable other buttons
                /////

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




            /////
            ///// set new state enable
            /////

            // meal packs
            dinnerBtn.Enabled = true;
            lunchBtn.Enabled = true;
            dessertsBtn.Enabled = true;
            breakfastBtn.Enabled = true;
            beveragesBtn.Enabled = true;
            coffeeBtn.Enabled = true;

            // pictures
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

            isNewOrder = false; // Re-enable QR scanning for future changes

        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            /////
            ///// clear all 
            /////
            isNewOrder = true; // Prevent QR scanning temporarily
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


        /// <summary>
        /// // etc. behaviours
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


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


        /// <summary>
        /// //////////////
        /// dont galaw these below
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pricetextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
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

        private void total_discount_txtbox_TextChanged(object sender, EventArgs e)
        {

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
