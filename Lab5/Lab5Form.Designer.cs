namespace Lab5
{
    partial class Lab5Form
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
            this.SaveTimeText = new System.Windows.Forms.TextBox();
            this.SaveTimeLabel = new System.Windows.Forms.Label();
            this.LoadTimeText = new System.Windows.Forms.TextBox();
            this.LoadTimeLabel = new System.Windows.Forms.Label();
            this.FilenameLabel = new System.Windows.Forms.TextBox();
            this.WordListLabel = new System.Windows.Forms.Label();
            this.SearchWordLabel = new System.Windows.Forms.Label();
            this.SearchTimeLabel = new System.Windows.Forms.Label();
            this.SearchTimeText = new System.Windows.Forms.TextBox();
            this.WordFoundList = new System.Windows.Forms.ListBox();
            this.DesiredWord = new System.Windows.Forms.TextBox();
            this.SearchDesiredWord = new System.Windows.Forms.Button();
            this.ChooseSystemFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Distance = new System.Windows.Forms.TextBox();
            this.SearchDesiredWord_withDistance = new System.Windows.Forms.Button();
            this.SearchTimeWithDistanceLabel = new System.Windows.Forms.Label();
            this.SearchTimeWithDistanceText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SaveTimeText
            // 
            this.SaveTimeText.BackColor = System.Drawing.Color.DarkSlateGray;
            this.SaveTimeText.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveTimeText.ForeColor = System.Drawing.Color.White;
            this.SaveTimeText.Location = new System.Drawing.Point(405, 120);
            this.SaveTimeText.Name = "SaveTimeText";
            this.SaveTimeText.ReadOnly = true;
            this.SaveTimeText.Size = new System.Drawing.Size(130, 23);
            this.SaveTimeText.TabIndex = 25;
            // 
            // SaveTimeLabel
            // 
            this.SaveTimeLabel.AutoSize = true;
            this.SaveTimeLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveTimeLabel.ForeColor = System.Drawing.Color.White;
            this.SaveTimeLabel.Location = new System.Drawing.Point(401, 98);
            this.SaveTimeLabel.Name = "SaveTimeLabel";
            this.SaveTimeLabel.Size = new System.Drawing.Size(189, 19);
            this.SaveTimeLabel.TabIndex = 24;
            this.SaveTimeLabel.Text = "Время сохранения файла:";
            // 
            // LoadTimeText
            // 
            this.LoadTimeText.BackColor = System.Drawing.Color.DarkSlateGray;
            this.LoadTimeText.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoadTimeText.ForeColor = System.Drawing.Color.White;
            this.LoadTimeText.Location = new System.Drawing.Point(405, 72);
            this.LoadTimeText.Name = "LoadTimeText";
            this.LoadTimeText.ReadOnly = true;
            this.LoadTimeText.Size = new System.Drawing.Size(130, 23);
            this.LoadTimeText.TabIndex = 23;
            // 
            // LoadTimeLabel
            // 
            this.LoadTimeLabel.AutoSize = true;
            this.LoadTimeLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoadTimeLabel.ForeColor = System.Drawing.Color.White;
            this.LoadTimeLabel.Location = new System.Drawing.Point(401, 50);
            this.LoadTimeLabel.Name = "LoadTimeLabel";
            this.LoadTimeLabel.Size = new System.Drawing.Size(167, 19);
            this.LoadTimeLabel.TabIndex = 22;
            this.LoadTimeLabel.Text = "Время загрузки файла:";
            // 
            // FilenameLabel
            // 
            this.FilenameLabel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.FilenameLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilenameLabel.ForeColor = System.Drawing.Color.White;
            this.FilenameLabel.Location = new System.Drawing.Point(150, 17);
            this.FilenameLabel.Name = "FilenameLabel";
            this.FilenameLabel.ReadOnly = true;
            this.FilenameLabel.Size = new System.Drawing.Size(506, 27);
            this.FilenameLabel.TabIndex = 21;
            // 
            // WordListLabel
            // 
            this.WordListLabel.AutoSize = true;
            this.WordListLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WordListLabel.ForeColor = System.Drawing.Color.White;
            this.WordListLabel.Location = new System.Drawing.Point(16, 197);
            this.WordListLabel.Name = "WordListLabel";
            this.WordListLabel.Size = new System.Drawing.Size(179, 19);
            this.WordListLabel.TabIndex = 20;
            this.WordListLabel.Text = "Список найденных слов:";
            // 
            // SearchWordLabel
            // 
            this.SearchWordLabel.AutoSize = true;
            this.SearchWordLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchWordLabel.ForeColor = System.Drawing.Color.White;
            this.SearchWordLabel.Location = new System.Drawing.Point(16, 56);
            this.SearchWordLabel.Name = "SearchWordLabel";
            this.SearchWordLabel.Size = new System.Drawing.Size(113, 19);
            this.SearchWordLabel.TabIndex = 19;
            this.SearchWordLabel.Text = "Введите слово:";
            // 
            // SearchTimeLabel
            // 
            this.SearchTimeLabel.AutoSize = true;
            this.SearchTimeLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchTimeLabel.ForeColor = System.Drawing.Color.White;
            this.SearchTimeLabel.Location = new System.Drawing.Point(401, 146);
            this.SearchTimeLabel.Name = "SearchTimeLabel";
            this.SearchTimeLabel.Size = new System.Drawing.Size(108, 19);
            this.SearchTimeLabel.TabIndex = 18;
            this.SearchTimeLabel.Text = "Время поиска:";
            // 
            // SearchTimeText
            // 
            this.SearchTimeText.BackColor = System.Drawing.Color.DarkSlateGray;
            this.SearchTimeText.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchTimeText.ForeColor = System.Drawing.Color.White;
            this.SearchTimeText.Location = new System.Drawing.Point(405, 168);
            this.SearchTimeText.Name = "SearchTimeText";
            this.SearchTimeText.ReadOnly = true;
            this.SearchTimeText.Size = new System.Drawing.Size(130, 23);
            this.SearchTimeText.TabIndex = 17;
            // 
            // WordFoundList
            // 
            this.WordFoundList.BackColor = System.Drawing.Color.DarkSlateGray;
            this.WordFoundList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WordFoundList.ForeColor = System.Drawing.Color.White;
            this.WordFoundList.FormattingEnabled = true;
            this.WordFoundList.ItemHeight = 19;
            this.WordFoundList.Location = new System.Drawing.Point(20, 231);
            this.WordFoundList.Name = "WordFoundList";
            this.WordFoundList.Size = new System.Drawing.Size(233, 289);
            this.WordFoundList.TabIndex = 16;
            // 
            // DesiredWord
            // 
            this.DesiredWord.BackColor = System.Drawing.Color.DarkSlateGray;
            this.DesiredWord.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DesiredWord.ForeColor = System.Drawing.Color.White;
            this.DesiredWord.Location = new System.Drawing.Point(20, 80);
            this.DesiredWord.Name = "DesiredWord";
            this.DesiredWord.Size = new System.Drawing.Size(148, 27);
            this.DesiredWord.TabIndex = 15;
            // 
            // SearchDesiredWord
            // 
            this.SearchDesiredWord.BackColor = System.Drawing.Color.DarkSlateGray;
            this.SearchDesiredWord.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchDesiredWord.ForeColor = System.Drawing.Color.White;
            this.SearchDesiredWord.Location = new System.Drawing.Point(174, 56);
            this.SearchDesiredWord.Name = "SearchDesiredWord";
            this.SearchDesiredWord.Size = new System.Drawing.Size(190, 51);
            this.SearchDesiredWord.TabIndex = 14;
            this.SearchDesiredWord.Text = "Найти введённое слово\r\n";
            this.SearchDesiredWord.UseVisualStyleBackColor = false;
            this.SearchDesiredWord.Click += new System.EventHandler(this.SearchDesiredWord_Click);
            // 
            // ChooseSystemFile
            // 
            this.ChooseSystemFile.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ChooseSystemFile.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseSystemFile.ForeColor = System.Drawing.Color.White;
            this.ChooseSystemFile.Location = new System.Drawing.Point(12, 12);
            this.ChooseSystemFile.Name = "ChooseSystemFile";
            this.ChooseSystemFile.Size = new System.Drawing.Size(132, 34);
            this.ChooseSystemFile.TabIndex = 13;
            this.ChooseSystemFile.Text = "Выбрать файл";
            this.ChooseSystemFile.UseVisualStyleBackColor = false;
            this.ChooseSystemFile.Click += new System.EventHandler(this.ChooseSystemFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 19);
            this.label1.TabIndex = 26;
            this.label1.Text = "Введите расстояние:";
            // 
            // Distance
            // 
            this.Distance.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Distance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Distance.ForeColor = System.Drawing.Color.White;
            this.Distance.Location = new System.Drawing.Point(20, 146);
            this.Distance.Name = "Distance";
            this.Distance.Size = new System.Drawing.Size(148, 27);
            this.Distance.TabIndex = 27;
            // 
            // SearchDesiredWord_withDistance
            // 
            this.SearchDesiredWord_withDistance.BackColor = System.Drawing.Color.DarkSlateGray;
            this.SearchDesiredWord_withDistance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchDesiredWord_withDistance.ForeColor = System.Drawing.Color.White;
            this.SearchDesiredWord_withDistance.Location = new System.Drawing.Point(174, 113);
            this.SearchDesiredWord_withDistance.Name = "SearchDesiredWord_withDistance";
            this.SearchDesiredWord_withDistance.Size = new System.Drawing.Size(190, 71);
            this.SearchDesiredWord_withDistance.TabIndex = 28;
            this.SearchDesiredWord_withDistance.Text = "Найти введённое слово\r\n (с учётом расстояния Левенштайна)";
            this.SearchDesiredWord_withDistance.UseVisualStyleBackColor = false;
            this.SearchDesiredWord_withDistance.Click += new System.EventHandler(this.SearchDesiredWord_withDistance_Click);
            // 
            // SearchTimeWithDistanceLabel
            // 
            this.SearchTimeWithDistanceLabel.AutoSize = true;
            this.SearchTimeWithDistanceLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchTimeWithDistanceLabel.ForeColor = System.Drawing.Color.White;
            this.SearchTimeWithDistanceLabel.Location = new System.Drawing.Point(401, 194);
            this.SearchTimeWithDistanceLabel.Name = "SearchTimeWithDistanceLabel";
            this.SearchTimeWithDistanceLabel.Size = new System.Drawing.Size(212, 19);
            this.SearchTimeWithDistanceLabel.TabIndex = 29;
            this.SearchTimeWithDistanceLabel.Text = "Время поиска с расстоянием:";
            // 
            // SearchTimeWithDistanceText
            // 
            this.SearchTimeWithDistanceText.BackColor = System.Drawing.Color.DarkSlateGray;
            this.SearchTimeWithDistanceText.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchTimeWithDistanceText.ForeColor = System.Drawing.Color.White;
            this.SearchTimeWithDistanceText.Location = new System.Drawing.Point(405, 216);
            this.SearchTimeWithDistanceText.Name = "SearchTimeWithDistanceText";
            this.SearchTimeWithDistanceText.ReadOnly = true;
            this.SearchTimeWithDistanceText.Size = new System.Drawing.Size(130, 23);
            this.SearchTimeWithDistanceText.TabIndex = 30;
            // 
            // Lab5Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(800, 639);
            this.Controls.Add(this.SearchTimeWithDistanceText);
            this.Controls.Add(this.SearchTimeWithDistanceLabel);
            this.Controls.Add(this.SearchDesiredWord_withDistance);
            this.Controls.Add(this.Distance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveTimeText);
            this.Controls.Add(this.SaveTimeLabel);
            this.Controls.Add(this.LoadTimeText);
            this.Controls.Add(this.LoadTimeLabel);
            this.Controls.Add(this.FilenameLabel);
            this.Controls.Add(this.WordListLabel);
            this.Controls.Add(this.SearchWordLabel);
            this.Controls.Add(this.SearchTimeLabel);
            this.Controls.Add(this.SearchTimeText);
            this.Controls.Add(this.WordFoundList);
            this.Controls.Add(this.DesiredWord);
            this.Controls.Add(this.SearchDesiredWord);
            this.Controls.Add(this.ChooseSystemFile);
            this.Name = "Lab5Form";
            this.Text = "Лабораторная работа №5. Забурунов Леонид, РТ5-31-2019";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SaveTimeText;
        private System.Windows.Forms.Label SaveTimeLabel;
        private System.Windows.Forms.TextBox LoadTimeText;
        private System.Windows.Forms.Label LoadTimeLabel;
        private System.Windows.Forms.TextBox FilenameLabel;
        private System.Windows.Forms.Label WordListLabel;
        private System.Windows.Forms.Label SearchWordLabel;
        private System.Windows.Forms.Label SearchTimeLabel;
        private System.Windows.Forms.TextBox SearchTimeText;
        private System.Windows.Forms.ListBox WordFoundList;
        private System.Windows.Forms.TextBox DesiredWord;
        private System.Windows.Forms.Button SearchDesiredWord;
        private System.Windows.Forms.Button ChooseSystemFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Distance;
        private System.Windows.Forms.Button SearchDesiredWord_withDistance;
        private System.Windows.Forms.Label SearchTimeWithDistanceLabel;
        private System.Windows.Forms.TextBox SearchTimeWithDistanceText;
    }
}

