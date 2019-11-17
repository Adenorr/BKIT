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
            this.LoadButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.ListData = new System.Windows.Forms.ListBox();
            this.ShearchButton = new System.Windows.Forms.Button();
            this.aTimeWork = new System.Windows.Forms.Label();
            this.aFileName = new System.Windows.Forms.Label();
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // SearchText
            // 
            this.SearchText.Location = new System.Drawing.Point(105, 13);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(670, 22);
            this.SearchText.TabIndex = 1;
            this.SearchText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchText_KeyDown);
            // 
            // ListData
            // 
            this.ListData.FormattingEnabled = true;
            this.ListData.ItemHeight = 16;
            this.ListData.Location = new System.Drawing.Point(12, 53);
            this.ListData.Name = "ListData";
            this.ListData.Size = new System.Drawing.Size(858, 340);
            this.ListData.TabIndex = 2;
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
            this.aTimeWork.Location = new System.Drawing.Point(620, 412);
            this.aTimeWork.Name = "aTimeWork";
            this.aTimeWork.Size = new System.Drawing.Size(250, 17);
            this.aTimeWork.TabIndex = 4;
            this.aTimeWork.Text = "Время загрузки    мс";
            this.aTimeWork.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // aFileName
            // 
            this.aFileName.Location = new System.Drawing.Point(12, 412);
            this.aFileName.Name = "aFileName";
            this.aFileName.Size = new System.Drawing.Size(581, 23);
            this.aFileName.TabIndex = 5;
            this.aFileName.Text = "Открыт Файл                                                               ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 450);
            this.Controls.Add(this.aFileName);
            this.Controls.Add(this.aTimeWork);
            this.Controls.Add(this.ShearchButton);
            this.Controls.Add(this.ListData);
            this.Controls.Add(this.SearchText);
            this.Controls.Add(this.LoadButton);
            this.Name = "Form1";
            this.Text = "Подопригорова С. ИУ5-34Б";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox SearchText;
        private System.Windows.Forms.ListBox ListData;
        private System.Windows.Forms.Button ShearchButton;
        private System.Windows.Forms.Label aTimeWork;
        private System.Windows.Forms.Label aFileName;
    }
}

