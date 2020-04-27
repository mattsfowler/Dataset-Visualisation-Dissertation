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

//MLSharpPython pythonRunner = new MLSharpPython(@"D:\Program Files\Python38\python.exe");
//pythonRunner.ExecutePythonScript(@"D:\Matt\Documents\GitRepos\Dataset-Visualisation-Dissertation\pscript.py", out string error);

namespace GUI_DemVis
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void btnKMeans_Click(object sender, EventArgs e)
        {
            KMeansGUI kmeansGUI = new KMeansGUI();
            kmeansGUI.Show();
        }
    }
}
