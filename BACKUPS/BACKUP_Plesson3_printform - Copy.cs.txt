using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson3___example3
{
    public partial class Plesson3_printform: Form
    {
        public Plesson3_printform()
        {
            InitializeComponent();
            //codes below is to display all the contents of the listbox
            //from the Activity4.cs form to this current form
            printDisplayListBox.Items.AddRange(printDisplayListBox.Items);

        }
        public ListBox PrintDisplayListBox
        {
            get { return printDisplayListBox; }
        }

        private void printDisplayListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Activity4_PrintFrms_Load(object sender, EventArgs e)
        {

        }
    }
}
