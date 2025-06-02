namespace lesson3___example3
{
    partial class Proj_pos2_printfrms
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
            this.printDisplayListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // printDisplayListBox
            // 
            this.printDisplayListBox.FormattingEnabled = true;
            this.printDisplayListBox.Location = new System.Drawing.Point(0, 0);
            this.printDisplayListBox.Name = "printDisplayListBox";
            this.printDisplayListBox.Size = new System.Drawing.Size(449, 446);
            this.printDisplayListBox.TabIndex = 4;
            // 
            // Activity4_PrintFrms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.Controls.Add(this.printDisplayListBox);
            this.Name = "Activity4_PrintFrms";
            this.Text = "Activity4_PrintFrms";
            this.Load += new System.EventHandler(this.Activity4_PrintFrms_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox printDisplayListBox;
    }
}
