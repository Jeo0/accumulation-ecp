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

namespace projectNamin
{
    public partial class MQUIZ2 : Form
    {
        // arrays set to 400 max entries
        public int[] lecArr = new int[400];
        public int[] labArr = new int[400];
        public int[] credArr = new int[400];
        int temp = 0;

        public MQUIZ2()
        {
            InitializeComponent();
        }

        private void MQuiz1_Load(object sender, EventArgs e)
        {
        }

        private void newEntry_btn_Click(object sender, EventArgs e)
        {
            MQUIZ2_ENTRY_FORM inputForTheEntries_form = new MQUIZ2_ENTRY_FORM();

            // add it to other cache
            inputForTheEntries_form.inp_cache_lb.Items.AddRange(this.Entries_lb.Items);

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
            temp = 0;
            foreach (int iii in credArr) {
                temp += iii;  // accumulate
            }
            outputNaten[0].Text = Convert.ToString(temp);

            // computer laboratory fee
            // label41 
            // outputNaten[4]

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
