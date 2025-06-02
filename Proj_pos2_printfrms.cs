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
    public partial class Proj_pos2_printfrms : Form
    {
        public Proj_pos2_printfrms() {
            InitializeComponent();
            //codes below is to display all the contents of the listbox
            //from the Activity4.cs form to this current form
            printDisplayListBox.Items.AddRange(printDisplayListBox.Items);

        }
        public ListBox PrintDisplayListBox {
            get { return printDisplayListBox; }
        }


        private void Activity4_PrintFrms_Load(object sender, EventArgs e) {

        }
    }
}
