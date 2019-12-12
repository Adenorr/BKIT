using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace lab7
{
    public partial class Form1 : Form
    {
        private List<string> words;
        Func<string, string, int> ShearhFunc = null;
        private Stopwatch stopwatchwork = new Stopwatch();
        static ReaderWriterLock rw = new ReaderWriterLock();
        int CountThread = -1;

        ManualResetEvent[] doneEvents = new ManualResetEvent[0];
        StreamStringFind[] StrArray = new StreamStringFind[0];

        public Form1()
        {
            InitializeComponent();
            ShearchTypeBox.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {

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
                
                string[] sl = File.ReadAllText(dialog.FileName, Encoding.ASCII).Split(' ', '\t', '!', '?', ',', '-', '.', ':', '\r', '\n');
                progressBar1.Maximum = sl.Length;
                progressBar1.Value = 0;
                progressBar1.Visible = true;
                
                foreach (string s in sl)
                {
                    if (!String.IsNullOrEmpty(s))
                    {
                        string lowercase = s.ToLower();
                        if (!words.Contains(lowercase)) words.Add(lowercase);
                        
                    }
                    progressBar1.Value++;
                }

                ShearchButton_Click(this, new EventArgs());
                sw.Stop();

                aFileName.Text = "Открыт файл.. " + dialog.FileName;
                toolStripStatusLabel2.Text = "Время открытия файла " + sw.ElapsedMilliseconds + " ms";

                timer1.Start();

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Visible = false;
            timer1.Stop();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.None && (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return))
                ShearchButton_Click(this, new EventArgs());
        }

        private void ShearchButton_Click(object sender, EventArgs e)
        {
            if (words == null) return;
            timer1.Stop();
            progressBar1.Minimum = 0;
            progressBar1.Maximum = words.Count + 1;
            progressBar1.Value = 0;
            progressBar1.Visible = true;
            stopwatchwork.Reset();
            stopwatchwork.Start();

            
            ListData.Items.Clear();


            string substring = SearchText.Text.ToLower();
            switch (ShearchTypeBox.SelectedIndex)
            {
                case 0:
                    ShearhFunc = new Func<string, string, int>(lab5.LevenshteinDistance.StrContains);
                    break;
                case 1:
                    ShearhFunc = new Func<string, string, int>(lab5.LevenshteinDistance.WagnerFisher);
                    break;
                case 2:
                    ShearhFunc = new Func<string, string, int>(lab5.LevenshteinDistance.DamerauLevenshtein);
                    break;
                default:
                    break;
            }
            int k = Convert.ToInt32(CountStream.Text);

            Array.Resize(ref doneEvents,k);
            Array.Resize(ref StrArray, k);

            int Lenght = words.Count / k;
            CountThread = -1;

            for (int i = 0; i < words.Count; i = i + Lenght)
            {
                CountThread++;
                SynchronizationContext uiContext = SynchronizationContext.Current;
                if (((words.Count - i) % (k - CountThread)) == 0) Lenght = ((words.Count - i) / (k - CountThread));
                doneEvents[CountThread] = new ManualResetEvent(false);
                var f = new StreamStringFind(CountThread, ShearhFunc, substring, Convert.ToInt32(Dopusk.Value), i, Lenght, words, doneEvents[CountThread], UpdateUI);
                StrArray[CountThread] = f;
                ThreadPool.QueueUserWorkItem(f.StreamStringRun, uiContext);              
            }
            
            
 
        }

                    

        private void CountStream_TextChanged(object sender, EventArgs e)
        {
                if (sender is DomainUpDown)
                {
                    DomainUpDown t = (sender as DomainUpDown);
                    try
                    {
                        t.Tag = Convert.ToInt32(t.Text);
                        t.ForeColor = Color.Black;
                        t.Tag = t.Text;
                        t.Refresh();
                    }
                    catch
                    {
                        //t.ForeColor = Color.Red;
                        t.Text = (string)t.Tag;
                        t.Refresh();
                    }
                }
        }

        public void UpdateUI(object state)
        {
            if (state is string) textBox1.AppendText((string)state);
            else if (state is WriteToForm)
            {
                
                if ((state as WriteToForm).writeToList.Length > 0)
                {
                    ListData.BeginUpdate();
                    ListData.Items.Add((state as WriteToForm).writeToList);
                    ListData.EndUpdate();
                }
                    
                if ((state as WriteToForm).writeToText.Length > 0) textBox1.AppendText((state as WriteToForm).writeToText);
                if ((state as WriteToForm).incris) progressBar1.Value++;
                if ((state as WriteToForm).StrimStop)
                {
                    CountThread--;
                    if (CountThread == -1)
                    {
                        stopwatchwork.Stop();
                        textBox1.AppendText("Время работы всех потоков : " + stopwatchwork.ElapsedMilliseconds + " ms");
                        toolStripStatusLabel2.Text = "Всё нашли за " + stopwatchwork.ElapsedMilliseconds + " ms";
                        File.AppendAllText(textBox4.Text, textBox1.Text);
                        timer1.Start();
                    }
                } 
            }            
        }
    }

    public class WriteToForm
    {
        public string writeToText;
        public string writeToList;
        public bool incris;
        public bool StrimStop;
        public int NumStream;
        
        public WriteToForm()
        {
            writeToText = "";
            writeToList = "";
            incris = false;
            StrimStop = false;
            NumStream = -1;

        }
    }

    public class StreamStringFind
    {
        private ManualResetEvent _doneEvent;
        private int NumSream; 
        private List<string> ListStr = new List<string>();
        private string FindStr;
        private int Dopusk;
        private int First;
        public Func<string, string, int> FuncFind = null;
        private SendOrPostCallback UpdateUI = null;

        public StreamStringFind(int numstream, Func<string, string, int> funcfind, 
                                    string findstr, int dopusk,int begitem,
                                    int len, List<string> words, ManualResetEvent doneEvent, SendOrPostCallback updateUI)
        {
            FindStr = findstr;
            FuncFind = funcfind;
            NumSream = numstream;
            Dopusk = dopusk;
            UpdateUI = updateUI;
            First = begitem;
            ListStr.Clear();
            for (int i = begitem; i < begitem + len ; i++) ListStr.Add(words[i]);
            _doneEvent = doneEvent;
        }

        public void StreamStringRun(Object threadContext)
        {
            SynchronizationContext uiContext = threadContext as SynchronizationContext;
            uiContext.Post(UpdateUI, "Начало работы потока номер : "+ NumSream+"\r\n");
            Stopwatch stopwatchwork = new Stopwatch();
            stopwatchwork.Start();
            foreach (string s in ListStr)
            {
                int Distance = FuncFind(s, FindStr);
                string sf = Convert.ToString(First);
                while (sf.Length < 4) sf = "0" + sf;
                WriteToForm w = new WriteToForm();
                w.writeToText = "Поток номер: " + NumSream + ". Обработана " + First + " строка - " +s+ ". Дистанция " + Distance +". ";
                if (Distance <= Dopusk)
                {
                    w.writeToText += " Добавлено в список";
                    w.writeToList = sf + " строка - " + s + ". Дистанция " + Distance;
                } 
                w.writeToText += " \r\n";
                w.incris = true;
                First++;
                uiContext.Post(UpdateUI, w);
            }
            stopwatchwork.Stop();
            _doneEvent.Set();
            WriteToForm ww = new WriteToForm();
            ww.writeToText = "Поток номер: " + NumSream + "  работу закончил. Время работы :  " + stopwatchwork.ElapsedMilliseconds + " ms\r\n";
            ww.StrimStop = true;
            ww.NumStream = NumSream;
            ww.incris = false;
            uiContext.Post(UpdateUI, ww);
        }

    }

}
