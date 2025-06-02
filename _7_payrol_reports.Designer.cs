namespace projectNamin
{
    partial class _7_payrol_reports
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
            back_button = new Button();
            search_button = new Button();
            optionInputTxtbox = new TextBox();
            label1 = new Label();
            optionCombo = new ComboBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // back_button
            // 
            back_button.Location = new Point(706, 8);
            back_button.Name = "back_button";
            back_button.Size = new Size(75, 23);
            back_button.TabIndex = 12;
            back_button.Text = "Back";
            back_button.UseVisualStyleBackColor = true;
            back_button.Click += back_button_Click;
            // 
            // search_button
            // 
            search_button.Location = new Point(625, 8);
            search_button.Name = "search_button";
            search_button.Size = new Size(75, 23);
            search_button.TabIndex = 11;
            search_button.Text = "Search";
            search_button.UseVisualStyleBackColor = true;
            search_button.Click += search_button_Click;
            // 
            // optionInputTxtbox
            // 
            optionInputTxtbox.Location = new Point(391, 9);
            optionInputTxtbox.Name = "optionInputTxtbox";
            optionInputTxtbox.Size = new Size(228, 23);
            optionInputTxtbox.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(27, 11);
            label1.Name = "label1";
            label1.Size = new Size(124, 21);
            label1.TabIndex = 9;
            label1.Text = "Select an option:";
            // 
            // optionCombo
            // 
            optionCombo.FormattingEnabled = true;
            optionCombo.Location = new Point(157, 9);
            optionCombo.Name = "optionCombo";
            optionCombo.Size = new Size(228, 23);
            optionCombo.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 38);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1008, 547);
            dataGridView1.TabIndex = 7;
            // 
            // _7_payrol_reports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 596);
            Controls.Add(back_button);
            Controls.Add(search_button);
            Controls.Add(optionInputTxtbox);
            Controls.Add(label1);
            Controls.Add(optionCombo);
            Controls.Add(dataGridView1);
            Name = "_7_payrol_reports";
            Text = "_7_payrol_reports";
            Load += _7_payrol_reports_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button back_button;
        private Button search_button;
        private TextBox optionInputTxtbox;
        private Label label1;
        private ComboBox optionCombo;
        private DataGridView dataGridView1;
    }
}