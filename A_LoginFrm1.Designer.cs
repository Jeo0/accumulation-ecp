namespace projectNamin
{
    partial class A_LoginFrm1
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
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            usernameTxtbox = new TextBox();
            passwordtxtbox = new TextBox();
            pictureBox1 = new PictureBox();
            showPass_check = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label1.Location = new Point(469, 273);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label2.Location = new Point(469, 323);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // button1
            // 
            button1.BackColor = Color.Blue;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(860, 254);
            button1.Name = "button1";
            button1.Size = new Size(78, 39);
            button1.TabIndex = 2;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Blue;
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(860, 310);
            button2.Name = "button2";
            button2.Size = new Size(78, 39);
            button2.TabIndex = 3;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // usernameTxtbox
            // 
            usernameTxtbox.Location = new Point(568, 270);
            usernameTxtbox.Name = "usernameTxtbox";
            usernameTxtbox.Size = new Size(250, 23);
            usernameTxtbox.TabIndex = 4;
            // 
            // passwordtxtbox
            // 
            passwordtxtbox.Location = new Point(568, 320);
            passwordtxtbox.Name = "passwordtxtbox";
            passwordtxtbox.PasswordChar = '*';
            passwordtxtbox.Size = new Size(250, 23);
            passwordtxtbox.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(613, 107);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(141, 130);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // showPass_check
            // 
            showPass_check.AutoSize = true;
            showPass_check.Location = new Point(710, 349);
            showPass_check.Name = "showPass_check";
            showPass_check.Size = new Size(108, 19);
            showPass_check.TabIndex = 7;
            showPass_check.Text = "Show Password";
            showPass_check.UseVisualStyleBackColor = true;
            showPass_check.CheckedChanged += showPass_check_CheckedChanged;
            // 
            // LoginFrm1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1370, 749);
            Controls.Add(showPass_check);
            Controls.Add(pictureBox1);
            Controls.Add(passwordtxtbox);
            Controls.Add(usernameTxtbox);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginFrm1";
            Text = "LoginFrm1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private TextBox usernameTxtbox;
        private TextBox passwordtxtbox;
        private PictureBox pictureBox1;
        private CheckBox showPass_check;
    }
}