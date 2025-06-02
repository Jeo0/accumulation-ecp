namespace Activity5
{
    partial class Payroll_printfrms
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
            this.PrintDisplayListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // PrintDisplayListBox
            // 
            this.PrintDisplayListBox.FormattingEnabled = true;
            this.PrintDisplayListBox.Location = new System.Drawing.Point(-1, 12);
            this.PrintDisplayListBox.Name = "PrintDisplayListBox";
            this.PrintDisplayListBox.Size = new System.Drawing.Size(371, 433);
            this.PrintDisplayListBox.TabIndex = 0;
            // 
            // Activity5_PrintFrms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 450);
            this.Controls.Add(this.PrintDisplayListBox);
            this.Name = "Activity5_PrintFrms";
            this.Text = "Activity5_PrintFrms";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox PrintDisplayListBox;
    }
}