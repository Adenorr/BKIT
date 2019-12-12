namespace lab7
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ListData = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ShearchButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.aFileName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CountStream = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.ShearchTypeBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Dopusk = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dopusk)).BeginInit();
            this.SuspendLayout();
            // 
            // ListData
            // 
            this.ListData.FormattingEnabled = true;
            this.ListData.ItemHeight = 25;
            this.ListData.Location = new System.Drawing.Point(2, 50);
            this.ListData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ListData.Name = "ListData";
            this.ListData.Size = new System.Drawing.Size(462, 554);
            this.ListData.Sorted = true;
            this.ListData.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(474, 50);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(697, 554);
            this.textBox1.TabIndex = 1;
            // 
            // SearchText
            // 
            this.SearchText.Location = new System.Drawing.Point(162, 6);
            this.SearchText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(630, 31);
            this.SearchText.TabIndex = 2;
            this.SearchText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SearchText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 5);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Файл";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ShearchButton
            // 
            this.ShearchButton.Location = new System.Drawing.Point(1010, 6);
            this.ShearchButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ShearchButton.Name = "ShearchButton";
            this.ShearchButton.Size = new System.Drawing.Size(135, 36);
            this.ShearchButton.TabIndex = 4;
            this.ShearchButton.Text = "Поиск";
            this.ShearchButton.UseVisualStyleBackColor = true;
            this.ShearchButton.Click += new System.EventHandler(this.ShearchButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aFileName,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 683);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1173, 25);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // aFileName
            // 
            this.aFileName.AutoSize = false;
            this.aFileName.Name = "aFileName";
            this.aFileName.Size = new System.Drawing.Size(360, 20);
            this.aFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(200, 20);
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CountStream
            // 
            this.CountStream.Location = new System.Drawing.Point(548, 12);
            this.CountStream.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CountStream.Name = "CountStream";
            this.CountStream.Size = new System.Drawing.Size(86, 31);
            this.CountStream.TabIndex = 9;
            this.CountStream.Text = "10";
            this.CountStream.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CountStream.TextChanged += new System.EventHandler(this.CountStream_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(432, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Потоков :";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(184, 12);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(238, 31);
            this.textBox4.TabIndex = 11;
            this.textBox4.Text = "logfile .txt";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ShearchTypeBox
            // 
            this.ShearchTypeBox.FormattingEnabled = true;
            this.ShearchTypeBox.Items.AddRange(new object[] {
            "Просрой",
            "Вагнера-Фишера",
            "Дамерау-Левенштейна"});
            this.ShearchTypeBox.Location = new System.Drawing.Point(792, 9);
            this.ShearchTypeBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ShearchTypeBox.Name = "ShearchTypeBox";
            this.ShearchTypeBox.Size = new System.Drawing.Size(360, 33);
            this.ShearchTypeBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(660, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Алгоритм  :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.ShearchTypeBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CountStream);
            this.panel1.Location = new System.Drawing.Point(2, 611);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1172, 53);
            this.panel1.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(10, 12);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 36);
            this.button2.TabIndex = 7;
            this.button2.Text = "Файл логов  :";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(9, 586);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1160, 36);
            this.progressBar1.TabIndex = 15;
            this.progressBar1.Visible = false;
            // 
            // Dopusk
            // 
            this.Dopusk.Location = new System.Drawing.Point(908, 8);
            this.Dopusk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Dopusk.Name = "Dopusk";
            this.Dopusk.Size = new System.Drawing.Size(72, 31);
            this.Dopusk.TabIndex = 16;
            this.Dopusk.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(802, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Допуск :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 708);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Dopusk);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ShearchButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SearchText);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ListData);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Подопригорова С. ИУ5-34Б";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dopusk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListData;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox SearchText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ShearchButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel aFileName;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox CountStream;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox ShearchTypeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.NumericUpDown Dopusk;
        private System.Windows.Forms.Label label3;
    }
}

