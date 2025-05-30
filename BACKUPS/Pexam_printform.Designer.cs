namespace exam_prelim_ecp
{
    partial class PRINT_FORM
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
            printListBox = new ListBox();
            SuspendLayout();
            // 
            // printListBox
            // 
            printListBox.FormattingEnabled = true;
            printListBox.ItemHeight = 15;
            printListBox.Location = new Point(12, 72);
            printListBox.Name = "printListBox";
            printListBox.Size = new Size(625, 664);
            printListBox.TabIndex = 1;
            // 
            // PRINT_FORM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(652, 749);
            Controls.Add(printListBox);
            Name = "PRINT_FORM";
            Text = "Summary";
            ResumeLayout(false);
        }

        #endregion

        public ListBox printListBox;
    }
}