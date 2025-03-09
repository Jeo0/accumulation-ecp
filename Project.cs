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

namespace LESSON1
{

    public partial class Project : Form
    {
        // Declare global variables for the camera
        private FilterInfoCollection videoDevices; // List of available webcams
        private VideoCaptureDevice videoSource;   // Selected webcam
        private bool scanning = false;
        private Timer timer;

        // msc
        bool hamster_state = false;
        string hamsterloc1 = "E:\\school\\3rdyr\\2ndsem\\ecp\\prelim\\activity 1\\FitnessQuizApp\\resources\\images\\1-1-beforeStartButton.jpg",
                hamsterloc2 = "E:\\school\\3rdyr\\2ndsem\\ecp\\prelim\\activity 1\\FitnessQuizApp\\resources\\images\\1-2-afterStartButton.gif";


        // globals
        // Declaration of variables with data types
        int qty = 0, qty_total = 0;
        double discount_amt = 0, discounted_amt = 0, cash_rendered = 0, change = 0;
        double discount_totalgiven = 0, discounted_total = 0;


        public Project()
        {
            InitializeComponent();
            timer = new Timer();
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
            if (QRBOX.Image != null)
            {
                // with the help from chatgpt
                try
                {
                    // Create a BarcodeReader to decode the image
                    BarcodeReader reader = new BarcodeReader();
                    Result result = reader.Decode((Bitmap)QRBOX.Image);

                    if (result != null)
                    {
                        // Safely update the UI (Invoke required because QRBOX.Image and Cash_renderedtxtbox are UI controls)
                        this.Invoke((Action)(() =>
                        {
                            p_cashrendered.Text = result.Text; // Display the scanned amount
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            cd_itemname.Text = "Combo Meal A";
            cd_price.Text = "100.00";
            cd_quant.Enabled = true;
           
        }

       
        private void button3_Click(object sender, EventArgs e)
        {

        }

       
        private void button10_Click(object sender, EventArgs e)
        {
            // Reset the picture box
            if (QRBOX.Image != null)
            {
                QRBOX.Image.Dispose();
                QRBOX.Image = null;
            }
            StopCamera();


            StartCamera();
            timer.Start();

            // turn on sus
            hamster.ImageLocation = "C:\\Users\\admin\\Pictures\\screenshots\\march 7 sus.png";

            newBtn.Enabled = true;
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
                    QRBOX.Image = (Bitmap)eventArgs.Frame.Clone();
                }));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error handling new frame: " + ex.Message);
            }
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {

        }
        private void StopCamera()
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource = null;
                scanning = false;
            }

            // reset the hamster
            hamster.ImageLocation = "";
        }

        

        

        private void button12_Click(object sender, EventArgs e)
        {
            StopCamera();
            System.Windows.Forms.Application.Exit();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void Activity2_Load(object sender, EventArgs e)
        {

            hamster.ImageLocation = "";

            // code for disabling the textboxes
            cd_itemname.Enabled = false;
            cd_quant.Enabled = false;
            cd_damount.Enabled = false;
            cd_price.Enabled = false;
            cd_discount.Enabled = false;
            s_qty.Enabled = false;
            //s_totaldisc.Enabled = false;
            //s_tda.Enabled = false;
            d_no.Enabled = false;
            d_senior.Enabled = false;
            p_cashrendered.Enabled = false;
            p_change.Enabled = false;

            calculateBtn.Enabled = false;
            newBtn.Enabled = false;
            startQRBtn.Enabled = false;


            // code for inserting name of the image inside the picture box too
            string variable = "E:\\school\\3rdyr\\2ndsem\\ecp\\prelim\\quiqui\\Quiz1_Elective\\images\\breakfast\\";

            pictureBox1.Image = System.Drawing.Image.FromFile(variable + "b1.jfif");
            pictureBox2.Image = System.Drawing.Image.FromFile(variable + "b2.jfif");
            pictureBox3.Image = System.Drawing.Image.FromFile(variable + "b3.jfif");
            pictureBox4.Image = System.Drawing.Image.FromFile(variable + "b4.jfif");
            pictureBox5.Image = System.Drawing.Image.FromFile(variable + "b5.jfif");
            pictureBox6.Image = System.Drawing.Image.FromFile(variable + "b6.jfif");
            pictureBox7.Image = System.Drawing.Image.FromFile(variable + "b7.jfif");
            pictureBox8.Image = System.Drawing.Image.FromFile(variable + "b8.jfif");
            pictureBox9.Image = System.Drawing.Image.FromFile(variable + "b9.jfif");
            pictureBox10.Image = System.Drawing.Image.FromFile(variable + "b10.jfif");
            

            // code for inserting names of the image inside the label tool
            label1.Text = "Slice Burger";
            label2.Text = "Chicken Meal A";
            label3.Text = "Combo Meal A";
            label4.Text = "Breakfast Meal A";
            label5.Text = "Special Burger";

            // <-
            label6.Text = "Steeak on the House";
            label7.Text = "Shawarma Plate";
            label8.Text = "EggInidoro";
            label9.Text = "Breakfast Meal 1";
            label10.Text = "Yaoyao";
            
          
        }


        private void itemnametxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void qty_totaltxtbox_TextChanged(object sender, EventArgs e)
        {
            startQRBtn.Enabled = true;
            startQRBtn.Focus();

            d_no.Enabled = true;
            d_senior.Enabled = true;
        }

        private void discountedtxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pricetxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void discounttxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Total_qtytxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Total_discounttxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TotalDisAmounttxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            cd_itemname.Text = "Breakfast Meal 1";
            cd_price.Text = "75.00";
            cd_quant.Enabled = true;
            cd_quant.Focus();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            cd_itemname.Text = "Breakfast Meal 2";
            cd_price.Text = "80.00";
            cd_quant.Enabled = true;
            cd_quant.Focus();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            cd_itemname.Text = "Chicken Meal A";
            cd_price.Text = "150.00";
            cd_quant.Enabled = true; cd_quant.Focus();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            cd_itemname.Text = "Combo Meal B";
            cd_price.Text = "500.00";
            cd_quant.Enabled = true; cd_quant.Focus();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            cd_itemname.Text = "Breakfast Meal C";
            cd_price.Text = "75.00";
            cd_quant.Enabled = true; cd_quant.Focus();

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            cd_itemname.Text = "Family Meal 1";
            cd_price.Text = "400.00";
            cd_quant.Enabled = true; cd_quant.Focus();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            cd_itemname.Text = "Palabok";
            cd_price.Text = "70.00";
            cd_quant.Enabled = true; cd_quant.Focus();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            cd_itemname.Text = "Chicken Meal B";
            cd_price.Text = "400.00";
            cd_quant.Enabled = true; cd_quant.Focus();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            cd_itemname.Text = "Breakfast Meal 3";
            cd_price.Text = "85.00";
            cd_quant.Enabled = true; cd_quant.Focus();
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            // default to no discount if the discount is not interacted
            if (d_no.Checked == false && d_senior.Checked == false) d_no.Checked = true;

            int.TryParse(cd_quant.Text, out qty);
            double.TryParse(cd_discount.Text, out discount_amt);
            double.TryParse(cd_damount.Text, out discounted_amt);
            double.TryParse(p_cashrendered.Text, out cash_rendered);
            // codes to accumulate the value of the quantity, discount given and discount amount from
            //one transaction to another
            qty_total += qty;
            discount_totalgiven += discount_amt;
            discounted_total += discounted_amt;
            change = cash_rendered - discounted_amt;
            // convert string data from textboxes to numeric and place  it as value of the variable
            cd_quant.Text = qty_total.ToString();

            s_qty.Text = Convert.ToString(qty_total);
            //s_totaldisc.Text = discount_totalgiven.ToString("n");
            //s_tda.Text = discounted_total.ToString("n");
            p_change.Text = change.ToString("n");
            p_cashrendered.Text = change.ToString("n");

            change = Convert.ToDouble(p_cashrendered.Text) - Convert.ToDouble(cd_damount.Text);
            p_change.Text = Convert.ToString(change);


        }

        private void Cash_renderedtxtbox_Changed(object sender, EventArgs e)
        {
            
        }

        private void Changetxtbox_Click(object sender, EventArgs e)
        {

        }

        

        private void sccheckbox_CheckedChanged(object sender, EventArgs e)
        {
            int qty;
            double price, disc_amt, disced_amt;

            qty = Convert.ToInt32(cd_quant.Text);
            price = Convert.ToDouble(cd_price.Text);

            disc_amt = (qty * price) * .3;
            disced_amt = (qty * price) - disc_amt;

            cd_discount.Text = disc_amt.ToString("n");
            cd_damount.Text = disced_amt.ToString("n");
            

        }

        

        private void newbtn_Click_1(object sender, EventArgs e)
        {
            cd_itemname.Clear();
            cd_price.Clear();
            cd_quant.Clear();
            cd_damount.Clear();
            cd_discount.Clear();
            p_change.Clear();
            p_cashrendered.Clear();


            d_no.Checked = false;
            d_senior.Checked = false;

            d_no.Enabled = false;
            d_senior.Enabled = false;

            startQRBtn.Enabled = false;
            cd_quant.Enabled = false;


            // buttons
            newBtn.Enabled = false;


            // Reset the picture box
            if (QRBOX.Image != null)
            {
                QRBOX.Image.Dispose();
                QRBOX.Image = null;
            }

            // Restart scanning
            StopCamera();


        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            cd_itemname.Text = "Spaghetti";
            cd_price.Text = "80.00";
            cd_quant.Enabled = true;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            int qty = 0;
            double price = 0, discount_amt = 0, discounted_amt = 0;

            int.TryParse(cd_quant.Text, out qty);
            double.TryParse(cd_price.Text, out price);

            discount_amt = (qty * price) * 0.30;
            discounted_amt = (qty * price) - discount_amt;

            cd_discount.Text = discount_amt.ToString("n");
            cd_damount.Text = discounted_amt.ToString("n");

            d_no.Enabled = false;
           


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            int qty = 0;
            double price, discount_amt, discounted_amt;

            int.TryParse(cd_quant.Text, out qty);
            double.TryParse(cd_price.Text, out price);

            discount_amt = (qty * price) * 0.00;
            discounted_amt = (qty * price) - discount_amt;

            cd_discount.Text = discount_amt.ToString("n");
            cd_damount.Text = discounted_amt.ToString("n");

            d_senior.Enabled = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            cd_itemname.Text = "Chicken and Soup";
            cd_price.Text = "155.00";
            cd_quant.Enabled = true;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            cd_itemname.Text = "Tocino /w Egg";
            cd_price.Text = "112.00";
            cd_quant.Enabled = true;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            cd_itemname.Text = "Chicken regular";
            cd_price.Text = "140.00";
            cd_quant.Enabled = true;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            cd_itemname.Text = "Pancake /w Sausage";
            cd_price.Text = "145.00";
            cd_quant.Enabled = true;
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            cd_itemname.Text = "Chicken Bao";
            cd_price.Text = "215.00";
            cd_quant.Enabled = true;
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            cd_itemname.Text = "Panini Melt";
            cd_price.Text = "120.00";
            cd_quant.Enabled = true;
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            cd_itemname.Text = "Honey Duck";
            cd_price.Text = "250.00";
            cd_quant.Enabled = true;
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            cd_itemname.Text = "Cheeseburger";
            cd_price.Text = "120.00";
            cd_quant.Enabled = true;
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            cd_itemname.Text = "Grilled Lobster";
            cd_price.Text = "345.00";
            cd_quant.Enabled = true;
        }

        private void hamster_Click(object sender, EventArgs e)
        {
            // just back n forth img loading
            hamster_state = !hamster_state;
            if (hamster_state) hamster.ImageLocation = "";
            else hamster.ImageLocation = "";
        }
    }
}
