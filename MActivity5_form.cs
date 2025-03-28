using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Activity5 {
  public partial class MActivity5_form : Form {

    MActivity5_class class5 = new MActivity5_class();


    public MActivity5_form() {
      InitializeComponent();
    }


    private void Activity5_Load(object sender, EventArgs e) {
      basic_netincomeTxtbox.Enabled = false;
      hono_netincomeTxtbox.Enabled = false;
      other_netincomeTxtbox.Enabled = false;
      net_incomeTxtbox.Enabled = false;
      gross_incomeTxtbox.Enabled = false;
      total_deducTxtbox.Enabled = false;

      sss_contribTxtbox.Enabled = false;
      pagibig_contribTxtbox.Enabled = false;
      philhealth_contribTxtbox.Enabled = false;
      tax_contribTxtbox.Enabled = false;

      others_loanTxtbox.Enabled = false;

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

    ///////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////
    ///
    /// local functions
    ///
    ///////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////

    private void cleartxtbox() {
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

    private void tryCatchDouble(object namename){
      try {
        double tempname;
        tempname = Convert.ToDouble( (System.Windows.Forms.TextBox)namename.Text);

      } catch (Exception asd) {
        MessageBox.Show(asd.Message + " Make sure it is floating point number");
        (System.Windows.Forms.TextBox)namename.Text = "0";
        (System.Windows.Forms.TextBox)namename.Focus();
      }
    }



    ///////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////
    ///
    /// buttons
    ///
    ///////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////

    private void cancel_btn_Click(object sender, EventArgs e) {
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
      
      class5.netincome = 0.00;
      class5.grossincome = 0.00;
      class5.sss_contrib = 0.00;
      class5.pagibig_contrib = 0.00;
      class5.philhealth_contrib = 0.00;
      class5.tax_contrib = 0.00;

      class5.sss_loan = 0.00;
      class5.pagibig_loan = 0.00;
      class5.salary_loan = 0.00;
      class5.salary_savings = 0.00;
      class5.faculty_sav_loan = 0.00;
      class5.other_deduction = 0.00;
      class5.total_deduction = 0.00;
      class5.total_contrib = 0.00;
      class5.total_loan = 0.00;

      cleartxtbox();
    }


    private void browse_btn_Click(object sender, EventArgs e) {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Filter = "Image File | * .gif; * .jpg; * .png; * .bmp";
      openFileDialog.Title = " Select Employee Picture";
      openFileDialog.ShowDialog();
      class5.picpath = openFileDialog.FileName;
      picpathTxtbox.Text = class5.picpath;

      try {
        pictureBox2.Image = Image.FromFile(openFileDialog.FileName);
      }

      catch (Exception asd) {
        MessageBox.Show("Error: " + asd.Message);
      }
    }


    private void exit_btn_Click(object sender, EventArgs e) {
      this.Close();
    }


    private void new_btn_Click(object sender, EventArgs e) {
      //function for clearing the textboxes
      cleartxtbox();
    }


    private void printPayslip_btn_Click(object sender, EventArgs e) {
      //codes for calling the other form connected to the current form
      MActivity5_PrintFrms print1 = new MActivity5_PrintFrms();

      //codes for displaying the contents of the listbox from other form to thecurrent form.
      print1.PrintDisplayListBox.Items.AddRange(this.payslip_viewListBox.Items);

      //code for displaying the other form
      print1.Show();
    }


    private void previewPayslip_btn_Click(object sender, EventArgs e) {
      //payslip_viewListBox.Items.Add("");
      payslip_viewListBox.Items.Add("Employee Number: " + " " + emp_nuTxtbox.Text);
      payslip_viewListBox.Items.Add("Firstname: " + " " + firstnameTxtbox.Text);
      payslip_viewListBox.Items.Add("Middlename: " + " " + MNameTxtbox.Text);
      payslip_viewListBox.Items.Add("Surname: " + " " + surTxtbox.Text);
      payslip_viewListBox.Items.Add("Designation: " + " " + desigTxtbox.Text);
      payslip_viewListBox.Items.Add("Employee Status: " + " " + empStatusTxtbox.Text);
      payslip_viewListBox.Items.Add("Department: " + " " + DeptNameTxtbox.Text);
      payslip_viewListBox.Items.Add("Pay Date: " + " " + paydateDatePicker.Text);

      payslip_viewListBox.Items.Add("---------------------------------------------------------------------------------------");
      payslip_viewListBox.Items.Add("BP Num. of Hrs.: " + "P" + basic_numhrsTxtbox.Text);
      payslip_viewListBox.Items.Add("BP Rate / Hr.: " + "P" + basic_rateTxtbox.Text);
      payslip_viewListBox.Items.Add("Baisc Pay Income " + "P" + basic_netincomeTxtbox.Text);
      payslip_viewListBox.Items.Add("");
      payslip_viewListBox.Items.Add("HI Num. of Hrs.: " + "P" + hono_netincomeTxtbox.Text);
      payslip_viewListBox.Items.Add("HI Rate / Hr.: " + "P" + hono_netincomeTxtbox.Text);
      payslip_viewListBox.Items.Add("Honorarium Income " + "P" + hono_netincomeTxtbox.Text);

      payslip_viewListBox.Items.Add("");
      payslip_viewListBox.Items.Add("OTI Num. of Hrs.: " + "P" + other_numhrsTxtbox.Text);
      payslip_viewListBox.Items.Add("OTI Rate / Hr.: " + "P" + other_rateTxtbox.Text);
      payslip_viewListBox.Items.Add("Other Income " + "P" + other_netincomeTxtbox.Text);

      payslip_viewListBox.Items.Add("---------------------------------------------------------------------------------------");
      payslip_viewListBox.Items.Add("SSS Contribution: " + "P" + sss_contribTxtbox.Text);

      payslip_viewListBox.Items.Add("PhilHealth Contribution " + "P" + philhealth_contribTxtbox.Text);
      payslip_viewListBox.Items.Add("Pagibig Contribution: " + "P" + pagibig_contribTxtbox.Text);
      payslip_viewListBox.Items.Add("Tax Contribution: " + "P" + tax_contribTxtbox.Text);

      payslip_viewListBox.Items.Add("SSS Loan: " + "P" + sss_loanTxtbox.Text);
      payslip_viewListBox.Items.Add("Pagibig Loan: " + "P" + pagibig_loanTxtbox.Text);
      payslip_viewListBox.Items.Add("Faculty Savings Deposit: " + "P" + FSD_depositTxtbox.Text);
      payslip_viewListBox.Items.Add("Faculty Savings Loan: " + "P" + FS_loanTxtbox.Text);
      payslip_viewListBox.Items.Add("Salary Loan: " + "P" + sal_loanTxtbox.Text);
      payslip_viewListBox.Items.Add("Other Loan: " + "P" + others_loanTxtbox.Text);

      payslip_viewListBox.Items.Add("---------------------------------------------------------------------------------------");
      payslip_viewListBox.Items.Add("Total Deduction: " + "P" + total_deducTxtbox.Text);
      payslip_viewListBox.Items.Add("Gross Income: " + "P" + gross_incomeTxtbox.Text);
      payslip_viewListBox.Items.Add("Net Income: " + "P" + net_incomeTxtbox.Text);
    }

    private void calc_btn_Click(object sender, EventArgs e) {
      //codes for converting input data from textboxes as string to numeric
      //codes for putting data from textboxes to variables
      class5.sss_contrib = Convert.ToDouble(sss_contribTxtbox.Text);
      class5.pagibig_contrib = Convert.ToDouble(pagibig_contribTxtbox.Text);
      class5.philhealth_contrib = Convert.ToDouble(philhealth_contribTxtbox.Text);
      class5.tax_contrib = Convert.ToDouble(tax_contribTxtbox.Text);
      class5.sss_loan = Convert.ToDouble(sss_loanTxtbox.Text);
      class5.pagibig_loan = Convert.ToDouble(pagibig_loanTxtbox.Text);
      class5.salary_loan = Convert.ToDouble(sal_loanTxtbox.Text);
      class5.faculty_sav_loan = Convert.ToDouble(FS_loanTxtbox.Text);
      class5.salary_savings = Convert.ToDouble(FSD_depositTxtbox.Text);
      class5.other_deduction = Convert.ToDouble(others_loanTxtbox.Text);
      class5.grossincome = Convert.ToDouble(gross_incomeTxtbox.Text);

      //formula to compute the desired data to be computed
      class5.total_contrib = class5.sss_contrib + class5.pagibig_contrib + class5.philhealth_contrib + tax_contrib;
      class5.total_loan = class5.sss_loan + class5.pagibig_loan + class5.salary_loan + class5.faculty_sav_loan + class5.salary_savings + other_deduction;
      class5.total_deduction = class5.total_contrib + total_loan;

      //codes for converting numeric data to string and displayed it inside the textboxes
      total_deducTxtbox.Text = total_deduction.ToString("n");
      class5.netincome = class5.grossincome - total_deduction;
      net_incomeTxtbox.Text = class5.netincome.ToString("n");
    }



    ///////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////
    ///
    /// left side
    ///
    ///////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////



    private void basic_numhrsTxtbox_TextChanged(object sender, EventArgs e) {
      // this was already declared in Class1 class
      // double basic_numhrs = 0, basic_rate = 0, basic_netincome = 0;

      // check basic_numhrs
      try {
        double temp_to_check_basic_numhrs_is_double;
        temp_to_check_basic_numhrs_is_double = Convert.ToDouble(basic_numhrsTxtbox.Text);
        class5.basic_numhrs = temp_to_check_basic_numhrs_is_double;
      }
      catch (Exception asd) {
        MessageBox.Show(asd.Message + " Make sure it is floating point number");
        // basic_numhrsTxtbox.Clear();
        class5.basic_numhrs = 0; // default value if parsing fails
        basic_numhrsTxtbox.Text = "0";
        basic_numhrsTxtbox.Focus();
      }

      // check basic_rate
      if (basic_rateTxtbox.TextLength != 0) {
        try {
          double tempcheck;
          tempcheck = Convert.ToDouble(basic_rateTxtbox.Text);
          class5.basic_rate = tempcheck;
        }
        catch (Exception asd) {
          MessageBox.Show(asd.Message + " Make sure it is floating point number");
          //basic_rateTxtbox.Clear();
          class5.basic_rate = 0;

          basic_rateTxtbox.Text = "0";
          basic_rateTxtbox.Focus();
        }
      }


      class5.basic_netincome = class5.basic_numhrs * class5.basic_rate;
      basic_netincomeTxtbox.Text = class5.basic_netincome.ToString("n");
    }


    private void hono_numhrsTxtbox_TextChanged(object sender, EventArgs e) {
      // double hono_numhrs = 0, hono_rate = 0, hono_netincome = 0;

      // check hono_numhrs
      try {
        double tempcheck_hononumhrs_isdouble;
        tempcheck_hononumhrs_isdouble = Convert.ToDouble(hono_numhrsTxtbox.Text);
        class5.hono_numhrs = tempcheck_hononumhrs_isdouble;
      }
      catch (Exception asd) {
        MessageBox.Show(asd.Message + " Make sure it is floating point number");
        //hono_numhrsTxtbox.Clear();
        class5.hono_numhrs = 0; // default value if parsing fails
        hono_numhrsTxtbox.Text = "0";
        hono_numhrsTxtbox.Focus();
      }

      // check basic_rate
      if (hono_rateTxtbox.TextLength != 0) {
        try {
          double tempcheck;
          tempcheck = Convert.ToDouble(hono_rateTxtbox.Text);
          class5.hono_rate = tempcheck;
        }
        catch (Exception asd) {
          MessageBox.Show(asd.Message + " Make sure it is floating point number");
          //basic_rateTxtbox.Clear();
          class5.hono_rate = 0;
          hono_rateTxtbox.Text = "0";
          hono_rateTxtbox.Focus();
        }
      }


      // Perform calculation
      class5.hono_netincome = class5.hono_numhrs * class5.hono_rate;
      hono_netincomeTxtbox.Text = class5.hono_netincome.ToString("n");
    }


    private void other_numhrsTxtbox_TextChanged(object sender, EventArgs e) {
      try {
        double tempcheck;
        tempcheck = Convert.ToDouble(other_numhrsTxtbox.Text);
      }
      catch (Exception asd) {
        MessageBox.Show(asd.Message + " Make sure it is a floating point number");
        other_numhrsTxtbox.Text = "0";
        other_numhrsTxtbox.Focus();
      }


      try {
          // samething; alreay declared in Class1 class
          // double other_numhrs = 0, other_rate = 0, other_netincome = 0, grossincome = 0;
          // double basic_netincome = 0, hono_netincome = 0;

          // Try parsing user input safely
          double.TryParse(other_numhrsTxtbox.Text, out class5.other_numhrs);
          double.TryParse(other_rateTxtbox.Text, out class5.other_rate);
          double.TryParse(basic_netincomeTxtbox.Text, out class5.basic_netincome);  // Get basic income
          double.TryParse(hono_netincomeTxtbox.Text, out class5.hono_netincome);    // Get Honorarium income

          // Perform calculation
          class5.other_netincome = class5.other_numhrs * class5.other_rate;
          other_netincomeTxtbox.Text = class5.other_netincome.ToString("n");

          // Compute gross income
          class5.grossincome = class5.basic_netincome + class5.hono_netincome + class5.other_netincome;
          gross_incomeTxtbox.Text = class5.grossincome.ToString("n");


          //////////////////////////////////////////////////////////////////
          //////////////////////////////////////////////////////////////////
          //////////////////////////////////////////////////////////////////
          //SSS contribution based from the current table from SSS (using Loop)
          double sss = 0.00; // Initialize SSS contribution
          double sss_employshare = 54.50; // Start at 54.50 for income >= 1250

          if (class5.grossincome < 1000) {// If below 1000, set SSS to 0
              sss = 0.00;
          }
          else if (class5.grossincome >= 1000 && class5.grossincome <= 1249.99) {// First contribution bracket
              sss = 36.30;
          }
          else if (class5.grossincome >= 15750) {// Maximum contribution
              sss = 581.30;
          }
          else {
              for (double i = 1250; i <= 15249.99; i += 500) {// Step by 500
                  if (class5.grossincome >= i && class5.grossincome <= i + 500) {
                      sss = sss_employshare;
                      break;
                  }
                  sss_employshare += 18.20; // Increase per bracket
              }
          }

          // Display the calculated SSS contribution
          sss_contribTxtbox.Text = sss.ToString("N2");


          //////////////////////////////////////////////////////////////////
          //////////////////////////////////////////////////////////////////
          //////////////////////////////////////////////////////////////////
          //Philhealth contribution based from the current table (using Loop)
          double philhealth = 137.50;

          if (class5.grossincome <= 10000) {
              philhealth_contribTxtbox.Text = "137.50";
          }
          else {
              double philhealth_employshare = 137.50;

              for (double i = 10000; i <= 40000; i += 1000) {
                  philhealth_employshare += 13.75;
                  if (class5.grossincome > i && class5.grossincome <= i + 1000) {

                      philhealth = philhealth_employshare;
                      break; // Stop after finding the correct range
                  }

              }

              philhealth_contribTxtbox.Text = philhealth.ToString("n");





          //////////////////////////////////////////////////////////////////
          //////////////////////////////////////////////////////////////////
          //////////////////////////////////////////////////////////////////
              //tax contribution per month based from new table effective Jan 1, 2023
              double tax = 0;
              if (class5.grossincome <= 10416.67) {// Below PHP 10,417 (Bracket 1)
                  tax = 0;
              }
              else if (class5.grossincome > 10416.67 && class5.grossincome <= 16666.67) {// PHP 10,417 - PHP 16,666 (Bracket 2)
                  tax = (class5.grossincome - 10417) * 0.15;
              }
              else if (class5.grossincome > 16666.67 && class5.grossincome <= 33333.33) {// PHP 16,667 - PHP 33,333 (Bracket 3)
                  tax = 1875 + ((class5.grossincome - 16667) * 0.20);
              }
              else if (class5.grossincome > 33333.33 && class5.grossincome <= 83333.33) {// PHP 33,334 - PHP 83,333 (Bracket 4)
                  tax = 8541.80 + ((class5.grossincome - 33333) * 0.25);
              }
              else if (class5.grossincome > 83333.33 && class5.grossincome <= 333333.33) {// PHP 83,334 - PHP 333,333 (Bracket 5)
                  tax = 35416.80 + ((class5.grossincome - 83333) * 0.30);
              }
              else {// PHP 333,333 and above (Bracket 6)
                  tax = 183541.80 + ((class5.grossincome - 333333) * 0.35);
              }

              tax_contribTxtbox.Text = tax.ToString("n");
              }
        }

        catch (Exception) {
          MessageBox.Show("Invalid Data Entry");
          other_numhrsTxtbox.Clear();
          other_numhrsTxtbox.Focus();
        }




        //////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////
        //PAGIBIG contribution 
        try {
          double pagibigContribution = 200; // Fixed Pag-IBIG contribution
          pagibig_contribTxtbox.Text = pagibigContribution.ToString("n"); // Display contribution

        } catch (Exception ex) {
          MessageBox.Show("Error: " + ex.Message);
        }
      }


      private void others_loanCombo_SelectedIndexChanged(object sender, EventArgs e) {
        if (others_loanCombo.Text == "Other 1") {
          others_loanTxtbox.Text = "500.00";
        }
        else if (others_loanCombo.Text == "Other 2") {
          others_loanTxtbox.Text = "550.00";
        }
        else if (others_loanCombo.Text == "Other 3") {
          others_loanTxtbox.Text = "1550.00";
        }
        else if (others_loanCombo.Text == "Other 4") {
          others_loanTxtbox.Text = "1250.00";
        }
        else {
          MessageBox.Show("No other loan option selected!");
        }
      }


        //////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////
        /// 
        /// text box changes
        /// 
        //////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////

      private void emp_nuTxtbox_TextChanged(object sender, EventArgs e) {
        try {
          int temp_to_check_if_quantity_is_int;
          temp_to_check_if_quantity_is_int = Convert.ToInt32(emp_nuTxtbox.Text);
        }
        catch (Exception asd) {
          MessageBox.Show(asd.Message);
          emp_nuTxtbox.Clear();
          emp_nuTxtbox.Focus();
        }
      }


      private void numDependentTxtbox_TextChanged(object sender, EventArgs e) {
        try {
          int temp_to_check_if_quantity_is_int;
          temp_to_check_if_quantity_is_int = Convert.ToInt32(numDependentTxtbox.Text);
        }
        catch (Exception asd) {
          MessageBox.Show(asd.Message);
          numDependentTxtbox.Clear();
          numDependentTxtbox.Focus();
        }
      }


      private void basic_rateTxtbox_TextChanged(object sender, EventArgs e) { 
        if (basic_rateTxtbox.TextLength != 0) {
          // update the rate 
          try {
            double temp_to_check_if_quantity_is_double;
            temp_to_check_if_quantity_is_double = Convert.ToDouble(basic_rateTxtbox.Text);
          } 
          catch (Exception asd) {
            MessageBox.Show(asd.Message + " Make sure it is floating point number");
            //basic_rateTxtbox.Clear();
            basic_rateTxtbox.Text = "0";
            basic_rateTxtbox.Focus();
          }
        }
      }


      private void hono_rateTxtbox_TextChanged(object sender, EventArgs e) { 
        if (hono_rateTxtbox.TextLength != 0) {
          // update rate 
          try {
            double tempcheck_honorate_isdouble;
            tempcheck_honorate_isdouble = Convert.ToDouble(hono_rateTxtbox.Text);
          } 
          catch (Exception asd) {
            MessageBox.Show(asd.Message + "make sure it is floating point number");
            //hono_rateTxtbox.Clear();
            hono_rateTxtbox.Text = "0";
            hono_rateTxtbox.Focus();
          }
        }
      }



      private void other_rateTxtbox_TextChanged(object sender, EventArgs e) { 
        tryCatchDouble(other_rateTxtbox);
      }


      private void sss_loanTxtbox_TextChanged(object sender, EventArgs e) { 
        tryCatchDouble(sss_loanTxtbox);
      }


      private void pagibig_loanTxtbox_TextChanged(object sender, EventArgs e) { 
        tryCatchDouble(pagibig_loanTxtbox);
      }


      private void FSD_depositTxtbox_TextChanged(object sender, EventArgs e) { 
        tryCatchDouble(FSD_depositTxtbox);
      }


      private void FS_loanTxtbox_TextChanged(object sender, EventArgs e) { 
        tryCatchDouble(FS_loanTxtbox);

      }


      private void sal_loanTxtbox_TextChanged(object sender, EventArgs e) {
        tryCatchDouble(sal_loanTxtbox);
      }


    }
  }
