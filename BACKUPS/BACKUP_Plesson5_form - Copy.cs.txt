using System.Windows.Forms;

namespace example5
{
    public partial class Plesson5_form : Form
    {

        // GLOBAL VARIABLES
        private string picpath;
        private Double basic_netincome = 0.00,
            basic_numhrs = 0.00,
            basic_rate = 0.00,
            hono_netincome = 0.00,
            hono_numhrs = 0.00,
            hono_rate = 0.00,
            other_netincome = 0.00,
            other_numhrs = 0.00,
            other_rate = 0.00;
        private Double netincome = 0.00,
            grossincome = 0.00,
            sss_contrib = 0.00,
            pagibig_contrib = 0.00,
            philhealth_contrib = 0.00,
            tax_contrib = 0.00;
        private Double sss_loan = 0.00,
            pagibig_loan = 0.00,
            salary_loan = 0.00,
            salary_savings = 0.00,
            faculty_sav_loan = 0.00,
            other_deduction = 0.00,
            total_deduction = 0.00,
            total_contrib = 0.00,
            total_loan = 0.00;


        public Plesson5_form()
        {
            InitializeComponent();
        }

        private void ex5_form_Load(object sender, EventArgs e)
        {
            //codes for disabling
            basic_netincomeTxtbox.Enabled = false;
            hono_netincomeTxtbox.Enabled = false;
            other_netincomeTxtbox.Enabled = false;
            net_incomeTxtbox.Enabled = false;
            gross_incomeTxtbox.Enabled = false;
            total_deducTxtbox.Enabled = false;
            sss_contribTxtbox.Text = "0.00";
            pagibig_contribTxtbox.Text = "0.00";
            philhealth_contribTxtbox.Text = "0.00";
            tax_contribTxtbox.Text = "0.00";
            sss_loanTxtbox.Text = "0.00";
            pagibig_loanTxtbox.Text = "0.00";
            FSD_depositTxtbox.Text = "0.00";
            FS_loanTxtbox.Text = "0.00";
            sal_loanTxtbox.Text = "0.00";
            others_loanTxtbox.Text = "0.00";
            others_loanCombo.Text = "Select other deduction";
            others_loanCombo.Items.Add("Other 1");
            others_loanCombo.Items.Add("Other 2");
            others_loanCombo.Items.Add("Other 3");
            others_loanCombo.Items.Add("Other 4");
            picpathTxtbox.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sss_contrib = Convert.ToDouble(sss_contribTxtbox.Text);
            pagibig_contrib = Convert.ToDouble(pagibig_contribTxtbox.Text);
            philhealth_contrib = Convert.ToDouble(philhealth_contribTxtbox.Text);
            tax_contrib = Convert.ToDouble(tax_contribTxtbox.Text);
            sss_loan = Convert.ToDouble(sss_loanTxtbox.Text);
            pagibig_loan = Convert.ToDouble(pagibig_loanTxtbox.Text);
            salary_loan = Convert.ToDouble(sal_loanTxtbox.Text);
            faculty_sav_loan = Convert.ToDouble(FS_loanTxtbox.Text);
            salary_savings = Convert.ToDouble(FSD_depositTxtbox.Text);
            other_deduction = Convert.ToDouble(others_loanTxtbox.Text);

            // formula to compute the desired data to be computed
            total_contrib = sss_contrib + pagibig_contrib + philhealth_contrib +
            tax_contrib;
            total_loan = sss_loan + pagibig_loan + salary_loan + faculty_sav_loan +
            salary_savings + other_deduction;
            total_deduction = total_contrib + total_loan;

            //codes for converting numeric data to string and displayed it inside the textboxes
            total_deducTxtbox.Text = total_deduction.ToString("n");
            netincome = grossincome - total_deduction;
            net_incomeTxtbox.Text = netincome.ToString("n");
        }

        private void previewPayslip_btn_Click(object sender, EventArgs e)
        {
            payslip_viewListBox.Items.Add("Employee Number: " + "\n\t" + emp_nuTxtbox.Text);
            payslip_viewListBox.Items.Add("Firstname: " + "\n\t" + firstnameTxtbox.Text);
            payslip_viewListBox.Items.Add("Middlename: " + "\n\t" + MNameTxtbox.Text);
            payslip_viewListBox.Items.Add("Surname: " + "\n\t\t" + surTxtbox.Text);
            payslip_viewListBox.Items.Add("Designation: " + "\n\t" + desigTxtbox.Text);
            payslip_viewListBox.Items.Add("Employee Status: " + "\n\t" + empStatusTxtbox.Text);
            payslip_viewListBox.Items.Add("Department: " + "\n\t" + DeptNameTxtbox.Text);
            payslip_viewListBox.Items.Add("Pay Date: " + "\n\t" + paydateDatePicker.Text);
            payslip_viewListBox.Items.Add("---------------------------------------------------------------------------------------");
            payslip_viewListBox.Items.Add("BP Num. of Hrs.: " + "\tP" + basic_numhrsTxtbox.Text);
            payslip_viewListBox.Items.Add("BP Rate / Hr.: " + "\tP" + basic_rateTxtbox.Text);
            payslip_viewListBox.Items.Add("Baisc Pay Income " + "\tP" + basic_netincomeTxtbox.Text);

            payslip_viewListBox.Items.Add("");
            payslip_viewListBox.Items.Add("HI Num. of Hrs.: " + "\tP" + hono_numhrsTxtbox.Text);
            payslip_viewListBox.Items.Add("HI Rate / Hr.: " + "\tP" + hono_rateTxtbox.Text);
            payslip_viewListBox.Items.Add("Honorarium Income " + "\tP" + hono_netincomeTxtbox.Text);

            payslip_viewListBox.Items.Add("");
            payslip_viewListBox.Items.Add("OTI Num. of Hrs.: " + "\tP" + other_numhrsTxtbox.Text);
            payslip_viewListBox.Items.Add("OTI Rate / Hr.: " + "\tP" + other_rateTxtbox.Text);
            payslip_viewListBox.Items.Add("Other Income " + "\tP" + other_netincomeTxtbox.Text);

            payslip_viewListBox.Items.Add("---------------------------------------------------------------------------------------");
            payslip_viewListBox.Items.Add("SSS Contribution: " + "\tP" + sss_contribTxtbox.Text);
            payslip_viewListBox.Items.Add("PhilHealth Contribution " + "\tP" + philhealth_contribTxtbox.Text);
            payslip_viewListBox.Items.Add("Pagibig Contribution: " + "\tP" + pagibig_contribTxtbox.Text);
            payslip_viewListBox.Items.Add("Tax Contribution: " + "\tP" + tax_contribTxtbox.Text);
            payslip_viewListBox.Items.Add("SSS Loan: " + "\tP" + sss_loanTxtbox.Text);
            payslip_viewListBox.Items.Add("Pagibig Loan: " + "\tP" + pagibig_loanTxtbox.Text);
            payslip_viewListBox.Items.Add("Faculty Savings Deposit: " + "\tP" + FSD_depositTxtbox.Text);
            payslip_viewListBox.Items.Add("Faculty Savings Loan: " + "\tP" + FS_loanTxtbox.Text);
            payslip_viewListBox.Items.Add("Salary Loan: " + "\tP" + sal_loanTxtbox.Text);
            payslip_viewListBox.Items.Add("Other Loan: " + "\tP" + others_loanTxtbox.Text);

            payslip_viewListBox.Items.Add("---------------------------------------------------------------------------------------");
            payslip_viewListBox.Items.Add("Total Deduction: " + "\tP" + total_deducTxtbox.Text);
            payslip_viewListBox.Items.Add("Gross Income: " + "\tP" + gross_incomeTxtbox.Text);
            payslip_viewListBox.Items.Add("Net Income: " + "\tP" + net_incomeTxtbox.Text);
        }

        private void printPayslip_btn_Click(object sender, EventArgs e)
        {
            Plesson5_printform print1 = new Plesson5_printform();
            //codes for displaying the contents of the listbox from other form to the current form.
            print1.priDisplayListbox.Items.AddRange(this.payslip_viewListBox.Items);
            //code for displaying the other form
            print1.Show();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            // remove everything
            payslip_viewListBox.Items.Clear();
            picpath = "";

            basic_netincome = 0.00;
            basic_numhrs = 0.00;
            basic_rate = 0.00;
            hono_netincome = 0.00;
            hono_numhrs = 0.00;
            hono_rate = 0.00;
            other_netincome = 0.00;
            other_numhrs = 0.00;
            other_rate = 0.00;
            
            netincome = 0.00;
            grossincome = 0.00;
            sss_contrib = 0.00;
            pagibig_contrib = 0.00;
            philhealth_contrib = 0.00;
            tax_contrib = 0.00;
  
            sss_loan = 0.00;
            pagibig_loan = 0.00;
            salary_loan = 0.00;
            salary_savings = 0.00;
            faculty_sav_loan = 0.00;
            other_deduction = 0.00;
            total_deduction = 0.00;
            total_contrib = 0.00;
            total_loan = 0.00;



        emp_nuTxtbox.Clear();
            firstnameTxtbox.Clear();
            MNameTxtbox.Clear();
            surTxtbox.Clear();
            civil_statusTxtbox.Clear();
            desigTxtbox.Clear();
            numDependentTxtbox.Clear();
            empStatusTxtbox.Clear();
            DeptNameTxtbox.Clear();
            basic_netincomeTxtbox.Clear();
            basic_numhrsTxtbox.Clear();
            basic_rateTxtbox.Clear();
            hono_netincomeTxtbox.Clear();
            hono_numhrsTxtbox.Clear();
            hono_rateTxtbox.Clear();
            other_netincomeTxtbox.Clear();
            other_numhrsTxtbox.Clear();
            other_rateTxtbox.Clear();
            net_incomeTxtbox.Clear();
            gross_incomeTxtbox.Clear();
            sss_contribTxtbox.Clear();
            pagibig_contribTxtbox.Clear();
            philhealth_contribTxtbox.Clear();
            tax_contribTxtbox.Clear();
            sss_loanTxtbox.Clear();
            pagibig_loanTxtbox.Clear();
        }

        private void new_btn_Click(object sender, EventArgs e)
        {
            payslip_viewListBox.Items.Clear();

            picpath = "";

            basic_netincome = 0.00;
            basic_numhrs = 0.00;
            basic_rate = 0.00;
            hono_netincome = 0.00;
            hono_numhrs = 0.00;
            hono_rate = 0.00;
            other_netincome = 0.00;
            other_numhrs = 0.00;
            other_rate = 0.00;

            netincome = 0.00;
            grossincome = 0.00;
            sss_contrib = 0.00;
            pagibig_contrib = 0.00;
            philhealth_contrib = 0.00;
            tax_contrib = 0.00;

            sss_loan = 0.00;
            pagibig_loan = 0.00;
            salary_loan = 0.00;
            salary_savings = 0.00;
            faculty_sav_loan = 0.00;
            other_deduction = 0.00;
            total_deduction = 0.00;
            total_contrib = 0.00;
            total_loan = 0.00;

            emp_nuTxtbox.Clear();
            firstnameTxtbox.Clear();
            MNameTxtbox.Clear();
            surTxtbox.Clear();
            civil_statusTxtbox.Clear();
            desigTxtbox.Clear();
            numDependentTxtbox.Clear();
            empStatusTxtbox.Clear();
            DeptNameTxtbox.Clear();
            basic_netincomeTxtbox.Clear();
            basic_numhrsTxtbox.Clear();
            basic_rateTxtbox.Clear();
            hono_netincomeTxtbox.Clear();
            hono_numhrsTxtbox.Clear();
            hono_rateTxtbox.Clear();
            other_netincomeTxtbox.Clear();
            other_numhrsTxtbox.Clear();
            other_rateTxtbox.Clear();
            net_incomeTxtbox.Clear();
            gross_incomeTxtbox.Clear();
            sss_contribTxtbox.Clear();
            pagibig_contribTxtbox.Clear();
            philhealth_contribTxtbox.Clear();
            tax_contribTxtbox.Clear();
            sss_loanTxtbox.Clear();
            pagibig_loanTxtbox.Clear();
        }

        private void browse_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File | * .gif; * .jpg; * .png; * .bmp";
            openFileDialog.Title = " Select Employee Picture";
            openFileDialog.ShowDialog();
            picpath = openFileDialog.FileName;
            picpathTxtbox.Text = picpath;
            pictureBox2.Image = Image.FromFile(openFileDialog.FileName);
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void basic_numhrsTxtbox_TextChanged(object sender, EventArgs e)
        {
            if (basic_numhrsTxtbox.Text == "" ||
                basic_rateTxtbox.Text == "") return;
            basic_numhrs = Double.Parse(basic_numhrsTxtbox.Text);
            basic_rate = Convert.ToDouble(basic_rateTxtbox.Text);
            basic_netincome = basic_numhrs * basic_rate;
            basic_netincomeTxtbox.Text = basic_netincome.ToString("n");
        }

        private void hono_numhrsTxtbox_TextChanged(object sender, EventArgs e)
        {
            if (hono_numhrsTxtbox.Text == "" ||
                hono_rateTxtbox.Text == "") return;
            hono_numhrs = Convert.ToDouble(hono_numhrsTxtbox.Text);
            hono_rate = Convert.ToDouble(hono_rateTxtbox.Text);
            hono_netincome = hono_numhrs * hono_rate;
            hono_netincomeTxtbox.Text = hono_netincome.ToString("n");
        }

        private void other_numhrsTxtbox_TextChanged(object sender, EventArgs e)
        {
            // error handling empty strings
            if (other_numhrsTxtbox.Text == "" ||
                other_rateTxtbox.Text == "") return;
            other_numhrs = Convert.ToDouble(other_numhrsTxtbox.Text);
            other_rate = Convert.ToDouble(other_rateTxtbox.Text);
            other_netincome = other_numhrs * other_rate;
            other_netincomeTxtbox.Text = other_netincome.ToString("n");
            grossincome = basic_netincome + hono_netincome + other_netincome;
            gross_incomeTxtbox.Text = grossincome.ToString("n");
        }

        private void gross_incomeTxtbox_TextChanged(object sender, EventArgs e)
        {
            // handle errors
            if (gross_incomeTxtbox.Text == "") return;

            ////////////////////////////////////
            // tax conditions
            double GROSS_INCOME = Convert.ToDouble(gross_incomeTxtbox.Text);
            double SEMI_MONTH = GROSS_INCOME / 2;
            double TAX_DEDUCTION = 0;

            double RANGE1 = 10417,
                    RANGE2 = 16666,
                    RANGE3 = 33332,
                    RANGE4 = 83332,
                    RANGE5 = 333332;

            if (SEMI_MONTH <= RANGE1) TAX_DEDUCTION = 0;
            else if (SEMI_MONTH <= RANGE2) TAX_DEDUCTION = (SEMI_MONTH - RANGE1) * 0.15 + 0;
            else if (SEMI_MONTH <= RANGE3) TAX_DEDUCTION = (SEMI_MONTH - RANGE2) * 0.2 + 937.5;
            else if (SEMI_MONTH <= RANGE4) TAX_DEDUCTION = (SEMI_MONTH - RANGE3) * 0.25 + 4270.7;
            else if (SEMI_MONTH <= RANGE5) TAX_DEDUCTION = (SEMI_MONTH - RANGE4) * 0.3 + 16770.7;
            else TAX_DEDUCTION = (SEMI_MONTH - RANGE5) * 0.35 + 91770.7;

            // set
            tax_contribTxtbox.Text = TAX_DEDUCTION.ToString("n");


            ////////////////////////////////////
            // Philhealth\
            //int PH_RANGE1 = 10000,
            //    PH_RANGE2 = 20000,
            //    PH_RANGE3 = 50000,
            //    PH_RANGE4 = 100000;


            //if (GROSS_INCOME <= PH_RANGE1) philhealth_contrib = 500;
            //else if (GROSS_INCOME <= PH_RANGE2) philhealth_contrib = 1000;
            //else if (GROSS_INCOME <= PH_RANGE3) philhealth_contrib = 2500;
            //else if (GROSS_INCOME <= PH_RANGE4) philhealth_contrib = 5000;
            int[] PH_RANGES = {
                10000,
                20000,
                50000,
                100000
               };


            int PH_ITR = 500;
            for (int iii = 0; iii < 4; iii++)
            {
                if (GROSS_INCOME <= PH_RANGES[iii])
                    philhealth_contrib = PH_ITR * 2;
            }

            // set
            philhealth_contribTxtbox.Text = Convert.ToString(philhealth_contrib);


            ////////////////////////////////////
            // Pagibig
            double PAG_RANGE1 = 10000,
                PAG_RANGE2 = 79999.99;

            if (GROSS_INCOME <= RANGE1) pagibig_contrib = 500;
            else if (GROSS_INCOME <= PAG_RANGE2) pagibig_contrib = 2500; // somewhere around 500 ~ 5000
            else pagibig_contrib = 5000;

            pagibig_contribTxtbox.Text = Convert.ToString(pagibig_contrib);



            ////////////////////////////////////
            // SSS
            //double SSS_RANGE1 = 4250,
            //        SSS_RANGE2 = 4750,
            //        SSS_RANGE3 = 5250,
            //        SSS_RANGE4 = 5750,
            //        SSS_RANGE5 = 6250,
            //        SSS_RANGE6 = 6750,
            //        SSS_RANGE7 = 7250,
            //        SSS_RANGE8 = 7750,
            //        SSS_RANGE9 = 8250,
            //        SSS_RANGE10 = 8750,
            //        SSS_RANGE11 = 9250,
            //        SSS_RANGE12 = 9750,
            //        SSS_RANGE13 = 10250,
            //        SSS_RANGE14 = 10750,
            //        SSS_RANGE15 = 11250,
            //        SSS_RANGE16 = 11750,
            //        SSS_RANGE17 = 12250,
            //        SSS_RANGE18 = 12750,
            //        SSS_RANGE19 = 13250,
            //        SSS_RANGE20 = 13750,
            //        SSS_RANGE21 = 14250,
            //        SSS_RANGE22 = 14750,
            //        SSS_RANGE23 = 15250,
            //        SSS_RANGE24 = 15750,
            //        SSS_RANGE25 = 16250,
            //        SSS_RANGE26 = 16750,
            //        SSS_RANGE27 = 17250,
            //        SSS_RANGE28 = 17750,
            //        SSS_RANGE29 = 18250,
            //        SSS_RANGE30 = 18750,
            //        SSS_RANGE31 = 19250,
            //        SSS_RANGE32 = 19750,
            //        SSS_RANGE33 = 20250,
            //        SSS_RANGE34 = 20750,
            //        SSS_RANGE35 = 21250,
            //        SSS_RANGE36 = 21750,
            //        SSS_RANGE37 = 22250,
            //        SSS_RANGE38 = 22750,
            //        SSS_RANGE39 = 23250,
            //        SSS_RANGE40 = 23750,
            //        SSS_RANGE41 = 24250,
            //        SSS_RANGE42 = 24750,
            //        SSS_RANGE43 = 25250,
            //        SSS_RANGE44 = 25750;

            //if (GROSS_INCOME < SSS_RANGE1) sss_contrib = 180;
            //else if (GROSS_INCOME < SSS_RANGE2) sss_contrib = 202.5;
            //else if (GROSS_INCOME < SSS_RANGE3) sss_contrib = 225;
            //else if (GROSS_INCOME < SSS_RANGE4) sss_contrib = 247.5;
            //else if (GROSS_INCOME < SSS_RANGE5) sss_contrib = 270;
            //else if (GROSS_INCOME < SSS_RANGE6) sss_contrib = 292.5;
            //else if (GROSS_INCOME < SSS_RANGE7) sss_contrib = 315;
            //else if (GROSS_INCOME < SSS_RANGE8) sss_contrib = 337.5;
            //else if (GROSS_INCOME < SSS_RANGE9) sss_contrib = 360;
            //else if (GROSS_INCOME < SSS_RANGE10) sss_contrib = 382.5;
            //else if (GROSS_INCOME < SSS_RANGE11) sss_contrib = 405;
            //else if (GROSS_INCOME < SSS_RANGE12) sss_contrib = 427.5;
            //else if (GROSS_INCOME < SSS_RANGE13) sss_contrib = 450;
            //else if (GROSS_INCOME < SSS_RANGE14) sss_contrib = 472.5;
            //else if (GROSS_INCOME < SSS_RANGE15) sss_contrib = 495;
            //else if (GROSS_INCOME < SSS_RANGE16) sss_contrib = 517.5;
            //else if (GROSS_INCOME < SSS_RANGE17) sss_contrib = 540;
            //else if (GROSS_INCOME < SSS_RANGE18) sss_contrib = 562.5;
            //else if (GROSS_INCOME < SSS_RANGE19) sss_contrib = 585;
            //else if (GROSS_INCOME < SSS_RANGE20) sss_contrib = 607.5;
            //else if (GROSS_INCOME < SSS_RANGE21) sss_contrib = 630;
            //else if (GROSS_INCOME < SSS_RANGE22) sss_contrib = 652.5;
            //else if (GROSS_INCOME < SSS_RANGE23) sss_contrib = 675;
            //else if (GROSS_INCOME < SSS_RANGE24) sss_contrib = 697.5;
            //else if (GROSS_INCOME < SSS_RANGE25) sss_contrib = 720;
            //else if (GROSS_INCOME < SSS_RANGE26) sss_contrib = 742.5;
            //else if (GROSS_INCOME < SSS_RANGE27) sss_contrib = 765;
            //else if (GROSS_INCOME < SSS_RANGE28) sss_contrib = 787.5;
            //else if (GROSS_INCOME < SSS_RANGE29) sss_contrib = 810;
            //else if (GROSS_INCOME < SSS_RANGE30) sss_contrib = 832.5;
            //else if (GROSS_INCOME < SSS_RANGE31) sss_contrib = 855;
            //else if (GROSS_INCOME < SSS_RANGE32) sss_contrib = 877.5;
            //else if (GROSS_INCOME < SSS_RANGE33) sss_contrib = 900;
            //else if (GROSS_INCOME < SSS_RANGE34) sss_contrib = 922.5;
            //else if (GROSS_INCOME < SSS_RANGE35) sss_contrib = 945;
            //else if (GROSS_INCOME < SSS_RANGE36) sss_contrib = 967.5;
            //else if (GROSS_INCOME < SSS_RANGE37) sss_contrib = 990;
            //else if (GROSS_INCOME < SSS_RANGE38) sss_contrib = 1012.5;
            //else if (GROSS_INCOME < SSS_RANGE39) sss_contrib = 1035;
            //else if (GROSS_INCOME < SSS_RANGE40) sss_contrib = 1057.5;
            //else if (GROSS_INCOME < SSS_RANGE41) sss_contrib = 1080;
            //else if (GROSS_INCOME < SSS_RANGE42) sss_contrib = 1102.5;
            //else if (GROSS_INCOME < SSS_RANGE43) sss_contrib = 1125;
            //else if (GROSS_INCOME < SSS_RANGE44) sss_contrib = 1147.5;




            // set
            sss_contribTxtbox.Text = Convert.ToString(sss_contrib);




        }
    }
}
