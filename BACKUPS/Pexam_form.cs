namespace exam_prelim_ecp
{
    public partial class Pexam_form : Form
    {

        int SI_CONTRACT = 0;
        string SI_ACCOUNT = "",
                SI_SERVICE_ADD = "",
                SI_TIN = "",
                SI_RATE = "",
                SI_BUSINESS = "";

        int //MI_METERNO = 0,
            MI_MRUNO = 0,
            MI_SEQNO = 0,
            // MI_READDATE = 0,
            MI_PRESENTREAD = 0,
            MI_PREVIOUSREAD = 0,
            MI_COM = 0;
        string MI_METERNO = "",
               MI_READDATE = "";


        string BS_1BILLPERIOD = "",
               BS_2BILLPERIOD = "";
        double BS_CURRENTCHARGE = 0,
            BS_BASICCHARGE = 0,
              BS_ENVCHARGE = 0,
              BS_MSC = 0,
              BS_TOTALCHARGE = 0,
              BS_GOVTAX = 0;

        double OUTPUT_TOTAL_AMOUNT_DUE = 0;

        public Pexam_form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // si
            //si_contract.Enabled = false;
            //si_account.Enabled = false;
            //si_service_add.Enabled = false;
            //si_tin.Enabled = false;
            //si_rate.Enabled = false;
            //si_business.Enabled = false;

            // mi
            //mi_meterno.Enabled = false;
            //mi_mruno.Enabled = false;
            //mi_seqno.Enabled = false;
            //mi_readdate.Enabled = false;
            //mi_presentread.Enabled = false;
            //mi_previousread.Enabled = false;
            //mi_com.Enabled = false;

            // bs
            // bs_1billperiod.Enabled = false;
            bs_2billperiod.Enabled = false;
            bs_currentcharges.Enabled = false;
            bs_basiccharge.Enabled = false;
            bs_envcharge.Enabled = false;
            bs_msc.Enabled = false;
            bs_totalcharge.Enabled = false;
            bs_govtax.Enabled = false;

            // summary
            output_total_amount_due.Enabled = false;
            // output_payment_due.Enabled = false;

            submit_button.Enabled = false;
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            OUTPUT_TOTAL_AMOUNT_DUE = BS_TOTALCHARGE + BS_GOVTAX;
            output_total_amount_due.Text = OUTPUT_TOTAL_AMOUNT_DUE.ToString("C");

            BS_CURRENTCHARGE = OUTPUT_TOTAL_AMOUNT_DUE;
            bs_currentcharges.Text = BS_CURRENTCHARGE.ToString("C");
        }

        private void mi_com_TextChanged(object sender, EventArgs e)
        {
            // error check if null, then dont proceed
            if (mi_com.Text == "") { return; }

            MI_COM = Convert.ToInt32(mi_com.Text);
            BS_BASICCHARGE = 23.52 * MI_COM;
            bs_basiccharge.Text = Convert.ToString(BS_BASICCHARGE);

            // enable submnit
            submit_button.Enabled = true;
        }

        private void mi_readdate_ValueChanged(object sender, EventArgs e)
        {
            MI_READDATE = mi_readdate.Text;
            BS_2BILLPERIOD = MI_READDATE;
            bs_2billperiod.Text = BS_2BILLPERIOD;


        }

        private void bs_2billperiod_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bs_currentcharges_TextChanged(object sender, EventArgs e)
        {

        }

        private void bs_basiccharge_TextChanged(object sender, EventArgs e)
        {
            BS_ENVCHARGE = .2 * BS_BASICCHARGE; bs_envcharge.Text = Convert.ToString(BS_ENVCHARGE);

            BS_MSC = 1.53; bs_msc.Text = Convert.ToString(BS_MSC);

            BS_TOTALCHARGE = BS_BASICCHARGE + BS_ENVCHARGE + BS_MSC; 
            bs_totalcharge.Text = Convert.ToString(BS_TOTALCHARGE);
            BS_GOVTAX = BS_TOTALCHARGE * 0.025; bs_govtax.Text = Convert.ToString(BS_GOVTAX);


        }

        private void mi_presentread_TextChanged(object sender, EventArgs e)
        {
            MI_PRESENTREAD = Convert.ToInt32(mi_presentread.Text);

        }

        private void mi_previousread_TextChanged(object sender, EventArgs e)
        {
            MI_PREVIOUSREAD = Convert.ToInt32(mi_previousread.Text);
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            PRINT_FORM temporary = new PRINT_FORM();
            temporary.printListBox.Items.Add("\t\t\t\tSTATEMENT OF ACCOUNT");
            temporary.printListBox.Items.Add("\t\t\tFor the Month of: February 2024");

            temporary.printListBox.Items.Add("");
            temporary.printListBox.Items.Add("\t\tSERVICE INFORMATION");
            temporary.printListBox.Items.Add("Contract Account No.:\t" + si_contract.Text);
            temporary.printListBox.Items.Add("Account Name:\t\t" + si_account.Text);
            temporary.printListBox.Items.Add("Service Address:\t\t" + si_service_add.Text);
            temporary.printListBox.Items.Add("TIN:\t\t\t" + si_tin.Text);
            temporary.printListBox.Items.Add("Rate Class:\t\t" + si_rate.Text);
            temporary.printListBox.Items.Add("Business Class:\t\t" + si_business.Text);

            temporary.printListBox.Items.Add("---------------------------------");
            temporary.printListBox.Items.Add("");
            temporary.printListBox.Items.Add("\t\tMETERING INFORMATION");
            temporary.printListBox.Items.Add("Meter No:\t\t\t" + mi_meterno.Text);
            temporary.printListBox.Items.Add("MRU No:\t\t\t" + mi_mruno.Text);
            temporary.printListBox.Items.Add("Seq No:\t\t\t" + mi_seqno.Text);
            temporary.printListBox.Items.Add("Reading Date:\t\t" + mi_readdate.Text);
            temporary.printListBox.Items.Add("Present Reading:\t\t" + mi_presentread.Text);
            temporary.printListBox.Items.Add("Previous Reading: \t\t" + mi_previousread.Text);
            temporary.printListBox.Items.Add("Consumption (cu.m)\t" + mi_com.Text);

            temporary.printListBox.Items.Add("---------------------------------");
            temporary.printListBox.Items.Add("");
            temporary.printListBox.Items.Add("\t\tBILL PAYMENT HISTORY");


            temporary.printListBox.Items.Add("---------------------------------");
            temporary.printListBox.Items.Add("");
            temporary.printListBox.Items.Add("\t\tBILLING SUMMARY");
            temporary.printListBox.Items.Add("Billing period: \t\t\t" + bs_1billperiod.Text + "\tto\t" + bs_2billperiod.Text);
            temporary.printListBox.Items.Add("Current Charges\t\t\t" + bs_currentcharges.Text);
            temporary.printListBox.Items.Add("Basic Charge\t\t\t" + bs_basiccharge.Text);
            temporary.printListBox.Items.Add("Environmental Charges (20% of basic charge)\t" + bs_envcharge.Text);
            temporary.printListBox.Items.Add("Maintenance Service Charge (MSC)\t" + bs_msc.Text);
            temporary.printListBox.Items.Add("Total Current Charges Before Taxes\t" + bs_totalcharge.Text);
            temporary.printListBox.Items.Add("Government Taxes\t\t\t" + bs_govtax.Text);


            temporary.printListBox.Items.Add("");
            temporary.printListBox.Items.Add("TOTAL AMOUNT DUE\t" + output_total_amount_due.Text);
            temporary.printListBox.Items.Add("PAYMENT DUE DATE\t\t" + output_payment_due.Text);

            temporary.Show();
        }
    }
}
