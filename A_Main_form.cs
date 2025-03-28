using Activity5;
using example5;
using lesson3___example3;
using New_POS_Application;

namespace projectNamin
{
    public partial class A_Main_form : Form
    {
        public A_Main_form()
        {
            InitializeComponent();
        }

        private void projectsToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void quiz1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pquiz1_form newMDIchild = new Pquiz1_form();
            newMDIchild.MdiParent = this;
            newMDIchild.Show();
        }

        private void example3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Plesson3_form newMDIchild = new Plesson3_form();
            newMDIchild.MdiParent = this;
            newMDIchild.Show();
        }

        private void example5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activity5.MActivity5_form newMDIchild = new Activity5.MActivity5_form();
            newMDIchild.MdiParent = this;
            newMDIchild.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            A_LoginFrm1 newmdi = new A_LoginFrm1();
            this.Hide();
            newmdi.ShowDialog();
            this.Close();

        }
    }
}
