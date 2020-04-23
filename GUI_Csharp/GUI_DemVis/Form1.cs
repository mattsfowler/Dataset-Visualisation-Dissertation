using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;


namespace GUI_DemVis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnRunR_Click(object sender, EventArgs e)
        {
            Button btnRunR = (Button)sender;
            string curDirectory = Directory.GetCurrentDirectory();

            MLSharpPython pythonRunner = new MLSharpPython(@"D:\Program Files\Python38\python.exe");
            pythonRunner.ExecutePythonScript(@"D:\Matt\Documents\GitRepos\Dataset-Visualisation-Dissertation\pscript.py", out string error);

            MLSharpPython rRunner = new MLSharpPython(@"D:\Program Files\R\R-3.6.3\bin\Rscript.exe");
            rRunner.ExecutePythonScript(@"D:\Matt\Documents\GitRepos\Dataset-Visualisation-Dissertation\R\Example\example_from_documentation.R", out string errorR);
            btnRunR.Text = error;
        }
    }
}
