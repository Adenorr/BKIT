namespace WindowsFormsApp1
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
            this.LoadButton = new System.Windows.Forms.Button();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.ShearchButton = new System.Windows.Forms.Button();
            this.aTimeWork = new System.Windows.Forms.Label();
            this.aFileName = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ShearchTypeBox = new System.Windows.Forms.ComboBox();
            this.Dopusk = new System.Windows.Forms.NumericUpDown();
            this.ListData = new System.Windows.Forms.ListBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dopusk)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(12, 12);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(75, 23);
            this.LoadButton.TabIndex = 0;
            this.LoadButton.Text = "Файл";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // SearchText
            // 
            this.SearchText.Location = new System.Drawing.Point(105, 13);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(281, 22);
            this.SearchText.TabIndex = 1;
            this.SearchText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchText_KeyDown);
            // 
            // ShearchButton
            // 
            this.ShearchButton.Location = new System.Drawing.Point(795, 13);
            this.ShearchButton.Name = "ShearchButton";
            this.ShearchButton.Size = new System.Drawing.Size(75, 23);
            this.ShearchButton.TabIndex = 3;
            this.ShearchButton.Text = "Найти";
            this.ShearchButton.UseVisualStyleBackColor = true;
            this.ShearchButton.Click += new System.EventHandler(this.ShearchButton_Click);
            // 
            // aTimeWork
            // 
            this.aTimeWork.Location = new System.Drawing.Point(620, 396);
            this.aTimeWork.Name = "aTimeWork";
            this.aTimeWork.Size = new System.Drawing.Size(250, 17);
            this.aTimeWork.TabIndex = 4;
            this.aTimeWork.Text = "Время загрузки    мс";
            this.aTimeWork.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.aTimeWork.Visible = false;
            // 
            // aFileName
            // 
            this.aFileName.Location = new System.Drawing.Point(9, 396);
            this.aFileName.Name = "aFileName";
            this.aFileName.Size = new System.Drawing.Size(581, 23);
            this.aFileName.TabIndex = 5;
            this.aFileName.Text = "Открыт Файл                                                               ";
            this.aFileName.Visible = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 426);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(882, 24);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(450, 19);
            this.toolStripStatusLabel1.Text = "Открыт файл.. ";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.toolStripStatusLabel2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(190, 19);
            this.toolStripStatusLabel2.Text = "Время открытия файла ";
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 396);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(882, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // ShearchTypeBox
            // 
            this.ShearchTypeBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.ShearchTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShearchTypeBox.FormattingEnabled = true;
            this.ShearchTypeBox.Items.AddRange(new object[] {
            "простой поиск",
            "алгоритм Вагнера-Фишера",
            "алгоритм Дамерау-Левенштейна"});
            this.ShearchTypeBox.Location = new System.Drawing.Point(454, 11);
            this.ShearchTypeBox.Name = "ShearchTypeBox";
            this.ShearchTypeBox.Size = new System.Drawing.Size(335, 24);
            this.ShearchTypeBox.TabIndex = 1;
            // 
            // Dopusk
            // 
            this.Dopusk.Location = new System.Drawing.Point(393, 13);
            this.Dopusk.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Dopusk.Name = "Dopusk";
            this.Dopusk.Size = new System.Drawing.Size(53, 22);
            this.Dopusk.TabIndex = 9;
            this.Dopusk.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // ListData
            // 
            this.ListData.BackColor = System.Drawing.SystemColors.Window;
            this.ListData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListData.FormattingEnabled = true;
            this.ListData.ItemHeight = 18;
            this.ListData.Location = new System.Drawing.Point(0, 41);
            this.ListData.Name = "ListData";
            this.ListData.Size = new System.Drawing.Size(870, 346);
            this.ListData.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 450);
            this.Controls.Add(this.Dopusk);
            this.Controls.Add(this.ShearchTypeBox);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.aFileName);
            this.Controls.Add(this.aTimeWork);
            this.Controls.Add(this.ShearchButton);
            this.Controls.Add(this.SearchText);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.ListData);
            this.Name = "Form1";
            this.Text = "Подопригорова С. ИУ5-34Б";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dopusk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.TextBox SearchText;
        private System.Windows.Forms.Button ShearchButton;
        private System.Windows.Forms.Label aTimeWork;
        private System.Windows.Forms.Label aFileName;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox ShearchTypeBox;
        private System.Windows.Forms.NumericUpDown Dopusk;
        private System.Windows.Forms.ListBox ListData;
    }
}

