using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_DemVis.Forms
{
    public partial class TextInput : Form
    {
        public TextInput()
        {
            InitializeComponent();
            output = "";
        }

        public string output;

        private void btnAccept_Click(object sender, EventArgs e)
        {
            output = txtInput.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
