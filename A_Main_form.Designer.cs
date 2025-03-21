namespace projectNamin
{
    partial class A_Main_form
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
            menuStrip1 = new MenuStrip();
            menuStrip2 = new MenuStrip();
            projectsToolStripMenuItem = new ToolStripMenuItem();
            quiz1ToolStripMenuItem = new ToolStripMenuItem();
            example3ToolStripMenuItem = new ToolStripMenuItem();
            example5ToolStripMenuItem = new ToolStripMenuItem();
            accountToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Location = new Point(0, 24);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            menuStrip2.Items.AddRange(new ToolStripItem[] { projectsToolStripMenuItem, accountToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(800, 24);
            menuStrip2.TabIndex = 1;
            menuStrip2.Text = "menuStrip2";
            // 
            // projectsToolStripMenuItem
            // 
            projectsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quiz1ToolStripMenuItem, example3ToolStripMenuItem, example5ToolStripMenuItem });
            projectsToolStripMenuItem.Name = "projectsToolStripMenuItem";
            projectsToolStripMenuItem.Size = new Size(61, 20);
            projectsToolStripMenuItem.Text = "Projects";
            projectsToolStripMenuItem.Click += projectsToolStripMenuItem_Click;
            // 
            // quiz1ToolStripMenuItem
            // 
            quiz1ToolStripMenuItem.Name = "quiz1ToolStripMenuItem";
            quiz1ToolStripMenuItem.Size = new Size(271, 22);
            quiz1ToolStripMenuItem.Text = "4JEE Foods Inc POS (Quiz 1)";
            quiz1ToolStripMenuItem.Click += quiz1ToolStripMenuItem_Click;
            // 
            // example3ToolStripMenuItem
            // 
            example3ToolStripMenuItem.Name = "example3ToolStripMenuItem";
            example3ToolStripMenuItem.Size = new Size(271, 22);
            example3ToolStripMenuItem.Text = "4JEE Foods Ordering POS (Example 3)";
            example3ToolStripMenuItem.Click += example3ToolStripMenuItem_Click;
            // 
            // example5ToolStripMenuItem
            // 
            example5ToolStripMenuItem.Name = "example5ToolStripMenuItem";
            example5ToolStripMenuItem.Size = new Size(271, 22);
            example5ToolStripMenuItem.Text = "SSS Contribution (Example 5)";
            example5ToolStripMenuItem.Click += example5ToolStripMenuItem_Click;
            // 
            // accountToolStripMenuItem
            // 
            accountToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logoutToolStripMenuItem });
            accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            accountToolStripMenuItem.Size = new Size(64, 20);
            accountToolStripMenuItem.Text = "Account";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(180, 22);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // A_Main_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "A_Main_form";
            Text = "Form1";
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem projectsToolStripMenuItem;
        private ToolStripMenuItem quiz1ToolStripMenuItem;
        private ToolStripMenuItem example3ToolStripMenuItem;
        private ToolStripMenuItem example5ToolStripMenuItem;
        private ToolStripMenuItem accountToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
    }
}
