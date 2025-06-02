using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Activity5
{
    partial class Payroll
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
            label1 = new Label();
            label2 = new Label();
            emp_nuTxtbox = new TextBox();
            firstnameTxtbox = new TextBox();
            surTxtbox = new TextBox();
            MNameTxtbox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            desigTxtbox = new TextBox();
            civil_statusTxtbox = new TextBox();
            label5 = new Label();
            label6 = new Label();
            DeptNameTxtbox = new TextBox();
            empStatusTxtbox = new TextBox();
            label7 = new Label();
            label8 = new Label();
            numDependentTxtbox = new TextBox();
            label9 = new Label();
            label10 = new Label();
            paydateDatePicker = new DateTimePicker();
            basic_netincomeTxtbox = new TextBox();
            basic_numhrsTxtbox = new TextBox();
            label11 = new Label();
            label12 = new Label();
            basic_rateTxtbox = new TextBox();
            label13 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            hono_netincomeTxtbox = new TextBox();
            hono_numhrsTxtbox = new TextBox();
            label14 = new Label();
            label15 = new Label();
            hono_rateTxtbox = new TextBox();
            label16 = new Label();
            groupBox3 = new GroupBox();
            net_incomeTxtbox = new TextBox();
            label18 = new Label();
            gross_incomeTxtbox = new TextBox();
            label19 = new Label();
            groupBox4 = new GroupBox();
            other_netincomeTxtbox = new TextBox();
            other_numhrsTxtbox = new TextBox();
            label20 = new Label();
            label21 = new Label();
            other_rateTxtbox = new TextBox();
            label22 = new Label();
            groupBox5 = new GroupBox();
            tax_contribTxtbox = new TextBox();
            label25 = new Label();
            pagibig_contribTxtbox = new TextBox();
            philhealth_contribTxtbox = new TextBox();
            label17 = new Label();
            label23 = new Label();
            sss_contribTxtbox = new TextBox();
            label24 = new Label();
            groupBox6 = new GroupBox();
            others_loanCombo = new ComboBox();
            others_loanTxtbox = new TextBox();
            label31 = new Label();
            sal_loanTxtbox = new TextBox();
            label30 = new Label();
            FS_loanTxtbox = new TextBox();
            label26 = new Label();
            FSD_depositTxtbox = new TextBox();
            pagibig_loanTxtbox = new TextBox();
            label27 = new Label();
            label28 = new Label();
            sss_loanTxtbox = new TextBox();
            label29 = new Label();
            groupBox7 = new GroupBox();
            total_deducTxtbox = new TextBox();
            label33 = new Label();
            pictureBox2 = new PictureBox();
            picpathTxtbox = new TextBox();
            browse_btn = new Button();
            printPayslip_btn = new Button();
            cancel_btn = new Button();
            previewPayslip_btn = new Button();
            calc_btn = new Button();
            new_btn = new Button();
            exit_btn = new Button();
            groupBox8 = new GroupBox();
            payslip_viewListBox = new ListBox();
            searchbtn = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox8.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 0;
            label1.Text = "Employee Number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 38);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 1;
            label2.Text = "Firstname:";
            // 
            // emp_nuTxtbox
            // 
            emp_nuTxtbox.Location = new Point(127, 6);
            emp_nuTxtbox.Margin = new Padding(4, 3, 4, 3);
            emp_nuTxtbox.Name = "emp_nuTxtbox";
            emp_nuTxtbox.Size = new Size(116, 23);
            emp_nuTxtbox.TabIndex = 2;
            emp_nuTxtbox.TextChanged += emp_nuTxtbox_TextChanged;
            // 
            // firstnameTxtbox
            // 
            firstnameTxtbox.Location = new Point(127, 35);
            firstnameTxtbox.Margin = new Padding(4, 3, 4, 3);
            firstnameTxtbox.Name = "firstnameTxtbox";
            firstnameTxtbox.Size = new Size(116, 23);
            firstnameTxtbox.TabIndex = 3;
            // 
            // surTxtbox
            // 
            surTxtbox.Location = new Point(127, 93);
            surTxtbox.Margin = new Padding(4, 3, 4, 3);
            surTxtbox.Name = "surTxtbox";
            surTxtbox.Size = new Size(116, 23);
            surTxtbox.TabIndex = 7;
            // 
            // MNameTxtbox
            // 
            MNameTxtbox.Location = new Point(127, 63);
            MNameTxtbox.Margin = new Padding(4, 3, 4, 3);
            MNameTxtbox.Name = "MNameTxtbox";
            MNameTxtbox.Size = new Size(116, 23);
            MNameTxtbox.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 96);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 5;
            label3.Text = "Surname:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 67);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 4;
            label4.Text = "Middie Name:";
            // 
            // desigTxtbox
            // 
            desigTxtbox.Location = new Point(127, 151);
            desigTxtbox.Margin = new Padding(4, 3, 4, 3);
            desigTxtbox.Name = "desigTxtbox";
            desigTxtbox.Size = new Size(116, 23);
            desigTxtbox.TabIndex = 11;
            // 
            // civil_statusTxtbox
            // 
            civil_statusTxtbox.Location = new Point(127, 122);
            civil_statusTxtbox.Margin = new Padding(4, 3, 4, 3);
            civil_statusTxtbox.Name = "civil_statusTxtbox";
            civil_statusTxtbox.Size = new Size(116, 23);
            civil_statusTxtbox.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 153);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 9;
            label5.Text = "Designation:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 125);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(68, 15);
            label6.TabIndex = 8;
            label6.Text = "Civil Status:";
            // 
            // DeptNameTxtbox
            // 
            DeptNameTxtbox.Location = new Point(485, 94);
            DeptNameTxtbox.Margin = new Padding(4, 3, 4, 3);
            DeptNameTxtbox.Name = "DeptNameTxtbox";
            DeptNameTxtbox.Size = new Size(116, 23);
            DeptNameTxtbox.TabIndex = 19;
            // 
            // empStatusTxtbox
            // 
            empStatusTxtbox.Location = new Point(485, 64);
            empStatusTxtbox.Margin = new Padding(4, 3, 4, 3);
            empStatusTxtbox.Name = "empStatusTxtbox";
            empStatusTxtbox.Size = new Size(116, 23);
            empStatusTxtbox.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(370, 97);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(73, 15);
            label7.TabIndex = 17;
            label7.Text = "Department:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(370, 68);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(97, 15);
            label8.TabIndex = 16;
            label8.Text = "Employee Status:";
            // 
            // numDependentTxtbox
            // 
            numDependentTxtbox.Location = new Point(485, 7);
            numDependentTxtbox.Margin = new Padding(4, 3, 4, 3);
            numDependentTxtbox.Name = "numDependentTxtbox";
            numDependentTxtbox.Size = new Size(116, 23);
            numDependentTxtbox.TabIndex = 14;
            numDependentTxtbox.TextChanged += numDependentTxtbox_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(370, 39);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(52, 15);
            label9.TabIndex = 13;
            label9.Text = "Paydate:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(370, 10);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(117, 15);
            label10.TabIndex = 12;
            label10.Text = "No. of Dependent(s):";
            // 
            // paydateDatePicker
            // 
            paydateDatePicker.Format = DateTimePickerFormat.Short;
            paydateDatePicker.Location = new Point(485, 36);
            paydateDatePicker.Margin = new Padding(4, 3, 4, 3);
            paydateDatePicker.Name = "paydateDatePicker";
            paydateDatePicker.Size = new Size(116, 23);
            paydateDatePicker.TabIndex = 21;
            // 
            // basic_netincomeTxtbox
            // 
            basic_netincomeTxtbox.Location = new Point(122, 82);
            basic_netincomeTxtbox.Margin = new Padding(4, 3, 4, 3);
            basic_netincomeTxtbox.Name = "basic_netincomeTxtbox";
            basic_netincomeTxtbox.Size = new Size(213, 23);
            basic_netincomeTxtbox.TabIndex = 27;
            // 
            // basic_numhrsTxtbox
            // 
            basic_numhrsTxtbox.Location = new Point(122, 53);
            basic_numhrsTxtbox.Margin = new Padding(4, 3, 4, 3);
            basic_numhrsTxtbox.Name = "basic_numhrsTxtbox";
            basic_numhrsTxtbox.Size = new Size(213, 23);
            basic_numhrsTxtbox.TabIndex = 26;
            basic_numhrsTxtbox.TextChanged += basic_numhrsTxtbox_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(8, 85);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(112, 15);
            label11.TabIndex = 25;
            label11.Text = "Income Per Cut Off:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(8, 57);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(117, 15);
            label12.TabIndex = 24;
            label12.Text = "No of Hours/Cut off:";
            // 
            // basic_rateTxtbox
            // 
            basic_rateTxtbox.Location = new Point(122, 24);
            basic_rateTxtbox.Margin = new Padding(4, 3, 4, 3);
            basic_rateTxtbox.Name = "basic_rateTxtbox";
            basic_rateTxtbox.Size = new Size(213, 23);
            basic_rateTxtbox.TabIndex = 23;
            basic_rateTxtbox.TextChanged += basic_rateTxtbox_TextChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(8, 27);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(62, 15);
            label13.TabIndex = 22;
            label13.Text = "Rate/Hour";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(basic_netincomeTxtbox);
            groupBox1.Controls.Add(basic_numhrsTxtbox);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(basic_rateTxtbox);
            groupBox1.Controls.Add(label13);
            groupBox1.Location = new Point(12, 213);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(407, 127);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            groupBox1.Text = "BASICPAY";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(hono_netincomeTxtbox);
            groupBox2.Controls.Add(hono_numhrsTxtbox);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(hono_rateTxtbox);
            groupBox2.Controls.Add(label16);
            groupBox2.Location = new Point(12, 347);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(407, 127);
            groupBox2.TabIndex = 29;
            groupBox2.TabStop = false;
            groupBox2.Text = "HONORARIUM";
            // 
            // hono_netincomeTxtbox
            // 
            hono_netincomeTxtbox.Location = new Point(139, 82);
            hono_netincomeTxtbox.Margin = new Padding(4, 3, 4, 3);
            hono_netincomeTxtbox.Name = "hono_netincomeTxtbox";
            hono_netincomeTxtbox.Size = new Size(196, 23);
            hono_netincomeTxtbox.TabIndex = 27;
            // 
            // hono_numhrsTxtbox
            // 
            hono_numhrsTxtbox.Location = new Point(122, 53);
            hono_numhrsTxtbox.Margin = new Padding(4, 3, 4, 3);
            hono_numhrsTxtbox.Name = "hono_numhrsTxtbox";
            hono_numhrsTxtbox.Size = new Size(213, 23);
            hono_numhrsTxtbox.TabIndex = 26;
            hono_numhrsTxtbox.TextChanged += hono_numhrsTxtbox_TextChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(8, 85);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(125, 15);
            label14.TabIndex = 25;
            label14.Text = "Total Honorarium Pay:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(8, 57);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(117, 15);
            label15.TabIndex = 24;
            label15.Text = "No of Hours/Cut off:";
            // 
            // hono_rateTxtbox
            // 
            hono_rateTxtbox.Location = new Point(122, 24);
            hono_rateTxtbox.Margin = new Padding(4, 3, 4, 3);
            hono_rateTxtbox.Name = "hono_rateTxtbox";
            hono_rateTxtbox.Size = new Size(213, 23);
            hono_rateTxtbox.TabIndex = 23;
            hono_rateTxtbox.TextChanged += hono_rateTxtbox_TextChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(8, 27);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(65, 15);
            label16.TabIndex = 22;
            label16.Text = "Rate/Hour:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(net_incomeTxtbox);
            groupBox3.Controls.Add(label18);
            groupBox3.Controls.Add(gross_incomeTxtbox);
            groupBox3.Controls.Add(label19);
            groupBox3.Location = new Point(12, 613);
            groupBox3.Margin = new Padding(4, 3, 4, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 3, 4, 3);
            groupBox3.Size = new Size(407, 90);
            groupBox3.TabIndex = 31;
            groupBox3.TabStop = false;
            groupBox3.Text = "INCOME SUMMARY";
            // 
            // net_incomeTxtbox
            // 
            net_incomeTxtbox.Location = new Point(122, 53);
            net_incomeTxtbox.Margin = new Padding(4, 3, 4, 3);
            net_incomeTxtbox.Name = "net_incomeTxtbox";
            net_incomeTxtbox.Size = new Size(213, 23);
            net_incomeTxtbox.TabIndex = 26;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(8, 57);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(80, 15);
            label18.TabIndex = 24;
            label18.Text = "NET INCOME:";
            // 
            // gross_incomeTxtbox
            // 
            gross_incomeTxtbox.Location = new Point(122, 24);
            gross_incomeTxtbox.Margin = new Padding(4, 3, 4, 3);
            gross_incomeTxtbox.Name = "gross_incomeTxtbox";
            gross_incomeTxtbox.Size = new Size(213, 23);
            gross_incomeTxtbox.TabIndex = 23;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(8, 27);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(95, 15);
            label19.TabIndex = 22;
            label19.Text = "GROSS INCOME:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(other_netincomeTxtbox);
            groupBox4.Controls.Add(other_numhrsTxtbox);
            groupBox4.Controls.Add(label20);
            groupBox4.Controls.Add(label21);
            groupBox4.Controls.Add(other_rateTxtbox);
            groupBox4.Controls.Add(label22);
            groupBox4.Location = new Point(12, 480);
            groupBox4.Margin = new Padding(4, 3, 4, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4, 3, 4, 3);
            groupBox4.Size = new Size(407, 127);
            groupBox4.TabIndex = 30;
            groupBox4.TabStop = false;
            groupBox4.Text = "OTHER INCOME";
            // 
            // other_netincomeTxtbox
            // 
            other_netincomeTxtbox.Location = new Point(139, 82);
            other_netincomeTxtbox.Margin = new Padding(4, 3, 4, 3);
            other_netincomeTxtbox.Name = "other_netincomeTxtbox";
            other_netincomeTxtbox.Size = new Size(196, 23);
            other_netincomeTxtbox.TabIndex = 27;
            // 
            // other_numhrsTxtbox
            // 
            other_numhrsTxtbox.Location = new Point(122, 53);
            other_numhrsTxtbox.Margin = new Padding(4, 3, 4, 3);
            other_numhrsTxtbox.Name = "other_numhrsTxtbox";
            other_numhrsTxtbox.Size = new Size(213, 23);
            other_numhrsTxtbox.TabIndex = 26;
            other_numhrsTxtbox.TextChanged += other_numhrsTxtbox_TextChanged;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(8, 85);
            label20.Margin = new Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new Size(136, 15);
            label20.TabIndex = 25;
            label20.Text = "Total Other Income Pay: ";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(8, 57);
            label21.Margin = new Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new Size(117, 15);
            label21.TabIndex = 24;
            label21.Text = "No of Hours/Cut off:";
            // 
            // other_rateTxtbox
            // 
            other_rateTxtbox.Location = new Point(122, 24);
            other_rateTxtbox.Margin = new Padding(4, 3, 4, 3);
            other_rateTxtbox.Name = "other_rateTxtbox";
            other_rateTxtbox.Size = new Size(213, 23);
            other_rateTxtbox.TabIndex = 23;
            other_rateTxtbox.TextChanged += other_rateTxtbox_TextChanged;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(8, 27);
            label22.Margin = new Padding(4, 0, 4, 0);
            label22.Name = "label22";
            label22.Size = new Size(65, 15);
            label22.TabIndex = 22;
            label22.Text = "Rate/Hour:";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(tax_contribTxtbox);
            groupBox5.Controls.Add(label25);
            groupBox5.Controls.Add(pagibig_contribTxtbox);
            groupBox5.Controls.Add(philhealth_contribTxtbox);
            groupBox5.Controls.Add(label17);
            groupBox5.Controls.Add(label23);
            groupBox5.Controls.Add(sss_contribTxtbox);
            groupBox5.Controls.Add(label24);
            groupBox5.Location = new Point(425, 213);
            groupBox5.Margin = new Padding(4, 3, 4, 3);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(4, 3, 4, 3);
            groupBox5.Size = new Size(392, 157);
            groupBox5.TabIndex = 29;
            groupBox5.TabStop = false;
            groupBox5.Text = "REGULAR DEDUCTIONS";
            // 
            // tax_contribTxtbox
            // 
            tax_contribTxtbox.Location = new Point(122, 111);
            tax_contribTxtbox.Margin = new Padding(4, 3, 4, 3);
            tax_contribTxtbox.Name = "tax_contribTxtbox";
            tax_contribTxtbox.Size = new Size(213, 23);
            tax_contribTxtbox.TabIndex = 29;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(8, 114);
            label25.Margin = new Padding(4, 0, 4, 0);
            label25.Name = "label25";
            label25.Size = new Size(27, 15);
            label25.TabIndex = 28;
            label25.Text = "Tax:";
            // 
            // pagibig_contribTxtbox
            // 
            pagibig_contribTxtbox.Location = new Point(135, 82);
            pagibig_contribTxtbox.Margin = new Padding(4, 3, 4, 3);
            pagibig_contribTxtbox.Name = "pagibig_contribTxtbox";
            pagibig_contribTxtbox.Size = new Size(201, 23);
            pagibig_contribTxtbox.TabIndex = 27;
            // 
            // philhealth_contribTxtbox
            // 
            philhealth_contribTxtbox.Location = new Point(150, 53);
            philhealth_contribTxtbox.Margin = new Padding(4, 3, 4, 3);
            philhealth_contribTxtbox.Name = "philhealth_contribTxtbox";
            philhealth_contribTxtbox.Size = new Size(186, 23);
            philhealth_contribTxtbox.TabIndex = 26;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(8, 85);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(121, 15);
            label17.TabIndex = 25;
            label17.Text = "Pagibig Contribution:";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(8, 57);
            label23.Margin = new Padding(4, 0, 4, 0);
            label23.Name = "label23";
            label23.Size = new Size(136, 15);
            label23.TabIndex = 24;
            label23.Text = "PhilHealth Contribution:";
            // 
            // sss_contribTxtbox
            // 
            sss_contribTxtbox.Location = new Point(122, 24);
            sss_contribTxtbox.Margin = new Padding(4, 3, 4, 3);
            sss_contribTxtbox.Name = "sss_contribTxtbox";
            sss_contribTxtbox.Size = new Size(213, 23);
            sss_contribTxtbox.TabIndex = 23;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(8, 27);
            label24.Margin = new Padding(4, 0, 4, 0);
            label24.Name = "label24";
            label24.Size = new Size(99, 15);
            label24.TabIndex = 22;
            label24.Text = "SSS Contribution:";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(others_loanCombo);
            groupBox6.Controls.Add(others_loanTxtbox);
            groupBox6.Controls.Add(label31);
            groupBox6.Controls.Add(sal_loanTxtbox);
            groupBox6.Controls.Add(label30);
            groupBox6.Controls.Add(FS_loanTxtbox);
            groupBox6.Controls.Add(label26);
            groupBox6.Controls.Add(FSD_depositTxtbox);
            groupBox6.Controls.Add(pagibig_loanTxtbox);
            groupBox6.Controls.Add(label27);
            groupBox6.Controls.Add(label28);
            groupBox6.Controls.Add(sss_loanTxtbox);
            groupBox6.Controls.Add(label29);
            groupBox6.Location = new Point(425, 377);
            groupBox6.Margin = new Padding(4, 3, 4, 3);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(4, 3, 4, 3);
            groupBox6.Size = new Size(392, 230);
            groupBox6.TabIndex = 30;
            groupBox6.TabStop = false;
            groupBox6.Text = "OTHER DEDUCTIONS";
            // 
            // others_loanCombo
            // 
            others_loanCombo.FormattingEnabled = true;
            others_loanCombo.Location = new Point(122, 168);
            others_loanCombo.Margin = new Padding(4, 3, 4, 3);
            others_loanCombo.Name = "others_loanCombo";
            others_loanCombo.Size = new Size(213, 23);
            others_loanCombo.TabIndex = 34;
            others_loanCombo.SelectedIndexChanged += others_loanCombo_SelectedIndexChanged;
            // 
            // others_loanTxtbox
            // 
            others_loanTxtbox.Location = new Point(122, 198);
            others_loanTxtbox.Margin = new Padding(4, 3, 4, 3);
            others_loanTxtbox.Name = "others_loanTxtbox";
            others_loanTxtbox.Size = new Size(213, 23);
            others_loanTxtbox.TabIndex = 33;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(8, 172);
            label31.Margin = new Padding(4, 0, 4, 0);
            label31.Name = "label31";
            label31.Size = new Size(45, 15);
            label31.TabIndex = 32;
            label31.Text = "Others:";
            // 
            // sal_loanTxtbox
            // 
            sal_loanTxtbox.Location = new Point(122, 140);
            sal_loanTxtbox.Margin = new Padding(4, 3, 4, 3);
            sal_loanTxtbox.Name = "sal_loanTxtbox";
            sal_loanTxtbox.Size = new Size(213, 23);
            sal_loanTxtbox.TabIndex = 31;
            sal_loanTxtbox.TextChanged += sal_loanTxtbox_TextChanged;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(8, 143);
            label30.Margin = new Padding(4, 0, 4, 0);
            label30.Name = "label30";
            label30.Size = new Size(70, 15);
            label30.TabIndex = 30;
            label30.Text = "Salary Loan:";
            // 
            // FS_loanTxtbox
            // 
            FS_loanTxtbox.Location = new Point(131, 111);
            FS_loanTxtbox.Margin = new Padding(4, 3, 4, 3);
            FS_loanTxtbox.Name = "FS_loanTxtbox";
            FS_loanTxtbox.Size = new Size(205, 23);
            FS_loanTxtbox.TabIndex = 29;
            FS_loanTxtbox.TextChanged += FS_loanTxtbox_TextChanged;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(8, 114);
            label26.Margin = new Padding(4, 0, 4, 0);
            label26.Name = "label26";
            label26.Size = new Size(120, 15);
            label26.TabIndex = 28;
            label26.Text = "Faculty Savings Loan:";
            // 
            // FSD_depositTxtbox
            // 
            FSD_depositTxtbox.Location = new Point(148, 82);
            FSD_depositTxtbox.Margin = new Padding(4, 3, 4, 3);
            FSD_depositTxtbox.Name = "FSD_depositTxtbox";
            FSD_depositTxtbox.Size = new Size(188, 23);
            FSD_depositTxtbox.TabIndex = 27;
            FSD_depositTxtbox.TextChanged += FSD_depositTxtbox_TextChanged;
            // 
            // pagibig_loanTxtbox
            // 
            pagibig_loanTxtbox.Location = new Point(122, 53);
            pagibig_loanTxtbox.Margin = new Padding(4, 3, 4, 3);
            pagibig_loanTxtbox.Name = "pagibig_loanTxtbox";
            pagibig_loanTxtbox.Size = new Size(213, 23);
            pagibig_loanTxtbox.TabIndex = 26;
            pagibig_loanTxtbox.TextChanged += pagibig_loanTxtbox_TextChanged;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(8, 85);
            label27.Margin = new Padding(4, 0, 4, 0);
            label27.Name = "label27";
            label27.Size = new Size(134, 15);
            label27.TabIndex = 25;
            label27.Text = "Faculty Savings Deposit:";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(8, 57);
            label28.Margin = new Padding(4, 0, 4, 0);
            label28.Name = "label28";
            label28.Size = new Size(82, 15);
            label28.TabIndex = 24;
            label28.Text = "PAGIBIG Loan:";
            // 
            // sss_loanTxtbox
            // 
            sss_loanTxtbox.Location = new Point(122, 24);
            sss_loanTxtbox.Margin = new Padding(4, 3, 4, 3);
            sss_loanTxtbox.Name = "sss_loanTxtbox";
            sss_loanTxtbox.Size = new Size(213, 23);
            sss_loanTxtbox.TabIndex = 23;
            sss_loanTxtbox.TextChanged += sss_loanTxtbox_TextChanged;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(8, 27);
            label29.Margin = new Padding(4, 0, 4, 0);
            label29.Name = "label29";
            label29.Size = new Size(57, 15);
            label29.TabIndex = 22;
            label29.Text = "SSS Loan:";
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(total_deducTxtbox);
            groupBox7.Controls.Add(label33);
            groupBox7.Location = new Point(425, 613);
            groupBox7.Margin = new Padding(4, 3, 4, 3);
            groupBox7.Name = "groupBox7";
            groupBox7.Padding = new Padding(4, 3, 4, 3);
            groupBox7.Size = new Size(392, 90);
            groupBox7.TabIndex = 32;
            groupBox7.TabStop = false;
            groupBox7.Text = "DEDUCTION SUMMARY";
            // 
            // total_deducTxtbox
            // 
            total_deducTxtbox.Location = new Point(122, 24);
            total_deducTxtbox.Margin = new Padding(4, 3, 4, 3);
            total_deducTxtbox.Multiline = true;
            total_deducTxtbox.Name = "total_deducTxtbox";
            total_deducTxtbox.Size = new Size(213, 52);
            total_deducTxtbox.TabIndex = 23;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Location = new Point(8, 27);
            label33.Margin = new Padding(4, 0, 4, 0);
            label33.Name = "label33";
            label33.Size = new Size(98, 15);
            label33.TabIndex = 22;
            label33.Text = "Total Deductions:";
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Location = new Point(625, 6);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(192, 168);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 33;
            pictureBox2.TabStop = false;
            // 
            // picpathTxtbox
            // 
            picpathTxtbox.Location = new Point(676, 117);
            picpathTxtbox.Margin = new Padding(4, 3, 4, 3);
            picpathTxtbox.Name = "picpathTxtbox";
            picpathTxtbox.Size = new Size(100, 23);
            picpathTxtbox.TabIndex = 34;
            // 
            // browse_btn
            // 
            browse_btn.BackColor = Color.Teal;
            browse_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            browse_btn.ForeColor = SystemColors.ButtonFace;
            browse_btn.Location = new Point(685, 180);
            browse_btn.Margin = new Padding(4, 3, 4, 3);
            browse_btn.Name = "browse_btn";
            browse_btn.Size = new Size(75, 23);
            browse_btn.TabIndex = 35;
            browse_btn.Text = "BROWSE";
            browse_btn.UseVisualStyleBackColor = false;
            browse_btn.Click += browse_btn_Click;
            // 
            // printPayslip_btn
            // 
            printPayslip_btn.BackColor = Color.Teal;
            printPayslip_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            printPayslip_btn.ForeColor = SystemColors.ButtonFace;
            printPayslip_btn.Location = new Point(357, 708);
            printPayslip_btn.Margin = new Padding(4, 3, 4, 3);
            printPayslip_btn.Name = "printPayslip_btn";
            printPayslip_btn.Size = new Size(147, 28);
            printPayslip_btn.TabIndex = 40;
            printPayslip_btn.Text = "PRINT PAYSLIP";
            printPayslip_btn.UseVisualStyleBackColor = false;
            printPayslip_btn.Click += printPayslip_btn_Click;
            // 
            // cancel_btn
            // 
            cancel_btn.BackColor = Color.Teal;
            cancel_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            cancel_btn.ForeColor = SystemColors.ButtonFace;
            cancel_btn.Location = new Point(241, 708);
            cancel_btn.Margin = new Padding(4, 3, 4, 3);
            cancel_btn.Name = "cancel_btn";
            cancel_btn.Size = new Size(108, 28);
            cancel_btn.TabIndex = 39;
            cancel_btn.Text = "CANCEL";
            cancel_btn.UseVisualStyleBackColor = false;
            cancel_btn.Click += cancel_btn_Click;
            // 
            // previewPayslip_btn
            // 
            previewPayslip_btn.BackColor = Color.Teal;
            previewPayslip_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            previewPayslip_btn.ForeColor = SystemColors.ButtonFace;
            previewPayslip_btn.Location = new Point(510, 708);
            previewPayslip_btn.Margin = new Padding(4, 3, 4, 3);
            previewPayslip_btn.Name = "previewPayslip_btn";
            previewPayslip_btn.Size = new Size(192, 28);
            previewPayslip_btn.TabIndex = 41;
            previewPayslip_btn.Text = "PREVIEW PAYSLIP DETAILS";
            previewPayslip_btn.UseVisualStyleBackColor = false;
            previewPayslip_btn.Click += previewPayslip_btn_Click;
            // 
            // calc_btn
            // 
            calc_btn.BackColor = Color.Teal;
            calc_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            calc_btn.ForeColor = SystemColors.ButtonFace;
            calc_btn.Location = new Point(12, 708);
            calc_btn.Margin = new Padding(4, 3, 4, 3);
            calc_btn.Name = "calc_btn";
            calc_btn.Size = new Size(108, 28);
            calc_btn.TabIndex = 42;
            calc_btn.Text = "CALCULATE";
            calc_btn.UseVisualStyleBackColor = false;
            calc_btn.Click += calc_btn_Click;
            // 
            // new_btn
            // 
            new_btn.BackColor = Color.Teal;
            new_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            new_btn.ForeColor = SystemColors.ButtonFace;
            new_btn.Location = new Point(127, 708);
            new_btn.Margin = new Padding(4, 3, 4, 3);
            new_btn.Name = "new_btn";
            new_btn.Size = new Size(108, 28);
            new_btn.TabIndex = 43;
            new_btn.Text = "NEW";
            new_btn.UseVisualStyleBackColor = false;
            new_btn.Click += new_btn_Click;
            // 
            // exit_btn
            // 
            exit_btn.BackColor = Color.Teal;
            exit_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            exit_btn.ForeColor = SystemColors.ButtonFace;
            exit_btn.Location = new Point(708, 708);
            exit_btn.Margin = new Padding(4, 3, 4, 3);
            exit_btn.Name = "exit_btn";
            exit_btn.Size = new Size(108, 28);
            exit_btn.TabIndex = 44;
            exit_btn.Text = "EXIT";
            exit_btn.UseVisualStyleBackColor = false;
            exit_btn.Click += exit_btn_Click;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(payslip_viewListBox);
            groupBox8.Location = new Point(822, 6);
            groupBox8.Margin = new Padding(4, 3, 4, 3);
            groupBox8.Name = "groupBox8";
            groupBox8.Padding = new Padding(4, 3, 4, 3);
            groupBox8.Size = new Size(536, 732);
            groupBox8.TabIndex = 45;
            groupBox8.TabStop = false;
            groupBox8.Text = "groupBox8";
            // 
            // payslip_viewListBox
            // 
            payslip_viewListBox.FormattingEnabled = true;
            payslip_viewListBox.ItemHeight = 15;
            payslip_viewListBox.Location = new Point(6, 29);
            payslip_viewListBox.Margin = new Padding(4, 3, 4, 3);
            payslip_viewListBox.Name = "payslip_viewListBox";
            payslip_viewListBox.Size = new Size(523, 694);
            payslip_viewListBox.TabIndex = 0;
            // 
            // searchbtn
            // 
            searchbtn.BackColor = Color.Teal;
            searchbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchbtn.ForeColor = SystemColors.ButtonFace;
            searchbtn.Location = new Point(262, 6);
            searchbtn.Name = "searchbtn";
            searchbtn.Size = new Size(75, 23);
            searchbtn.TabIndex = 46;
            searchbtn.Text = "SEARCH";
            searchbtn.UseVisualStyleBackColor = false;
            // 
            // Payroll
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(1370, 749);
            Controls.Add(searchbtn);
            Controls.Add(groupBox8);
            Controls.Add(exit_btn);
            Controls.Add(new_btn);
            Controls.Add(calc_btn);
            Controls.Add(previewPayslip_btn);
            Controls.Add(printPayslip_btn);
            Controls.Add(cancel_btn);
            Controls.Add(browse_btn);
            Controls.Add(picpathTxtbox);
            Controls.Add(pictureBox2);
            Controls.Add(groupBox7);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox3);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(paydateDatePicker);
            Controls.Add(DeptNameTxtbox);
            Controls.Add(empStatusTxtbox);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(numDependentTxtbox);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(desigTxtbox);
            Controls.Add(civil_statusTxtbox);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(surTxtbox);
            Controls.Add(MNameTxtbox);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(firstnameTxtbox);
            Controls.Add(emp_nuTxtbox);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Payroll";
            Text = "Example 5 ";
            Load += Activity5_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox8.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

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
        private Button searchbtn;
    }
}
