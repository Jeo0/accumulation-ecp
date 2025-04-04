using Activity5;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectNamin
{
    public partial class MQUIZ2_ENTRY_FORM : Form
    {
        private Mquiz2_Student studentObject; 
        public MQUIZ2_ENTRY_FORM(Mquiz2_Student studentObject)
        {
            InitializeComponent();
            this.studentObject = studentObject;
        }

        private void inp_submit_btn_Click(object sender, EventArgs e)
        {
            // insert it in a cache
            int currentCred = Convert.ToInt32(inp_lec_tb.Text) +
                                Convert.ToInt32(inp_lab_tb.Text);

            inp_cache_lb.Items.Add(
                this.inp_num_tb.Text + "\t"  +
                this.inp_coursecode_tb.Text  + "\t\t" +
                this.inp_section_tb.Text + "\t" +
                this.inp_desc_tb.Text + "\t\t\t" +
                this.inp_lec_tb.Text     + "\t" +
                this.inp_lab_tb.Text     + "\t" +
                Convert.ToString(currentCred) + "\t\t" +
                this.inp_time_tb.Text    + "\t" +
                this.inp_day_tb.Text     + "\t\t\t" +
                this.inp_room_tb.Text
                );


            // now add it to the other form 
            MQUIZ2 entriesDoonSaKabila = new MQUIZ2();
            entriesDoonSaKabila.Entries_lb.Items.AddRange(this.inp_cache_lb.Items);


            // for processing
            // lec 
            // lab 
            // cred units
            inp_lec_cache_lb.Items.Add(inp_lec_tb.Text);
            inp_lab_cache_lb.Items.Add(inp_lab_tb.Text);
            inp_cred_cache_lb.Items.Add( Convert.ToInt32(inp_lec_tb.Text)
                                        +        
                                        Convert.ToInt32(inp_lab_tb.Text)
                );

            // Add it to the array
            int numberOfCurrentItems = inp_cache_lb.Items.Count;
            // for debugging how many entries we have 
            //entriesDoonSaKabila.label19.Text = Convert.ToString(numberOfCurrentItems); 


            // pass the values to the other form 
            Debug.WriteLine("inp_leccachelb items.cout: {0}", inp_lec_cache_lb.Items.Count);
            //for(int iii=0; iii<inp_lec_cache_lb.Items.Count; iii++) {
            for (int iii=0; iii<numberOfCurrentItems; iii++) {
                var item = inp_lec_cache_lb.Items[iii];
                entriesDoonSaKabila.lecArr[iii] = Convert.ToInt32(item);
                //Debug.WriteLine("currentLec: {0}", Convert.ToInt32(item)); 
            }

                //Debug.WriteLine("=========================="); 
            for(int iii=0; iii<numberOfCurrentItems; iii++) {
                var item = inp_lab_cache_lb.Items[iii];
                entriesDoonSaKabila.labArr[iii] = Convert.ToInt32(item);
                //Debug.WriteLine("currentLab: {0}", Convert.ToInt32(item)); 
            }

                //Debug.WriteLine("=========================="); 
            for(int iii=0; iii<numberOfCurrentItems; iii++) {
                var item = inp_cred_cache_lb.Items[iii];
                entriesDoonSaKabila.credArr[iii] = Convert.ToInt32(item);
                //Debug.WriteLine("currentcred: {0}", Convert.ToInt32(item)); 
            }


            ///////////////////////////////
            ///////////////////////////////
            ///////////////////////////////
            ///////////////////////////////
            ///////////////////////////////
            //
            // set the texts
            //
            ///////////////////////////////
            ///////////////////////////////
            ///////////////////////////////
            ///////////////////////////////
            ///////////////////////////////
            entriesDoonSaKabila.inp_studentname_tb.Text = studentObject.student_name;
            entriesDoonSaKabila.inp_program_cb.Text = studentObject.program;
            entriesDoonSaKabila.inp_dateenrolled_dp.Text = studentObject.date_enrolled;
            entriesDoonSaKabila.inp_mode_cb.Text = studentObject.mode;
            entriesDoonSaKabila.inp_studentnumber_tb.Text = studentObject.student_number;
            entriesDoonSaKabila.inp_yearlevel_cb.Text = studentObject.year_level;   
            entriesDoonSaKabila.inp_scholar_cb.Text = studentObject.scholar;


            // exit
            this.Hide();
            entriesDoonSaKabila.ShowDialog();
            this.Close();
        }
    }
}
