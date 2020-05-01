using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace GUI_DemVis.Forms
{
    public partial class SomGUI : Form
    {
        public SomGUI()
        {
            InitializeComponent();
            inputDir = "";
            outputDir = "";
            pythonExe = "";
        }

        string inputDir;
        string outputDir;
        string pythonExe;
        string scriptDir;

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string scriptAndArgs = scriptDir + "savesommatrix.py";
            scriptAndArgs += " " + scriptDir + "params.json";

            // Load values from the form
            string[] dataColumns = new string[lstColumns.Items.Count];
            for (int i = 0; i < lstColumns.Items.Count; i++)
            {
                dataColumns[i] = lstColumns.Items[i].Text;
            }

            Dictionary<string, string> data = new Dictionary<string, string>();

            data.Add("trainingData", inputDir + txtInputFile.Text);
            data.Add("colsToLoad", JsonConvert.SerializeObject(dataColumns));
            data.Add("indexCol", ((int)nudIDColumn.Value).ToString());
            data.Add("matrixFile", outputDir + txtOutputFile.Text);
            data.Add("mapWidth", ((int)nudMapWidth.Value).ToString());
            data.Add("mapHeight", ((int)nudMapHeight.Value).ToString());
            data.Add("iterLim", ((int)nudIterLim.Value).ToString());
            data.Add("initLR", ((float)nudLearnRate.Value).ToString());
            data.Add("initRad", ((float)nudRadius.Value).ToString());

            // Save parameters to the params.json file for the Python script to see
            string json = JsonConvert.SerializeObject(data);
            File.WriteAllText(scriptDir + "params.json", json);

            MLSharpPython scriptRunner = new MLSharpPython(pythonExe);
            scriptRunner.ExecutePythonScript(scriptAndArgs, out string stdError1);
            /*scriptRunner.ExecutePythonScript(@"D:\Matt\Documents\GitRepos\Dataset-Visualisation-Dissertation\python\Kohonen\savecoords.py" +
                                                @" D:\Matt\Documents\GitRepos\Dataset-Visualisation-Dissertation\python\Kohonen\params.json",
                                                out string stdError2);*/
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddCol_Click(object sender, EventArgs e)
        {
            lstColumns.Items.Add(txtNewColName.Text);
        }

        private void lstColumns_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void lstColumns_DoubleClick(object sender, EventArgs e)
        {
            for (int i = 0; i < lstColumns.SelectedItems.Count; i++)
            {
                lstColumns.Items.Remove(lstColumns.SelectedItems[i]);
            }
        }

        private void setInputDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextInput inputForm = new TextInput();
            var result = inputForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                inputDir = inputForm.output;
            }
        }

        private void setOutputDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextInput inputForm = new TextInput();
            var result = inputForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                outputDir = inputForm.output;
            }
        }

        private void setPythonExeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextInput inputForm = new TextInput();
            var result = inputForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                pythonExe = inputForm.output;
            }
        }

        private void setScriptDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextInput inputForm = new TextInput();
            var result = inputForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                scriptDir = inputForm.output;
            }
        }
    }
}
