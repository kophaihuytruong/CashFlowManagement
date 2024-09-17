using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace CentosCashFlow.Languages
{
    public class LanguageDictionary
    {
        private Dictionary<string, string> languageData;

        public LanguageDictionary() {
            LoadLanguageData("VN.txt");
        }
        public LanguageDictionary(string name)
        {
            name = name.Trim() + ".txt";
            LoadLanguageData(name);
        }

        public void LoadLanguageData(string filePath)
        {
            languageData = new Dictionary<string, string>();
            string relativePath = Path.Combine(@"Languages", filePath);
            string projectPath = Path.GetDirectoryName(Path.GetDirectoryName(System.Windows.Forms.Application.StartupPath));
            string fullPath = Path.Combine(projectPath, relativePath);

            if (File.Exists(fullPath))
            {
                try
                {
                    string[] lines = File.ReadAllLines(fullPath);

                    foreach (string line in lines)
                    {
                        string[] parts = line.Split('=');
                        if (parts.Length == 2)
                        {
                            string key = parts[0].Trim();
                            string value = parts[1].Trim();
                            languageData[key] = value;
                        }
                    }
                }
                catch (IOException e)
                {
                    Console.WriteLine("Lỗi khi đọc tệp tin: " + e.Message);
                }
            }
            else
            {
                Console.WriteLine("Tệp tin không tồn tại.");
            }
        }
        public void UpdateUIWithLanguage(Control control)
        {
            if (languageData.ContainsKey(control.Text))
            {
                control.Text = languageData[control.Text];
            }
        }
        public void SetLanguages(Control parentControl)
        {
            foreach (Control control in parentControl.Controls)
            {
                // Kiểm tra xem thuộc tính Name của control có chứa "display" hay không
                if (control.Name != null && control.Name.Contains("_display"))
                {
                    UpdateUIWithLanguage(control);
                }

                // Nếu control có các control con, tiến hành đệ quy
                if (control.HasChildren)
                {
                    SetLanguages(control);
                }
            }
        }

        public string getTranslatedWord(string word)
        {
            string w = word;
            if (languageData.ContainsKey(word))
            {
                w = languageData[word];
            }
            return w;
        }
    }
}
