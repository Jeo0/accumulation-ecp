using Activity5;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectNamin
{
    public partial class MQUIZ2_ENTRY_FORM : Form
    {
        public MQUIZ2_ENTRY_FORM()
        {
            InitializeComponent();
        }

        private void inp_submit_btn_Click(object sender, EventArgs e)
        {


            // insert it in a cache
            inp_cache_lb.Items.Add(
                this.inp_num_tb.Text + "\t"  +
                this.inp_coursecode_tb.Text  + "\t" +
                this.inp_section_tb.Text + "\t" +
                this.inp_desc_tb.Text + "\t" +
                this.inp_lec_tb.Text     + "\t" +
                this.inp_lab_tb.Text     + "\t" +
                this.inp_time_tb.Text        + "\t" +
                this.inp_day_tb.Text         + "\t" +
                this.inp_room_tb.Text
                );

            // now add it to the other form 
            MQUIZ2 entriesDoonSaKabila = new MQUIZ2();
            entriesDoonSaKabila.Entries_lb.Items.AddRange(this.inp_cache_lb.Items);

            // for processing
            // lec 
            // lab 
            // cred units
            inp_lec_cache_lb.Items.Add(this.inp_lec_tb.Text);
            inp_lab_cache_lb.Items.Add(this.inp_lab_tb.Text);
            inp_cred_cache_lb.Items.Add(
                Convert.ToInt32(this.inp_lec_tb.Text)
                + 
                Convert.ToInt32(this.inp_lab_tb.Text)
                );

            // Add it to the array
            int numberOfCurrentItems = inp_cache_lb.Items.Count;
            // for debugging how many entries we have 
            entriesDoonSaKabila.label19.Text = Convert.ToString(numberOfCurrentItems); 

            int currentCredNumber = 
                Convert.ToInt16(this.inp_lec_tb.Text)
                +
                Convert.ToInt16(this.inp_lab_tb.Text);

            entriesDoonSaKabila.lecArr[numberOfCurrentItems-1] = Convert.ToInt32(this.inp_lec_tb.Text);
            entriesDoonSaKabila.labArr[numberOfCurrentItems-1] = Convert.ToInt32(this.inp_lab_tb.Text);
            entriesDoonSaKabila.credArr[numberOfCurrentItems-1] = Convert.ToInt32(currentCredNumber);

            


            this.Hide();
            entriesDoonSaKabila.ShowDialog();
            this.Close();

            // this.Close();

            //code for displaying the other form
            //entriesDoonSaKabila.Show();
        }
    }
}
