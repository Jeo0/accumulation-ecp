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
        // Student student = new Student();
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
                label45,    // Total units
                label44,    // Total tuition fee
                label43,    // total misc fee
                label42,    // Other school fees
                label41,    // computer laboratory fee  outputNaten[4]
                label40,    // sap fee
                label39,    // CICSO lab fee
                label38,    // exam booklent 
                label37,    // total other shcool fee
            };

            System.Windows.Forms.Label[] outputSecond =
            {
                label52,    // mode of payment
                label51,    // installment charge
                label50,    // dwonpayemy
                label49,    // firs tinstallment

                label47,    // second installment
                label46,    // 3thd einstallment

                label48,   // amount due
                label26    // grandtotla
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
            outputNaten[4].Text = Convert.ToString(labFee);


            // Lecture fee (tuition)
            // label44
            // outputNaten[1]


            // Miscellaneous fee
            // label43
            // outputNaten[2]


            // installment charges
            // if mode == full payment






        }
    }
}
