namespace projectNamin
{
    partial class Flesson13
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
            dataGridView = new DataGridView();
            departmentTxtBox = new TextBox();
            studentNameTxtBox = new TextBox();
            studentNumTxtBox = new TextBox();
            picturepathTxtBox = new TextBox();
            editBtn = new Button();
            cancelBtn = new Button();
            newBtn = new Button();
            deleteBtn = new Button();
            searchBtn = new Button();
            saveBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            pictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(370, 133);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(418, 193);
            dataGridView.TabIndex = 0;
            // 
            // departmentTxtBox
            // 
            departmentTxtBox.Location = new Point(518, 104);
            departmentTxtBox.Name = "departmentTxtBox";
            departmentTxtBox.Size = new Size(270, 23);
            departmentTxtBox.TabIndex = 2;
            // 
            // studentNameTxtBox
            // 
            studentNameTxtBox.Location = new Point(518, 75);
            studentNameTxtBox.Name = "studentNameTxtBox";
            studentNameTxtBox.Size = new Size(270, 23);
            studentNameTxtBox.TabIndex = 3;
            // 
            // studentNumTxtBox
            // 
            studentNumTxtBox.Location = new Point(518, 46);
            studentNumTxtBox.Name = "studentNumTxtBox";
            studentNumTxtBox.Size = new Size(270, 23);
            studentNumTxtBox.TabIndex = 4;
            // 
            // picturepathTxtBox
            // 
            picturepathTxtBox.Location = new Point(518, 17);
            picturepathTxtBox.Name = "picturepathTxtBox";
            picturepathTxtBox.Size = new Size(270, 23);
            picturepathTxtBox.TabIndex = 5;
            // 
            // editBtn
            // 
            editBtn.Location = new Point(370, 397);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(126, 41);
            editBtn.TabIndex = 9;
            editBtn.Text = "Edit";
            editBtn.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(518, 397);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(126, 41);
            cancelBtn.TabIndex = 10;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            // 
            // newBtn
            // 
            newBtn.Location = new Point(662, 397);
            newBtn.Name = "newBtn";
            newBtn.Size = new Size(126, 41);
            newBtn.TabIndex = 11;
            newBtn.Text = "New";
            newBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(662, 343);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(126, 41);
            deleteBtn.TabIndex = 14;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(518, 343);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(126, 41);
            searchBtn.TabIndex = 13;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(370, 343);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(126, 41);
            saveBtn.TabIndex = 12;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(370, 107);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 15;
            label1.Text = "Department:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(370, 78);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 16;
            label2.Text = "Student Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(370, 49);
            label4.Name = "label4";
            label4.Size = new Size(104, 15);
            label4.TabIndex = 17;
            label4.Text = "Student Number:";
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(12, 12);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(352, 426);
            pictureBox.TabIndex = 18;
            pictureBox.TabStop = false;
            // 
            // Flesson13
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(deleteBtn);
            Controls.Add(searchBtn);
            Controls.Add(saveBtn);
            Controls.Add(newBtn);
            Controls.Add(cancelBtn);
            Controls.Add(editBtn);
            Controls.Add(picturepathTxtBox);
            Controls.Add(studentNumTxtBox);
            Controls.Add(studentNameTxtBox);
            Controls.Add(departmentTxtBox);
            Controls.Add(dataGridView);
            Name = "Flesson13";
            Text = "Flesson13";
            Load += Flesson13_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private TextBox departmentTxtBox;
        private TextBox studentNameTxtBox;
        private TextBox studentNumTxtBox;
        private TextBox picturepathTxtBox;
        private Button editBtn;
        private Button cancelBtn;
        private Button newBtn;
        private Button deleteBtn;
        private Button searchBtn;
        private Button saveBtn;
        private Label label1;
        private Label label2;
        private Label label4;
        private PictureBox pictureBox;
    }
}