namespace projectNamin
{
    partial class _6_employee_reports
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
            dataGridView1 = new DataGridView();
            optionCombo = new ComboBox();
            label1 = new Label();
            optionInputTxtbox = new TextBox();
            search_button = new Button();
            back_button = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 55);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1008, 547);
            dataGridView1.TabIndex = 0;
            // 
            // optionCombo
            // 
            optionCombo.FormattingEnabled = true;
            optionCombo.Location = new Point(157, 26);
            optionCombo.Name = "optionCombo";
            optionCombo.Size = new Size(228, 23);
            optionCombo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(27, 28);
            label1.Name = "label1";
            label1.Size = new Size(124, 21);
            label1.TabIndex = 3;
            label1.Text = "Select an option:";
            // 
            // optionInputTxtbox
            // 
            optionInputTxtbox.Location = new Point(391, 26);
            optionInputTxtbox.Name = "optionInputTxtbox";
            optionInputTxtbox.Size = new Size(228, 23);
            optionInputTxtbox.TabIndex = 4;
            // 
            // search_button
            // 
            search_button.Location = new Point(625, 25);
            search_button.Name = "search_button";
            search_button.Size = new Size(75, 23);
            search_button.TabIndex = 5;
            search_button.Text = "Search";
            search_button.UseVisualStyleBackColor = true;
            search_button.Click += search_button_Click;
            // 
            // back_button
            // 
            back_button.Location = new Point(706, 25);
            back_button.Name = "back_button";
            back_button.Size = new Size(75, 23);
            back_button.TabIndex = 6;
            back_button.Text = "Back";
            back_button.UseVisualStyleBackColor = true;
            back_button.Click += back_button_Click;
            // 
            // _6_employee_reports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 614);
            Controls.Add(back_button);
            Controls.Add(search_button);
            Controls.Add(optionInputTxtbox);
            Controls.Add(label1);
            Controls.Add(optionCombo);
            Controls.Add(dataGridView1);
            Name = "_6_employee_reports";
            Text = "Employee Reports";
            Load += _6_employee_reports_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox optionCombo;
        private Label label1;
        private TextBox optionInputTxtbox;
        private Button search_button;
        private Button back_button;
    }
}