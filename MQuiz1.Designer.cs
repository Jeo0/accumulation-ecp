namespace projectNamin
{
    partial class MQuiz1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Entries_lb = new ListBox();
            label1 = new Label();
            inp_program_cb = new ComboBox();
            inp_dateenrolled_dp = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            inp_studentname_tb = new TextBox();
            inp_studentnumber_tb = new TextBox();
            inp_scholar_cb = new ComboBox();
            label8 = new Label();
            recompute_btn = new Button();
            newEntry_btn = new Button();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            label27 = new Label();
            label28 = new Label();
            label29 = new Label();
            label30 = new Label();
            label31 = new Label();
            label32 = new Label();
            label33 = new Label();
            label34 = new Label();
            label35 = new Label();
            label36 = new Label();
            label37 = new Label();
            label38 = new Label();
            label39 = new Label();
            label40 = new Label();
            label41 = new Label();
            label42 = new Label();
            label43 = new Label();
            label44 = new Label();
            label45 = new Label();
            label26 = new Label();
            label46 = new Label();
            label47 = new Label();
            label48 = new Label();
            label49 = new Label();
            label50 = new Label();
            label51 = new Label();
            label52 = new Label();
            inp_mode_cb = new ComboBox();
            inp_yearlevel_cb = new ComboBox();
            SuspendLayout();
            // 
            // Entries_lb
            // 
            Entries_lb.FormattingEnabled = true;
            Entries_lb.ItemHeight = 15;
            Entries_lb.Location = new Point(22, 221);
            Entries_lb.Name = "Entries_lb";
            Entries_lb.Size = new Size(1004, 364);
            Entries_lb.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 22);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 1;
            label1.Text = "Student Name";
            // 
            // inp_program_cb
            // 
            inp_program_cb.FormattingEnabled = true;
            inp_program_cb.Items.AddRange(new object[] { "Computer Engineering", "Electrical Engineering", "Electronics Engineering", "Mechanical Engineering", "Civil Engineering", "Aeronautical Engineering", "Industrial Engineering", "Architecture", "Library Science ", "Computer Science", "Information Technology" });
            inp_program_cb.Location = new Point(122, 47);
            inp_program_cb.Name = "inp_program_cb";
            inp_program_cb.Size = new Size(230, 23);
            inp_program_cb.TabIndex = 2;
            // 
            // inp_dateenrolled_dp
            // 
            inp_dateenrolled_dp.Format = DateTimePickerFormat.Short;
            inp_dateenrolled_dp.Location = new Point(122, 78);
            inp_dateenrolled_dp.Name = "inp_dateenrolled_dp";
            inp_dateenrolled_dp.Size = new Size(230, 23);
            inp_dateenrolled_dp.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 50);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 4;
            label2.Text = "Programs";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 78);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 5;
            label3.Text = "Date Enrolled";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(434, 45);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 6;
            label4.Text = "Mode";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(667, 22);
            label5.Name = "label5";
            label5.Size = new Size(95, 15);
            label5.TabIndex = 7;
            label5.Text = "Student Number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(703, 50);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 8;
            label6.Text = "Year Level";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(716, 78);
            label7.Name = "label7";
            label7.Size = new Size(46, 15);
            label7.TabIndex = 9;
            label7.Text = "Scholar";
            // 
            // inp_studentname_tb
            // 
            inp_studentname_tb.Location = new Point(122, 19);
            inp_studentname_tb.Name = "inp_studentname_tb";
            inp_studentname_tb.Size = new Size(230, 23);
            inp_studentname_tb.TabIndex = 10;
            // 
            // inp_studentnumber_tb
            // 
            inp_studentnumber_tb.Location = new Point(768, 19);
            inp_studentnumber_tb.Name = "inp_studentnumber_tb";
            inp_studentnumber_tb.Size = new Size(258, 23);
            inp_studentnumber_tb.TabIndex = 14;
            // 
            // inp_scholar_cb
            // 
            inp_scholar_cb.FormattingEnabled = true;
            inp_scholar_cb.Items.AddRange(new object[] { "Full", "Partial", "None" });
            inp_scholar_cb.Location = new Point(768, 80);
            inp_scholar_cb.Name = "inp_scholar_cb";
            inp_scholar_cb.Size = new Size(258, 23);
            inp_scholar_cb.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 177);
            label8.Name = "label8";
            label8.Size = new Size(125, 15);
            label8.TabIndex = 18;
            label8.Text = "Schedule of Course/s: ";
            // 
            // recompute_btn
            // 
            recompute_btn.BackColor = Color.Red;
            recompute_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            recompute_btn.ForeColor = SystemColors.ButtonFace;
            recompute_btn.Location = new Point(22, 107);
            recompute_btn.Name = "recompute_btn";
            recompute_btn.Size = new Size(141, 36);
            recompute_btn.TabIndex = 19;
            recompute_btn.Text = "Recompute";
            recompute_btn.UseVisualStyleBackColor = false;
            recompute_btn.Click += recompute_btn_Click;
            // 
            // newEntry_btn
            // 
            newEntry_btn.Location = new Point(169, 107);
            newEntry_btn.Name = "newEntry_btn";
            newEntry_btn.Size = new Size(115, 36);
            newEntry_btn.TabIndex = 20;
            newEntry_btn.Text = "New entry";
            newEntry_btn.UseVisualStyleBackColor = true;
            newEntry_btn.Click += newEntry_btn_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(22, 202);
            label9.Name = "label9";
            label9.Size = new Size(14, 15);
            label9.TabIndex = 21;
            label9.Text = "#";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(42, 202);
            label10.Name = "label10";
            label10.Size = new Size(75, 15);
            label10.TabIndex = 22;
            label10.Text = "Course Code";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(169, 202);
            label11.Name = "label11";
            label11.Size = new Size(46, 15);
            label11.TabIndex = 23;
            label11.Text = "Section";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(316, 202);
            label12.Name = "label12";
            label12.Size = new Size(67, 15);
            label12.TabIndex = 24;
            label12.Text = "Description";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(623, 202);
            label13.Name = "label13";
            label13.Size = new Size(65, 15);
            label13.TabIndex = 27;
            label13.Text = "Cred. Units";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(582, 202);
            label14.Name = "label14";
            label14.Size = new Size(26, 15);
            label14.TabIndex = 26;
            label14.Text = "Lab";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(455, 202);
            label15.Name = "label15";
            label15.Size = new Size(25, 15);
            label15.TabIndex = 25;
            label15.Text = "Lec";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(968, 202);
            label16.Name = "label16";
            label16.Size = new Size(39, 15);
            label16.TabIndex = 30;
            label16.Text = "Room";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(836, 202);
            label17.Name = "label17";
            label17.Size = new Size(27, 15);
            label17.TabIndex = 29;
            label17.Text = "Day";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(694, 202);
            label18.Name = "label18";
            label18.Size = new Size(33, 15);
            label18.TabIndex = 28;
            label18.Text = "Time";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(1032, 19);
            label19.Name = "label19";
            label19.Size = new Size(62, 15);
            label19.TabIndex = 31;
            label19.Text = "Total Units";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(1032, 47);
            label20.Name = "label20";
            label20.Size = new Size(93, 15);
            label20.TabIndex = 32;
            label20.Text = "Total Tuition Fee";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(1032, 72);
            label21.Name = "label21";
            label21.Size = new Size(89, 15);
            label21.TabIndex = 33;
            label21.Text = "Total Misc. Fees";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(1032, 99);
            label22.Name = "label22";
            label22.Size = new Size(102, 15);
            label22.TabIndex = 34;
            label22.Text = "Other School Fees";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(1059, 148);
            label23.Name = "label23";
            label23.Size = new Size(84, 15);
            label23.TabIndex = 37;
            label23.Text = "CISCO Lab Fee";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(1059, 133);
            label24.Name = "label24";
            label24.Size = new Size(49, 15);
            label24.TabIndex = 36;
            label24.Text = "SAP Fee";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(1057, 118);
            label25.Name = "label25";
            label25.Size = new Size(142, 15);
            label25.TabIndex = 35;
            label25.Text = "Computer Laboratory Fee";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(1032, 190);
            label27.Name = "label27";
            label27.Size = new Size(130, 15);
            label27.TabIndex = 39;
            label27.Text = "Total Other School Fees";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(1059, 163);
            label28.Name = "label28";
            label28.Size = new Size(79, 15);
            label28.TabIndex = 38;
            label28.Text = "Exam Booklet";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(1032, 258);
            label29.Name = "label29";
            label29.Size = new Size(104, 15);
            label29.TabIndex = 41;
            label29.Text = "Mode Of Payment";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(1059, 306);
            label30.Name = "label30";
            label30.Size = new Size(85, 15);
            label30.TabIndex = 43;
            label30.Text = "Downpayment";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(1032, 282);
            label31.Name = "label31";
            label31.Size = new Size(107, 15);
            label31.TabIndex = 42;
            label31.Text = "Installment Charge";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(1032, 392);
            label32.Name = "label32";
            label32.Size = new Size(75, 15);
            label32.TabIndex = 45;
            label32.Text = "Amount Due";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Location = new Point(1057, 321);
            label33.Name = "label33";
            label33.Size = new Size(147, 15);
            label33.TabIndex = 44;
            label33.Text = "1st Installment (2/17/2025)";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Location = new Point(1057, 336);
            label34.Name = "label34";
            label34.Size = new Size(152, 15);
            label34.TabIndex = 46;
            label34.Text = "2nd Installment (3/27/2025)";
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Location = new Point(1057, 351);
            label35.Name = "label35";
            label35.Size = new Size(149, 15);
            label35.TabIndex = 47;
            label35.Text = "3rd Installment (5/05/2025)";
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Location = new Point(1032, 417);
            label36.Name = "label36";
            label36.Size = new Size(67, 15);
            label36.TabIndex = 48;
            label36.Text = "Grand Total";
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Location = new Point(1281, 190);
            label37.Name = "label37";
            label37.Size = new Size(22, 15);
            label37.TabIndex = 57;
            label37.Text = "___";
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Location = new Point(1232, 163);
            label38.Name = "label38";
            label38.Size = new Size(22, 15);
            label38.TabIndex = 56;
            label38.Text = "___";
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Location = new Point(1232, 148);
            label39.Name = "label39";
            label39.Size = new Size(22, 15);
            label39.TabIndex = 55;
            label39.Text = "___";
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Location = new Point(1232, 133);
            label40.Name = "label40";
            label40.Size = new Size(13, 15);
            label40.TabIndex = 54;
            label40.Text = "0";
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.Location = new Point(1230, 118);
            label41.Name = "label41";
            label41.Size = new Size(22, 15);
            label41.TabIndex = 53;
            label41.Text = "___";
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.Location = new Point(1230, 99);
            label42.Name = "label42";
            label42.Size = new Size(22, 15);
            label42.TabIndex = 52;
            label42.Text = "___";
            // 
            // label43
            // 
            label43.AutoSize = true;
            label43.Location = new Point(1230, 72);
            label43.Name = "label43";
            label43.Size = new Size(22, 15);
            label43.TabIndex = 51;
            label43.Text = "___";
            // 
            // label44
            // 
            label44.AutoSize = true;
            label44.Location = new Point(1230, 47);
            label44.Name = "label44";
            label44.Size = new Size(22, 15);
            label44.TabIndex = 50;
            label44.Text = "___";
            // 
            // label45
            // 
            label45.AutoSize = true;
            label45.Location = new Point(1230, 19);
            label45.Name = "label45";
            label45.Size = new Size(22, 15);
            label45.TabIndex = 49;
            label45.Text = "___";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(1248, 417);
            label26.Name = "label26";
            label26.Size = new Size(22, 15);
            label26.TabIndex = 65;
            label26.Text = "___";
            // 
            // label46
            // 
            label46.AutoSize = true;
            label46.Location = new Point(1248, 351);
            label46.Name = "label46";
            label46.Size = new Size(22, 15);
            label46.TabIndex = 64;
            label46.Text = "___";
            // 
            // label47
            // 
            label47.AutoSize = true;
            label47.Location = new Point(1248, 336);
            label47.Name = "label47";
            label47.Size = new Size(22, 15);
            label47.TabIndex = 63;
            label47.Text = "___";
            // 
            // label48
            // 
            label48.AutoSize = true;
            label48.Location = new Point(1248, 392);
            label48.Name = "label48";
            label48.Size = new Size(22, 15);
            label48.TabIndex = 62;
            label48.Text = "___";
            // 
            // label49
            // 
            label49.AutoSize = true;
            label49.Location = new Point(1248, 321);
            label49.Name = "label49";
            label49.Size = new Size(22, 15);
            label49.TabIndex = 61;
            label49.Text = "___";
            // 
            // label50
            // 
            label50.AutoSize = true;
            label50.Location = new Point(1248, 306);
            label50.Name = "label50";
            label50.Size = new Size(22, 15);
            label50.TabIndex = 60;
            label50.Text = "___";
            // 
            // label51
            // 
            label51.AutoSize = true;
            label51.Location = new Point(1248, 282);
            label51.Name = "label51";
            label51.Size = new Size(31, 15);
            label51.TabIndex = 59;
            label51.Text = "1200";
            // 
            // label52
            // 
            label52.AutoSize = true;
            label52.Location = new Point(1248, 258);
            label52.Name = "label52";
            label52.Size = new Size(22, 15);
            label52.TabIndex = 58;
            label52.Text = "___";
            // 
            // inp_mode_cb
            // 
            inp_mode_cb.FormattingEnabled = true;
            inp_mode_cb.Items.AddRange(new object[] { "Full Payment", "Installment" });
            inp_mode_cb.Location = new Point(478, 42);
            inp_mode_cb.Name = "inp_mode_cb";
            inp_mode_cb.Size = new Size(136, 23);
            inp_mode_cb.TabIndex = 66;
            // 
            // inp_yearlevel_cb
            // 
            inp_yearlevel_cb.FormattingEnabled = true;
            inp_yearlevel_cb.Items.AddRange(new object[] { "1st", "2nd", "3rd", "4th", "5th", "6th" });
            inp_yearlevel_cb.Location = new Point(768, 48);
            inp_yearlevel_cb.Name = "inp_yearlevel_cb";
            inp_yearlevel_cb.Size = new Size(258, 23);
            inp_yearlevel_cb.TabIndex = 67;
            // 
            // MQuiz1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(1340, 596);
            Controls.Add(inp_yearlevel_cb);
            Controls.Add(inp_mode_cb);
            Controls.Add(label26);
            Controls.Add(label46);
            Controls.Add(label47);
            Controls.Add(label48);
            Controls.Add(label49);
            Controls.Add(label50);
            Controls.Add(label51);
            Controls.Add(label52);
            Controls.Add(label37);
            Controls.Add(label38);
            Controls.Add(label39);
            Controls.Add(label40);
            Controls.Add(label41);
            Controls.Add(label42);
            Controls.Add(label43);
            Controls.Add(label44);
            Controls.Add(label45);
            Controls.Add(label36);
            Controls.Add(label35);
            Controls.Add(label34);
            Controls.Add(label32);
            Controls.Add(label33);
            Controls.Add(label30);
            Controls.Add(label31);
            Controls.Add(label29);
            Controls.Add(label27);
            Controls.Add(label28);
            Controls.Add(label23);
            Controls.Add(label24);
            Controls.Add(label25);
            Controls.Add(label22);
            Controls.Add(label21);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(label16);
            Controls.Add(label17);
            Controls.Add(label18);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(newEntry_btn);
            Controls.Add(recompute_btn);
            Controls.Add(label8);
            Controls.Add(inp_scholar_cb);
            Controls.Add(inp_studentnumber_tb);
            Controls.Add(inp_studentname_tb);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(inp_dateenrolled_dp);
            Controls.Add(inp_program_cb);
            Controls.Add(label1);
            Controls.Add(Entries_lb);
            Name = "MQuiz1";
            Text = "MQuiz1";
            Load += MQuiz1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private ComboBox inp_program_cb;
        private DateTimePicker inp_dateenrolled_dp;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox inp_studentnumber_tb;
        private TextBox inp_studentname_tb;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private ComboBox inp_scholar_cb;
        private Label label8;
        private Button recompute_btn;
        private Button newEntry_btn;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label label27;
        private Label label28;
        private Label label29;
        private Label label30;
        private Label label31;
        private Label label32;
        private Label label33;
        private Label label34;
        private Label label35;
        private Label label36;
        private Label label37;
        private Label label38;
        private Label label39;
        private Label label40;
        private Label label41;
        private Label label42;
        private Label label43;
        private Label label44;
        private Label label45;
        private Label label26;
        private Label label46;
        private Label label47;
        private Label label48;
        private Label label49;
        private Label label50;
        private Label label51;
        private Label label52;
        private ComboBox inp_mode_cb;
        private ComboBox inp_yearlevel_cb;
        public ListBox Entries_lb;
        public Label label19;
    }
}