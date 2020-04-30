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
    public partial class SomGUI : Form
    {
        public SomGUI()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MLSharpPython scriptRunner = new MLSharpPython(@"D:\Program Files\Python38\python.exe");
            scriptRunner.ExecutePythonScript(@"D:\Matt\Documents\GitRepos\Dataset-Visualisation-Dissertation\python\Kohonen\savesommatrix.py" +
                                                @" D:\Matt\Documents\GitRepos\Dataset-Visualisation-Dissertation\python\Kohonen\params.json",
                                                out string stdError1);
            scriptRunner.ExecutePythonScript(@"D:\Matt\Documents\GitRepos\Dataset-Visualisation-Dissertation\python\Kohonen\savecoords.py" +
                                                @" D:\Matt\Documents\GitRepos\Dataset-Visualisation-Dissertation\python\Kohonen\params.json",
                                                out string stdError2);
        }
    }
}
