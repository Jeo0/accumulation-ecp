using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace example5
{
    public partial class Plesson5_printform: Form
    {
        public Plesson5_printform()
        {
            InitializeComponent();
            priDisplayListbox.Items.AddRange(priDisplayListbox.Items);
        }
    }
}
