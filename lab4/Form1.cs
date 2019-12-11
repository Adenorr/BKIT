using lab5;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;



namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public int LenCol { get; set; }
        public int CountItemsUp { get; set; }
        private Stopwatch stopwatchwork;
        private List<string> words;
        public delegate int ShearhFunction(string firstText, string secondText); //какой алгоритм использовать
        public ShearhFunction ShearhFunc = null;

        public Form1()
        {
            InitializeComponent();
            ShearchTypeBox.SelectedIndex = 0;
            
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            SearchText.Text = "";

            OpenFileDialog dialog = new OpenFileDialog
            {
                InitialDirectory = Application.CommonAppDataPath,
                Filter = "Text files|*.txt|All files|*.*"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                words = new List<string>();
                words.Clear();
                
                aFileName.Text = "Открываем файл.. " + dialog.FileName;
                Stopwatch sw = new Stopwatch();
                sw.Start();
                progressBar1.Minimum = 0;
                FileInfo fileInf = new FileInfo(dialog.FileName);
                progressBar1.Maximum = Convert.ToInt32(fileInf.Length)*2;
                progressBar1.Value = 0;
                progressBar1.Visible = true;

              
                foreach (string s in File.ReadAllText(dialog.FileName, Encoding.ASCII).Split(' ', '\t', '!', '?', ',', '-', '.', ':', '\r', '\n'))
                {
                    if (!String.IsNullOrEmpty(s))
                    {
                        string lowercase = s.ToLower();
                        if (!words.Contains(lowercase)) words.Add(lowercase);
                        progressBar1.Value = progressBar1.Value + Encoding.ASCII.GetBytes(lowercase).Length;
                    }
                } 

                ShearchButton_Click(this, new EventArgs());                                         
                sw.Stop();
               
                toolStripStatusLabel1.Text = "Открыт файл.. " + dialog.FileName;
                toolStripStatusLabel2.Text = "Время открытия файла " + sw.ElapsedMilliseconds + " ms";
                
                timer1.Start(); 
                
            }
        }

        private void ShearchButton_Click(object sender, EventArgs e)
        {
            if (words == null) return;
            timer1.Stop();
            stopwatchwork = new Stopwatch();
            progressBar1.Minimum = 0;
            progressBar1.Maximum = words.Count+1;
            progressBar1.Value = 0;
            progressBar1.Visible = true;

            stopwatchwork.Start();

            ListData.BeginUpdate();
            ListData.Items.Clear();
            
            
            string substring = SearchText.Text.ToLower();
            switch (ShearchTypeBox.SelectedIndex)
            {
                    case 0:
                        ShearhFunc = new ShearhFunction(lab5.LevenshteinDistance.StrContains);
                        break;
                    case 1:
                        ShearhFunc = new ShearhFunction(lab5.LevenshteinDistance.WagnerFisher);
                        break;
                    case 2:
                        ShearhFunc = new ShearhFunction(lab5.LevenshteinDistance.DamerauLevenshtein);
                        break;
                    default:
                        break;
            }
            foreach (string s in words)
            {
                    int Distance = ShearhFunc(s, substring);
                    if (Distance <= Dopusk.Value) ListData.Items.Add(progressBar1.Value + ": Строка - " +s+ " - Дистанция - "+Distance);
                    progressBar1.Value++;
            }
            stopwatchwork.Stop();
                
            toolStripStatusLabel2.Text = "Всё нашли за " + stopwatchwork.ElapsedMilliseconds + " ms";
            timer1.Start();

            ListData.EndUpdate();

        }

        

        

        private void SearchText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.None && (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return))
                ShearchButton_Click(this, new EventArgs());
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Visible = false;
            timer1.Stop();
        }

        
       
                

        

        
    }

}
