using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Resources;
using System.IO;
namespace CentosCashFlow.ChildForms
{
    public partial class NewLaguages : Form
    {
        public NewLaguages()
        {
            InitializeComponent();
            LoadTranslations();
        }
        private void LoadTranslations()
        {
            // Specify the path to your translations text file
            string relativePath = @"VN.txt";

            // Combine the relative path with the startup path to get the full path
            string filePath = Path.Combine(Application.StartupPath, relativePath);

            // Check if the file exists
            if (File.Exists(filePath))
            {
                // Read all lines from the text file
                string[] lines = File.ReadAllLines(filePath);

                // Create a DataTable to store the translations
                DataTable translationsTable = new DataTable();

                // Add columns to the DataTable
                translationsTable.Columns.Add("Key", typeof(string));
                translationsTable.Columns.Add("Translation", typeof(string));

                // Iterate through translations and add rows to the DataTable
                foreach (string line in lines)
                {
                    // Split the line into key and translation
                    string[] parts = line.Split('=');

                    if (parts.Length == 2)
                    {
                        string key = parts[0].Trim();
                        string translation = parts[1].Trim();

                        // Add a new row to the DataTable
                        translationsTable.Rows.Add(key, translation);
                    }
                }
                NewLanguages.DataSource = translationsTable;
                NewLanguages.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                NewLanguages.Width = 100;
                NewLanguages.BackgroundColor = Color.AntiqueWhite;

                // Set the DataTable as the DataSource for your DataGridView
                
            }
            else
            {
                MessageBox.Show("Translations file not found!", "", MessageBoxButtons.OK);
            }
        }

        private void NewLanguages_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddNewLanguage_Click(object sender, EventArgs e)
        {
            // Specify the path to the new text file
            string filePath = "new_translations.txt";

            // Create or overwrite the text file
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                // Iterate through each row in the DataGridView
                foreach (DataGridViewRow row in NewLanguages.Rows)
                {
                    // Skip the new row if it's the last row and doesn't contain actual data
                    if (!row.IsNewRow)
                    {
                        // Extract data from the row and write it to the file
                        string key = row.Cells["key"].Value.ToString();  // Replace with your actual key column name
                        string translation = row.Cells["Translation"].Value.ToString();  // Replace with your actual translation column name

                        // Write the key-value pair to the file
                        writer.WriteLine($"{key}={translation}");
                    }
                }
            }

            MessageBox.Show("Changes saved to the new file!", "", MessageBoxButtons.OK);
        }
    }
}
