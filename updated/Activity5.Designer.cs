using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Activity5
{
    partial class Activity5
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.emp_nuTxtbox = new System.Windows.Forms.TextBox();
            this.firstnameTxtbox = new System.Windows.Forms.TextBox();
            this.surTxtbox = new System.Windows.Forms.TextBox();
            this.MNameTxtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.desigTxtbox = new System.Windows.Forms.TextBox();
            this.civil_statusTxtbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DeptNameTxtbox = new System.Windows.Forms.TextBox();
            this.empStatusTxtbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numDependentTxtbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.paydateDatePicker = new System.Windows.Forms.DateTimePicker();
            this.basic_netincomeTxtbox = new System.Windows.Forms.TextBox();
            this.basic_numhrsTxtbox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.basic_rateTxtbox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.hono_netincomeTxtbox = new System.Windows.Forms.TextBox();
            this.hono_numhrsTxtbox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.hono_rateTxtbox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.net_incomeTxtbox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.gross_incomeTxtbox = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.other_netincomeTxtbox = new System.Windows.Forms.TextBox();
            this.other_numhrsTxtbox = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.other_rateTxtbox = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tax_contribTxtbox = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.pagibig_contribTxtbox = new System.Windows.Forms.TextBox();
            this.philhealth_contribTxtbox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.sss_contribTxtbox = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.others_loanCombo = new System.Windows.Forms.ComboBox();
            this.others_loanTxtbox = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.sal_loanTxtbox = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.FS_loanTxtbox = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.FSD_depositTxtbox = new System.Windows.Forms.TextBox();
            this.pagibig_loanTxtbox = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.sss_loanTxtbox = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.total_deducTxtbox = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picpathTxtbox = new System.Windows.Forms.TextBox();
            this.browse_btn = new System.Windows.Forms.Button();
            this.printPayslip_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.previewPayslip_btn = new System.Windows.Forms.Button();
            this.calc_btn = new System.Windows.Forms.Button();
            this.new_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.payslip_viewListBox = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Firstname:";
            // 
            // emp_nuTxtbox
            // 
            this.emp_nuTxtbox.Location = new System.Drawing.Point(109, 5);
            this.emp_nuTxtbox.Name = "emp_nuTxtbox";
            this.emp_nuTxtbox.Size = new System.Drawing.Size(100, 20);
            this.emp_nuTxtbox.TabIndex = 2;
            // 
            // firstnameTxtbox
            // 
            this.firstnameTxtbox.Location = new System.Drawing.Point(109, 30);
            this.firstnameTxtbox.Name = "firstnameTxtbox";
            this.firstnameTxtbox.Size = new System.Drawing.Size(100, 20);
            this.firstnameTxtbox.TabIndex = 3;
            // 
            // surTxtbox
            // 
            this.surTxtbox.Location = new System.Drawing.Point(109, 81);
            this.surTxtbox.Name = "surTxtbox";
            this.surTxtbox.Size = new System.Drawing.Size(100, 20);
            this.surTxtbox.TabIndex = 7;
            // 
            // MNameTxtbox
            // 
            this.MNameTxtbox.Location = new System.Drawing.Point(109, 55);
            this.MNameTxtbox.Name = "MNameTxtbox";
            this.MNameTxtbox.Size = new System.Drawing.Size(100, 20);
            this.MNameTxtbox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Surname:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Middie Name:";
            // 
            // desigTxtbox
            // 
            this.desigTxtbox.Location = new System.Drawing.Point(109, 131);
            this.desigTxtbox.Name = "desigTxtbox";
            this.desigTxtbox.Size = new System.Drawing.Size(100, 20);
            this.desigTxtbox.TabIndex = 11;
            // 
            // civil_statusTxtbox
            // 
            this.civil_statusTxtbox.Location = new System.Drawing.Point(109, 106);
            this.civil_statusTxtbox.Name = "civil_statusTxtbox";
            this.civil_statusTxtbox.Size = new System.Drawing.Size(100, 20);
            this.civil_statusTxtbox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Designation:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Civil Status:";
            // 
            // DeptNameTxtbox
            // 
            this.DeptNameTxtbox.Location = new System.Drawing.Point(333, 81);
            this.DeptNameTxtbox.Name = "DeptNameTxtbox";
            this.DeptNameTxtbox.Size = new System.Drawing.Size(100, 20);
            this.DeptNameTxtbox.TabIndex = 19;
            // 
            // empStatusTxtbox
            // 
            this.empStatusTxtbox.Location = new System.Drawing.Point(333, 55);
            this.empStatusTxtbox.Name = "empStatusTxtbox";
            this.empStatusTxtbox.Size = new System.Drawing.Size(100, 20);
            this.empStatusTxtbox.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(234, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Department:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(234, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Employee Status:";
            // 
            // numDependentTxtbox
            // 
            this.numDependentTxtbox.Location = new System.Drawing.Point(333, 5);
            this.numDependentTxtbox.Name = "numDependentTxtbox";
            this.numDependentTxtbox.Size = new System.Drawing.Size(100, 20);
            this.numDependentTxtbox.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(234, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Paydate:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(234, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "No. of Dependent(s):";
            // 
            // paydateDatePicker
            // 
            this.paydateDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.paydateDatePicker.Location = new System.Drawing.Point(333, 30);
            this.paydateDatePicker.Name = "paydateDatePicker";
            this.paydateDatePicker.Size = new System.Drawing.Size(100, 20);
            this.paydateDatePicker.TabIndex = 21;
            // 
            // basic_netincomeTxtbox
            // 
            this.basic_netincomeTxtbox.Location = new System.Drawing.Point(105, 71);
            this.basic_netincomeTxtbox.Name = "basic_netincomeTxtbox";
            this.basic_netincomeTxtbox.Size = new System.Drawing.Size(183, 20);
            this.basic_netincomeTxtbox.TabIndex = 27;
            // 
            // basic_numhrsTxtbox
            // 
            this.basic_numhrsTxtbox.Location = new System.Drawing.Point(105, 46);
            this.basic_numhrsTxtbox.Name = "basic_numhrsTxtbox";
            this.basic_numhrsTxtbox.Size = new System.Drawing.Size(183, 20);
            this.basic_numhrsTxtbox.TabIndex = 26;
            this.basic_numhrsTxtbox.TextChanged += new System.EventHandler(this.basic_numhrsTxtbox_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Income Per Cut Off:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "No of Hours/Cut off:";
            // 
            // basic_rateTxtbox
            // 
            this.basic_rateTxtbox.Location = new System.Drawing.Point(105, 21);
            this.basic_rateTxtbox.Name = "basic_rateTxtbox";
            this.basic_rateTxtbox.Size = new System.Drawing.Size(183, 20);
            this.basic_rateTxtbox.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Rate/Hour";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.basic_netincomeTxtbox);
            this.groupBox1.Controls.Add(this.basic_numhrsTxtbox);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.basic_rateTxtbox);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(10, 185);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 110);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BASICPAY";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.hono_netincomeTxtbox);
            this.groupBox2.Controls.Add(this.hono_numhrsTxtbox);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.hono_rateTxtbox);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Location = new System.Drawing.Point(10, 301);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 110);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "HONORARIUM";
            // 
            // hono_netincomeTxtbox
            // 
            this.hono_netincomeTxtbox.Location = new System.Drawing.Point(119, 71);
            this.hono_netincomeTxtbox.Name = "hono_netincomeTxtbox";
            this.hono_netincomeTxtbox.Size = new System.Drawing.Size(169, 20);
            this.hono_netincomeTxtbox.TabIndex = 27;
            // 
            // hono_numhrsTxtbox
            // 
            this.hono_numhrsTxtbox.Location = new System.Drawing.Point(105, 46);
            this.hono_numhrsTxtbox.Name = "hono_numhrsTxtbox";
            this.hono_numhrsTxtbox.Size = new System.Drawing.Size(183, 20);
            this.hono_numhrsTxtbox.TabIndex = 26;
            this.hono_numhrsTxtbox.TextChanged += new System.EventHandler(this.hono_numhrsTxtbox_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 74);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Total Honorarium Pay:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 49);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "No of Hours/Cut off:";
            // 
            // hono_rateTxtbox
            // 
            this.hono_rateTxtbox.Location = new System.Drawing.Point(105, 21);
            this.hono_rateTxtbox.Name = "hono_rateTxtbox";
            this.hono_rateTxtbox.Size = new System.Drawing.Size(183, 20);
            this.hono_rateTxtbox.TabIndex = 23;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 23);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 13);
            this.label16.TabIndex = 22;
            this.label16.Text = "Rate/Hour:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.net_incomeTxtbox);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.gross_incomeTxtbox);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Location = new System.Drawing.Point(10, 531);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(349, 78);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "INCOME SUMMARY";
            // 
            // net_incomeTxtbox
            // 
            this.net_incomeTxtbox.Location = new System.Drawing.Point(105, 46);
            this.net_incomeTxtbox.Name = "net_incomeTxtbox";
            this.net_incomeTxtbox.Size = new System.Drawing.Size(183, 20);
            this.net_incomeTxtbox.TabIndex = 26;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(7, 49);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(77, 13);
            this.label18.TabIndex = 24;
            this.label18.Text = "NET INCOME:";
            // 
            // gross_incomeTxtbox
            // 
            this.gross_incomeTxtbox.Location = new System.Drawing.Point(105, 21);
            this.gross_incomeTxtbox.Name = "gross_incomeTxtbox";
            this.gross_incomeTxtbox.Size = new System.Drawing.Size(183, 20);
            this.gross_incomeTxtbox.TabIndex = 23;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(7, 23);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(93, 13);
            this.label19.TabIndex = 22;
            this.label19.Text = "GROSS INCOME:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.other_netincomeTxtbox);
            this.groupBox4.Controls.Add(this.other_numhrsTxtbox);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.other_rateTxtbox);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Location = new System.Drawing.Point(10, 416);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(349, 110);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "OTHER INCOME";
            // 
            // other_netincomeTxtbox
            // 
            this.other_netincomeTxtbox.Location = new System.Drawing.Point(119, 71);
            this.other_netincomeTxtbox.Name = "other_netincomeTxtbox";
            this.other_netincomeTxtbox.Size = new System.Drawing.Size(169, 20);
            this.other_netincomeTxtbox.TabIndex = 27;
            // 
            // other_numhrsTxtbox
            // 
            this.other_numhrsTxtbox.Location = new System.Drawing.Point(105, 46);
            this.other_numhrsTxtbox.Name = "other_numhrsTxtbox";
            this.other_numhrsTxtbox.Size = new System.Drawing.Size(183, 20);
            this.other_numhrsTxtbox.TabIndex = 26;
            this.other_numhrsTxtbox.TextChanged += new System.EventHandler(this.other_numhrsTxtbox_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(7, 74);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(125, 13);
            this.label20.TabIndex = 25;
            this.label20.Text = "Total Other Income Pay: ";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(7, 49);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(103, 13);
            this.label21.TabIndex = 24;
            this.label21.Text = "No of Hours/Cut off:";
            // 
            // other_rateTxtbox
            // 
            this.other_rateTxtbox.Location = new System.Drawing.Point(105, 21);
            this.other_rateTxtbox.Name = "other_rateTxtbox";
            this.other_rateTxtbox.Size = new System.Drawing.Size(183, 20);
            this.other_rateTxtbox.TabIndex = 23;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(7, 23);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(61, 13);
            this.label22.TabIndex = 22;
            this.label22.Text = "Rate/Hour:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tax_contribTxtbox);
            this.groupBox5.Controls.Add(this.label25);
            this.groupBox5.Controls.Add(this.pagibig_contribTxtbox);
            this.groupBox5.Controls.Add(this.philhealth_contribTxtbox);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.label23);
            this.groupBox5.Controls.Add(this.sss_contribTxtbox);
            this.groupBox5.Controls.Add(this.label24);
            this.groupBox5.Location = new System.Drawing.Point(364, 185);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(336, 136);
            this.groupBox5.TabIndex = 29;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "REGULAR DEDUCTIONS";
            // 
            // tax_contribTxtbox
            // 
            this.tax_contribTxtbox.Location = new System.Drawing.Point(105, 96);
            this.tax_contribTxtbox.Name = "tax_contribTxtbox";
            this.tax_contribTxtbox.Size = new System.Drawing.Size(183, 20);
            this.tax_contribTxtbox.TabIndex = 29;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(7, 99);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(28, 13);
            this.label25.TabIndex = 28;
            this.label25.Text = "Tax:";
            // 
            // pagibig_contribTxtbox
            // 
            this.pagibig_contribTxtbox.Location = new System.Drawing.Point(116, 71);
            this.pagibig_contribTxtbox.Name = "pagibig_contribTxtbox";
            this.pagibig_contribTxtbox.Size = new System.Drawing.Size(173, 20);
            this.pagibig_contribTxtbox.TabIndex = 27;
            // 
            // philhealth_contribTxtbox
            // 
            this.philhealth_contribTxtbox.Location = new System.Drawing.Point(129, 46);
            this.philhealth_contribTxtbox.Name = "philhealth_contribTxtbox";
            this.philhealth_contribTxtbox.Size = new System.Drawing.Size(160, 20);
            this.philhealth_contribTxtbox.TabIndex = 26;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 74);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(104, 13);
            this.label17.TabIndex = 25;
            this.label17.Text = "Pagibig Contribution:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(7, 49);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(117, 13);
            this.label23.TabIndex = 24;
            this.label23.Text = "PhilHealth Contribution:";
            // 
            // sss_contribTxtbox
            // 
            this.sss_contribTxtbox.Location = new System.Drawing.Point(105, 21);
            this.sss_contribTxtbox.Name = "sss_contribTxtbox";
            this.sss_contribTxtbox.Size = new System.Drawing.Size(183, 20);
            this.sss_contribTxtbox.TabIndex = 23;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(7, 23);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(90, 13);
            this.label24.TabIndex = 22;
            this.label24.Text = "SSS Contribution:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.others_loanCombo);
            this.groupBox6.Controls.Add(this.others_loanTxtbox);
            this.groupBox6.Controls.Add(this.label31);
            this.groupBox6.Controls.Add(this.sal_loanTxtbox);
            this.groupBox6.Controls.Add(this.label30);
            this.groupBox6.Controls.Add(this.FS_loanTxtbox);
            this.groupBox6.Controls.Add(this.label26);
            this.groupBox6.Controls.Add(this.FSD_depositTxtbox);
            this.groupBox6.Controls.Add(this.pagibig_loanTxtbox);
            this.groupBox6.Controls.Add(this.label27);
            this.groupBox6.Controls.Add(this.label28);
            this.groupBox6.Controls.Add(this.sss_loanTxtbox);
            this.groupBox6.Controls.Add(this.label29);
            this.groupBox6.Location = new System.Drawing.Point(364, 327);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(336, 199);
            this.groupBox6.TabIndex = 30;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "OTHER DEDUCTIONS";
            // 
            // others_loanCombo
            // 
            this.others_loanCombo.FormattingEnabled = true;
            this.others_loanCombo.Location = new System.Drawing.Point(105, 146);
            this.others_loanCombo.Name = "others_loanCombo";
            this.others_loanCombo.Size = new System.Drawing.Size(183, 21);
            this.others_loanCombo.TabIndex = 34;
            this.others_loanCombo.SelectedIndexChanged += new System.EventHandler(this.others_loanCombo_SelectedIndexChanged);
            // 
            // others_loanTxtbox
            // 
            this.others_loanTxtbox.Location = new System.Drawing.Point(105, 172);
            this.others_loanTxtbox.Name = "others_loanTxtbox";
            this.others_loanTxtbox.Size = new System.Drawing.Size(183, 20);
            this.others_loanTxtbox.TabIndex = 33;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(7, 149);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(41, 13);
            this.label31.TabIndex = 32;
            this.label31.Text = "Others:";
            // 
            // sal_loanTxtbox
            // 
            this.sal_loanTxtbox.Location = new System.Drawing.Point(105, 121);
            this.sal_loanTxtbox.Name = "sal_loanTxtbox";
            this.sal_loanTxtbox.Size = new System.Drawing.Size(183, 20);
            this.sal_loanTxtbox.TabIndex = 31;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(7, 124);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(66, 13);
            this.label30.TabIndex = 30;
            this.label30.Text = "Salary Loan:";
            // 
            // FS_loanTxtbox
            // 
            this.FS_loanTxtbox.Location = new System.Drawing.Point(112, 96);
            this.FS_loanTxtbox.Name = "FS_loanTxtbox";
            this.FS_loanTxtbox.Size = new System.Drawing.Size(176, 20);
            this.FS_loanTxtbox.TabIndex = 29;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(7, 99);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(112, 13);
            this.label26.TabIndex = 28;
            this.label26.Text = "Faculty Savings Loan:";
            // 
            // FSD_depositTxtbox
            // 
            this.FSD_depositTxtbox.Location = new System.Drawing.Point(127, 71);
            this.FSD_depositTxtbox.Name = "FSD_depositTxtbox";
            this.FSD_depositTxtbox.Size = new System.Drawing.Size(162, 20);
            this.FSD_depositTxtbox.TabIndex = 27;
            // 
            // pagibig_loanTxtbox
            // 
            this.pagibig_loanTxtbox.Location = new System.Drawing.Point(105, 46);
            this.pagibig_loanTxtbox.Name = "pagibig_loanTxtbox";
            this.pagibig_loanTxtbox.Size = new System.Drawing.Size(183, 20);
            this.pagibig_loanTxtbox.TabIndex = 26;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(7, 74);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(124, 13);
            this.label27.TabIndex = 25;
            this.label27.Text = "Faculty Savings Deposit:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(7, 49);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(80, 13);
            this.label28.TabIndex = 24;
            this.label28.Text = "PAGIBIG Loan:";
            // 
            // sss_loanTxtbox
            // 
            this.sss_loanTxtbox.Location = new System.Drawing.Point(105, 21);
            this.sss_loanTxtbox.Name = "sss_loanTxtbox";
            this.sss_loanTxtbox.Size = new System.Drawing.Size(183, 20);
            this.sss_loanTxtbox.TabIndex = 23;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(7, 23);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(58, 13);
            this.label29.TabIndex = 22;
            this.label29.Text = "SSS Loan:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.total_deducTxtbox);
            this.groupBox7.Controls.Add(this.label33);
            this.groupBox7.Location = new System.Drawing.Point(364, 531);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(336, 78);
            this.groupBox7.TabIndex = 32;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "DEDUCTION SUMMARY";
            // 
            // total_deducTxtbox
            // 
            this.total_deducTxtbox.Location = new System.Drawing.Point(105, 21);
            this.total_deducTxtbox.Multiline = true;
            this.total_deducTxtbox.Name = "total_deducTxtbox";
            this.total_deducTxtbox.Size = new System.Drawing.Size(183, 46);
            this.total_deducTxtbox.TabIndex = 23;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(7, 23);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(91, 13);
            this.label33.TabIndex = 22;
            this.label33.Text = "Total Deductions:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(536, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(165, 146);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // picpathTxtbox
            // 
            this.picpathTxtbox.Location = new System.Drawing.Point(579, 101);
            this.picpathTxtbox.Name = "picpathTxtbox";
            this.picpathTxtbox.Size = new System.Drawing.Size(86, 20);
            this.picpathTxtbox.TabIndex = 34;
            // 
            // browse_btn
            // 
            this.browse_btn.Location = new System.Drawing.Point(587, 156);
            this.browse_btn.Name = "browse_btn";
            this.browse_btn.Size = new System.Drawing.Size(64, 20);
            this.browse_btn.TabIndex = 35;
            this.browse_btn.Text = "BROWSE";
            this.browse_btn.UseVisualStyleBackColor = true;
            this.browse_btn.Click += new System.EventHandler(this.browse_btn_Click);
            // 
            // printPayslip_btn
            // 
            this.printPayslip_btn.Location = new System.Drawing.Point(306, 614);
            this.printPayslip_btn.Name = "printPayslip_btn";
            this.printPayslip_btn.Size = new System.Drawing.Size(126, 24);
            this.printPayslip_btn.TabIndex = 40;
            this.printPayslip_btn.Text = "PRINT PAYSLIP";
            this.printPayslip_btn.UseVisualStyleBackColor = true;
            this.printPayslip_btn.Click += new System.EventHandler(this.printPayslip_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(207, 614);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(93, 24);
            this.cancel_btn.TabIndex = 39;
            this.cancel_btn.Text = "CANCEL";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // previewPayslip_btn
            // 
            this.previewPayslip_btn.Location = new System.Drawing.Point(437, 614);
            this.previewPayslip_btn.Name = "previewPayslip_btn";
            this.previewPayslip_btn.Size = new System.Drawing.Size(165, 24);
            this.previewPayslip_btn.TabIndex = 41;
            this.previewPayslip_btn.Text = "PREVIEW PAYSLIP DETAILS";
            this.previewPayslip_btn.UseVisualStyleBackColor = true;
            this.previewPayslip_btn.Click += new System.EventHandler(this.previewPayslip_btn_Click);
            // 
            // calc_btn
            // 
            this.calc_btn.Location = new System.Drawing.Point(10, 614);
            this.calc_btn.Name = "calc_btn";
            this.calc_btn.Size = new System.Drawing.Size(93, 24);
            this.calc_btn.TabIndex = 42;
            this.calc_btn.Text = "CALCULATE";
            this.calc_btn.UseVisualStyleBackColor = true;
            this.calc_btn.Click += new System.EventHandler(this.calc_btn_Click);
            // 
            // new_btn
            // 
            this.new_btn.Location = new System.Drawing.Point(109, 614);
            this.new_btn.Name = "new_btn";
            this.new_btn.Size = new System.Drawing.Size(93, 24);
            this.new_btn.TabIndex = 43;
            this.new_btn.Text = "NEW";
            this.new_btn.UseVisualStyleBackColor = true;
            this.new_btn.Click += new System.EventHandler(this.new_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(607, 614);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(93, 24);
            this.exit_btn.TabIndex = 44;
            this.exit_btn.Text = "EXIT";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.payslip_viewListBox);
            this.groupBox8.Location = new System.Drawing.Point(705, 5);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(459, 634);
            this.groupBox8.TabIndex = 45;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "groupBox8";
            // 
            // payslip_viewListBox
            // 
            this.payslip_viewListBox.FormattingEnabled = true;
            this.payslip_viewListBox.Location = new System.Drawing.Point(5, 25);
            this.payslip_viewListBox.Name = "payslip_viewListBox";
            this.payslip_viewListBox.Size = new System.Drawing.Size(449, 602);
            this.payslip_viewListBox.TabIndex = 0;
            // 
            // Activity5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1174, 649);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.new_btn);
            this.Controls.Add(this.calc_btn);
            this.Controls.Add(this.previewPayslip_btn);
            this.Controls.Add(this.printPayslip_btn);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.browse_btn);
            this.Controls.Add(this.picpathTxtbox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.paydateDatePicker);
            this.Controls.Add(this.DeptNameTxtbox);
            this.Controls.Add(this.empStatusTxtbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numDependentTxtbox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.desigTxtbox);
            this.Controls.Add(this.civil_statusTxtbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.surTxtbox);
            this.Controls.Add(this.MNameTxtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.firstnameTxtbox);
            this.Controls.Add(this.emp_nuTxtbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Activity5";
            this.Text = "Example 5 ";
            this.Load += new System.EventHandler(this.Activity5_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox emp_nuTxtbox;
        private TextBox firstnameTxtbox;
        private TextBox surTxtbox;
        private TextBox MNameTxtbox;
        private Label label3;
        private Label label4;
        private TextBox desigTxtbox;
        private TextBox civil_statusTxtbox;
        private Label label5;
        private Label label6;
        private TextBox DeptNameTxtbox;
        private TextBox empStatusTxtbox;
        private Label label7;
        private Label label8;
        private TextBox numDependentTxtbox;
        private Label label9;
        private Label label10;
        private DateTimePicker paydateDatePicker;
        private TextBox basic_netincomeTxtbox;
        private TextBox basic_numhrsTxtbox;
        private Label label11;
        private Label label12;
        private TextBox basic_rateTxtbox;
        private Label label13;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox hono_netincomeTxtbox;
        private TextBox hono_numhrsTxtbox;
        private Label label14;
        private Label label15;
        private TextBox hono_rateTxtbox;
        private Label label16;
        private GroupBox groupBox3;
        private TextBox net_incomeTxtbox;
        private Label label18;
        private TextBox gross_incomeTxtbox;
        private Label label19;
        private GroupBox groupBox4;
        private TextBox other_netincomeTxtbox;
        private TextBox other_numhrsTxtbox;
        private Label label20;
        private Label label21;
        private TextBox other_rateTxtbox;
        private Label label22;
        private GroupBox groupBox5;
        private TextBox tax_contribTxtbox;
        private Label label25;
        private TextBox pagibig_contribTxtbox;
        private TextBox philhealth_contribTxtbox;
        private Label label17;
        private Label label23;
        private TextBox sss_contribTxtbox;
        private Label label24;
        private GroupBox groupBox6;
        private TextBox others_loanTxtbox;
        private Label label31;
        private TextBox sal_loanTxtbox;
        private Label label30;
        private TextBox FS_loanTxtbox;
        private Label label26;
        private TextBox FSD_depositTxtbox;
        private TextBox pagibig_loanTxtbox;
        private Label label27;
        private Label label28;
        private TextBox sss_loanTxtbox;
        private Label label29;
        private ComboBox others_loanCombo;
        private GroupBox groupBox7;
        private TextBox total_deducTxtbox;
        private Label label33;
        private PictureBox pictureBox2;
        private TextBox picpathTxtbox;
        private Button browse_btn;
        private Button printPayslip_btn;
        private Button cancel_btn;
        private Button previewPayslip_btn;
        private Button calc_btn;
        private Button new_btn;
        private Button exit_btn;
        private GroupBox groupBox8;
        public ListBox payslip_viewListBox;
    }
}
