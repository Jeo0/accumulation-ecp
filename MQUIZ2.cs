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
        Mquiz2_Student student = new Mquiz2_Student();
        int temp = 0;

        public MQUIZ2() {
            InitializeComponent();
        }

        private void MQuiz1_Load(object sender, EventArgs e) {
        }

        private void newEntry_btn_Click(object sender, EventArgs e)
        {
            MQUIZ2_ENTRY_FORM inputForTheEntries_form = new MQUIZ2_ENTRY_FORM(student);

            // always update the student info every time u create new entry
            student.student_name = inp_studentname_tb.Text;
            student.program = inp_program_cb.SelectedItem.ToString();
            student.date_enrolled = inp_dateenrolled_dp.Value.ToString("yyyy-MM-dd");
            student.mode = inp_mode_cb.SelectedItem.ToString();
            student.student_number = inp_studentnumber_tb.Text;
            student.year_level = inp_yearlevel_cb.SelectedItem.ToString();
            student.scholar = inp_scholar_cb.SelectedItem.ToString();

            // add everything from the current entries in Entries_lb to other cache
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

                // disregard
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
            ////////////////////////////////
            ////////////////////////////////
            ////////////////////////////////
            // 
            // processing
            // 
            ////////////////////////////////
            ////////////////////////////////
            ////////////////////////////////
            ////////////////////////////////
            ////////////////////////////////

            // add lahat ng cred units into total units sa label45
            int numberOfCurrentItems = Entries_lb.Items.Count;
            temp = 0; // use this to accumulate how many cred units
            for(int iii=0; iii<numberOfCurrentItems; iii++) { 
                temp += credArr[iii];  // accumulate
            }



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
            // step 8 
            temp = 0; // use this to accumulate how many lab units 
            for(int iii=0; iii<numberOfCurrentItems; iii++) { 
                temp += labArr[iii];
                // debug
                //Debug.WriteLine("LabArr[{0}]:  {1}", iii, labArr[iii]);
                //Debug.WriteLine("total temp: {0}\n\n", temp);
            }
            student.lab_fee= temp * 2500; // 2500 per lab unit


            // Lecture fee (total tuition fee)
            // label44
            // outputNaten[1]
            // step 9 & 10
            student.total_tuition_fee = 0;
            for (int iii = 0; iii < numberOfCurrentItems; iii++) {
                student.total_tuition_fee += lecArr[iii] * 1500; // 1500 per lab unit
            }


            // Total other school fees
            // label37
            // outputNatin[8]
            // for step 11 (total_msc_fee)
            student.sap_fee = 0;
            student.cisco_fee = 4550;
            student.exam_booklet_fee = 420;
            student.total_other_school_fees = 
                student.lab_fee + student.sap_fee + 
                student.cisco_fee + student.exam_booklet_fee;


            // Miscellaneous fee
            // label43
            // outputNaten[2]
            // step 11
            student.total_msc_fee = student.total_other_school_fees + student.total_tuition_fee;


            // total tuition and fees
            // label 54
            // outputSecond[0]
            // step 12
            student.total_tuition_and_fees = student.total_tuition_fee + student.total_msc_fee;
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


            // amount due
            // label48
            // outputSecond[7]
            student.amount_due = student.total_tuition_and_fees + student.installment_charge;


            // grand total
            // label26
            // outputSecond[8]
            student.grand_total = student.total_tuition_and_fees + student.installment_charge;





            /////////////////////////////////
            /////////////////////////////////
            /////////////////////////////////
            /////////////////////////////////
            /////////////////////////////////
            /////////////////////////////////
            // 
            // set the texts
            // 
            /////////////////////////////////
            /////////////////////////////////
            /////////////////////////////////
            /////////////////////////////////

            outputNaten[0].Text = Convert.ToString(temp); // total cred units

            outputNaten[1].Text = student.total_tuition_fee.ToString(); // label44 total tuition fee
            outputNaten[2].Text = student.total_msc_fee.ToString(); // label43 total misc fee

            outputNaten[4].Text = Convert.ToString(student.lab_fee); // label41 computer laboratory fee
            outputNaten[5].Text = Convert.ToString(student.sap_fee); // label40 sap fee
            outputNaten[6].Text = Convert.ToString(student.cisco_fee); // label39 CISCO lab fee
            outputNaten[7].Text = Convert.ToString(student.exam_booklet_fee); // label38 exam booklet fee
            outputNaten[8].Text = student.total_other_school_fees.ToString(); // label37 total other school fees

            outputSecond[0].Text = Convert.ToString(student.total_tuition_and_fees); // label54 total tuition and fees
            outputSecond[1].Text = inp_mode_cb.SelectedItem.ToString(); // label52 mode of payment
            outputSecond[2].Text = Convert.ToString(student.installment_charge); // label51 installment charge
            outputSecond[3].Text = Convert.ToString(student.downpayment); // label50 down payment
            outputSecond[4].Text = Convert.ToString(student.first_installment); // label49 first installment 1st
            outputSecond[5].Text = Convert.ToString(student.second_installment); // label47 second installment 2nd
            outputSecond[6].Text = Convert.ToString(student.third_installment); // label46 third installment 3rd
            outputSecond[7].Text = Convert.ToString(student.amount_due); // label48 amount due
            outputSecond[8].Text = Convert.ToString(student.grand_total); // label26 grand total


        }
    }
}
