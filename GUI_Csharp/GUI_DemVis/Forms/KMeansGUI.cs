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

namespace GUI_DemVis
{
    public partial class KMeansGUI : Form
    {
        public KMeansGUI()
        {
            InitializeComponent();
        }

        public List<List<string>> clusters;

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Disable submit button to stop the user from potentially triggering the function twice
            btnSubmit.Enabled = false;

            // Set directories (should ideally be set in a config file and read in at runtime)
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Path.GetFullPath(Path.Combine(Directory.GetParent(workingDirectory).Parent.FullName, @"..\..\"));
            string pythonProjectDirectory = projectDirectory + @"python\K-Means\";
            string paramsDirectory = pythonProjectDirectory + "params.json";
            string dataDirectory = projectDirectory + @"datasets\";
            string outputDirectory = projectDirectory + @"outputs\";
            string pythonDir = txtPythonDir.Text;

            // Load values from the form
            string inputFile = dataDirectory + txtInputFile.Text;
            string outputFile = outputDirectory + txtOutputFile.Text;
            int idCol = (int)nudIDColumn.Value;
            int nameCol = (int)nudNameColumn.Value;
            int numClusters = (int)nudNumClusters.Value;
            int maxIterations = (int)nudMaxIterations.Value;
            string[] dataColumns = txtDataColumns.Text.Split(';');

            // Save parameters to the params.json file for the Python script to see
            string[] data = { inputFile, outputFile, idCol.ToString(), nameCol.ToString(), JsonConvert.SerializeObject(dataColumns), numClusters.ToString(), maxIterations.ToString() };
            string json = JsonConvert.SerializeObject(data);
            File.WriteAllText(paramsDirectory, json);

            // Run the Python script (all parameters are passed via params.json
            MLSharpPython scriptRunner = new MLSharpPython(pythonDir);
            scriptRunner.ExecutePythonScript(pythonProjectDirectory + "clusterdata.py", out string stdError);

            // Confirm when the process ends
            string display = "File saved to: " + outputFile;
            display += "\nExit message: " + stdError;
            MessageBox.Show(display, "Finished", MessageBoxButtons.OK);

            // Retrieve the output of the Python script
            lbxClusters.Items.Clear();
            this.clusters = JsonConvert.DeserializeObject<List<List<string>>>(File.ReadAllText(outputFile));
            for (int cluster_id = 0; cluster_id < clusters.Count; cluster_id++)
            {
                lbxClusters.Items.Add("Cluster " + cluster_id.ToString());
            }

            btnSubmit.Enabled = true;
        }

        private void lbxClusters_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbxClusters.SelectedIndex;
            lstNames.Items.Clear();

            if (index == -1) lstNames.Items.Add("(none)");
            else
            {
                if (clusters[index].Count == 0) lstNames.Items.Add("(none)");
                else
                {
                    for (int name_index = 0; name_index < clusters[index].Count; name_index++)
                    {
                        lstNames.Items.Add(clusters[index][name_index]);
                    }
                }
            }
        }
    }
}
