using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LESSON1
{
    public partial class Activity1 : Form
    {
        public Activity1()
        {
            InitializeComponent();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //codes for inserting or putting values for a text property of a textbox
            itemnameTxtbox.Text = "Breakfast meal B";
            priceTxtbox.Text = "121.30";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //codes for inserting or putting values for a text property of a textbox
            itemnameTxtbox.Text = "Double Value Meal A";
            priceTxtbox.Text = "191.00";
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            //codes for inserting or putting values for a text property of a textbox
            itemnameTxtbox.Text = "Lunch Value Meal 1";
            priceTxtbox.Text = "199.10";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //codes for inserting or putting values for a text property of a textbox
            itemnameTxtbox.Text = "Friend Meal A";
            priceTxtbox.Text = "391.90";

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //codes for inserting or putting values for a text property of a textbox
            itemnameTxtbox.Text = "Family Combo Meal B";
            priceTxtbox.Text = "799.30";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //codes for inserting or putting values for a text property of a textbox
            itemnameTxtbox.Text = "Breakfast Meal A";
            priceTxtbox.Text = "91.30";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            //codes for inserting or putting values for a text property of a textbox
            itemnameTxtbox.Text = "Family Combo Meal A";
            priceTxtbox.Text = "999.90";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            //codes for inserting or putting values for a text property of a textbox
            itemnameTxtbox.Text = "Chicken Meal A";
            priceTxtbox.Text = "177.30";
;        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            //codes for inserting or putting values for a text property of a textbox
            itemnameTxtbox.Text = "Pasta Meal 101";
            priceTxtbox.Text = "98.00";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            //codes for inserting or putting values for a text property of a textbox
            itemnameTxtbox.Text = "Breakfast Meal C";
            priceTxtbox.Text = "91.30";
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            //codes for inserting or putting values for a text property of a textbox
            itemnameTxtbox.Text = "Lunch Value Meal B";
            priceTxtbox.Text = "191.30";
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            //codes for inserting or putting values for a text property of a textbox
            itemnameTxtbox.Text = "Pancake Value Meal A";
            priceTxtbox.Text = "97.30";
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            //codes for inserting or putting values for a text property of a textbox
            itemnameTxtbox.Text = "Breakfast Meal B";
            priceTxtbox.Text = "133.30";
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            //codes for inserting or putting values for a text property of a textbox
            itemnameTxtbox.Text = "Chicken Meal 2";
            priceTxtbox.Text = "191.30";
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            //codes for inserting or putting values for a text property of a textbox
            itemnameTxtbox.Text = "Double Palaboc Meal";
            priceTxtbox.Text = "120.50";
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            //codes for execution of the Windows Form Application
            this.Close();
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            //codes for clearing and emptying the value of a Text property of a  textbox
            itemnameTxtbox.Clear();
            priceTxtbox.Clear();
        }

        private void priceTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Activity1_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(255, 192, 128);
        }
    }
}
