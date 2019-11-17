using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private List<string> words;
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            SearchText.Text = "";
     
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = Application.CommonAppDataPath;
            dialog.Filter = "Text files|*.txt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                words = new List<string>();
                aFileName.Text = "Открываем файл.. " + dialog.FileName;
                Stopwatch sw = new Stopwatch();
                sw.Start();
                foreach (string s in File.ReadAllText(dialog.FileName, Encoding.UTF8).Split(' ', '\t', '!', '?', ',', '-', '.', ':', '\r', '\n'))
                {
                    if (!String.IsNullOrEmpty(s))
                    {
                        string lowercase = s.ToLower();
                        if (!words.Contains(lowercase)) words.Add(lowercase);
                    }
                }             
                ShearchButton_Click(this, new EventArgs());
                sw.Stop();
                aFileName.Text = "Открыт файл.. " + dialog.FileName;
                aTimeWork.Text = "Время открытия файла " + sw.ElapsedMilliseconds + " ms";
            }
        }

        private void ShearchButton_Click(object sender, EventArgs e)
        {
            if (words == null) return;

            Stopwatch sw = new Stopwatch();
            sw.Start();

            ListData.BeginUpdate();
            ListData.Items.Clear();

            string substring = SearchText.Text.ToLower();
            foreach (string s in words)
                if (s.Contains(substring))
                    ListData.Items.Add(s);
            ListData.EndUpdate();

            sw.Stop();
            aTimeWork.Text = "Время поиска " + sw.ElapsedMilliseconds + " мс";
        }

        private void SearchText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.None && (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return))
                ShearchButton_Click(this, new EventArgs());
        }
    }
}
