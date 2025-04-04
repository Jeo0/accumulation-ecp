using New_POS_Application;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;

namespace projectNamin
{
    public partial class MQUIZ2 : Form
    {
        // arrays set to 100 max entries
        public const int sizeMax = 100;
        public int[] lecArr = new int[sizeMax];
        public int[] labArr = new int[sizeMax];
        public int[] credArr = new int[sizeMax];
        Student student = new Student();
        int temp = 0;

        public MQUIZ2() {
            InitializeComponent();
        }

        private void MQuiz1_Load(object sender, EventArgs e) {
            this.label45.Text = "___";
        }

        private void newEntry_btn_Click(object sender, EventArgs e)
        {
            MQUIZ2_ENTRY_FORM inputForTheEntries_form = new MQUIZ2_ENTRY_FORM();

            // add it to other cache
            inputForTheEntries_form.inp_cache_lb.Items.AddRange(this.Entries_lb.Items);

            // also add the labArr and lecArr and credArr to the other's listbox cache
            int numberOfCurrentItems = Entries_lb.Items.Count;
            for(int iii=0; iii<numberOfCurrentItems; iii++) {
                var item = lecArr[iii];
                inputForTheEntries_form.inp_lec_cache_lb.Items.Add(item);

                item = labArr[iii];
                inputForTheEntries_form.inp_lab_cache_lb.Items.Add(item);

                item = credArr[iii];
                inputForTheEntries_form.inp_cred_cache_lb.Items.Add(item);
            }

            // close this
            this.Hide();
            inputForTheEntries_form.ShowDialog(); // dont use form.Show();
            this.Close();
        }

        private void recompute_btn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Label[] outputNaten =
            {
                label45,    // total units
                label44,    // total tuition fee
                label43,    // total misc fee
                label42,    // other school fees
                label41,    // computer laboratory fee  outputNaten[4]
                label40,    // sap fee
                label39,    // CISCO lab fee
                label38,    // exam booklet 
                label37,    // total other school fee
            };

            System.Windows.Forms.Label[] outputSecond =
            {
                label54,    // total tuition and fees
                label52,    // mode of payment
                label51,    // installment charge
                label50,    // down payment
                label49,    // first installment 1st

                label47,    // second installment 2nd
                label46,    // third installment 3rd

                label48,   // amount due
                label26    // grand total
            };

            ////////////////////////////////
            ////////////////////////////////
            ////////////////////////////////
            // 
            // processing
            // 
            ////////////////////////////////
            ////////////////////////////////
            ////////////////////////////////

            // add lahat ng cred units into total units sa label45
            temp = 0; // use this to accumulate how many cred units
            for(int iii=0; iii<sizeMax; iii++) { 
                temp += credArr[iii];  // accumulate
            }
            outputNaten[0].Text = Convert.ToString(temp);



            // push ko

            // you:
            // git add .
            // git commit -m "yay"
            // git pull
            // may merge conflicts (tawagin mo ko mga 6 tuloy tuloy lang para magising ako jajaja)
            // tsaka mo to iprocess



            // computer laboratory fee
            // label41 
            // outputNaten[4]
            temp = 0; // use this to accumulate how many lab units 
            for(int iii=0; iii<sizeMax; iii++) { 
                temp += labArr[iii];
                // debug
                //Debug.WriteLine("LabArr[{0}] = : {1}", iii, labArr[iii]);
                //Debug.WriteLine("total temp: {0}\n\n", temp);
            }
            int labFee = temp * 2500; // 2500 per lab unit


            // Lecture fee (tuition)
            // label44
            // outputNaten[1]
            
            int tuitionFee = 0;
            for (int iii = 0; iii < sizeMax; iii++)
            {
                tuitionFee += lecArr[iii] * 1500; // 1500 per lab unit
            }
            outputNaten[1].Text = tuitionFee.ToString();

            //Total other school fees
            int sapFee = 0, ciscoLabFee = 4550, examBookRent = 420;
            int otherSchoolFees = labFee + sapFee + ciscoLabFee + examBookRent;
            outputNaten[8].Text = otherSchoolFees.ToString();

            // Miscellaneous fee
            // label43
            // outputNaten[2]
            int miscFee = otherSchoolFees + tuitionFee;
            outputNaten[2].Text = miscFee.ToString();

            // total tuition and fees
            // label 54
            // outputSecond[0]
            if(inp_mode_cb.SelectedItem != null) {
                double discount = 0;

                switch (inp_mode_cb.SelectedItem.ToString()) {
                    case "Full Payment":
                        discount = 0.1;

                        // installment charges
                        // those are constants
                        student.downpayment = 0;
                        student.first_installment = 0;
                        student.second_installment = 0;
                        student.third_installment = 0;
                        break;

                    case "Installment":
                        discount = -0.15;

                        student.downpayment = 300;
                        student.first_installment = 300;
                        student.second_installment = 300;
                        student.third_installment = 300;
                        break;
                }
                student.total_tuition_and_fees *= (1 - discount);
            }





            // set the texts
            outputNaten[4].Text = Convert.ToString(labFee); // label41 computer laboratory fee
            outputSecond[0].Text = Convert.ToString(student.total_tuition_and_fees); // label54 total tuition and fees






        }
    }
}
