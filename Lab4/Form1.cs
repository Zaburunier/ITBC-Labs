using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        List<string> wordList = new List<string>();
        private void ChooseSystemFile_Click(object sender, EventArgs e) //Процедура для выбора файла и его чтения
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Text files|*.txt"; //Ограничение доступных расширений
            if (fileDialog.ShowDialog() == DialogResult.OK) //Открытие диалогового окна
            {
                System.Diagnostics.Stopwatch timeForLoad = new System.Diagnostics.Stopwatch();
                System.Diagnostics.Stopwatch timeForSave = new System.Diagnostics.Stopwatch();
                timeForLoad.Start();
                timeForSave.Start();
                string fileText = System.IO.File.ReadAllText(fileDialog.FileName); //Считываем содержимое файла
                timeForLoad.Stop();
                char[] dividerSymbolsArray = new char[] { ' ', '.', ',', '!', '?', '/', '\t', '\n' }; //Задаём символы как критерии для разделения текста на слова
                string[] textArray = fileText.Split(dividerSymbolsArray); //Разбиваем на слова
                foreach (string word in textArray)
                {
                    string temp = word.Trim(); //?
                    if (wordList.Contains(temp) != true) //Если строки нет в списке, то добавляем её как новый член
                        wordList.Add(temp);

                }
                timeForSave.Stop();
                LoadTimeText.Text = timeForLoad.Elapsed.ToString();
                SaveTimeText.Text = timeForSave.Elapsed.ToString();
                FilenameLabel.Text = fileDialog.FileName;
            } else { //Если файл не выбран, то сообщаем об ошибке
                MessageBox.Show("Ошибка; необходимо выбрать файл!");
            }
        }

        private void SearchDesiredWord_Click(object sender, EventArgs e) //Процедура для поиска заданного слова после нажатия кнопки
        {
            string desiredWord = this.DesiredWord.Text.Trim(); //Искомое слово
            if (!string.IsNullOrWhiteSpace(desiredWord) && wordList.Count > 0) //Если строка и файл не пустые
            {
                System.Diagnostics.Stopwatch timeForSearch = new System.Diagnostics.Stopwatch();
                timeForSearch.Start();
                this.WordFoundList.BeginUpdate();
                this.WordFoundList.Items.Clear();
                foreach (string temp in wordList) //Проход по каждому слову из файла
                {
                    if (temp.Contains(desiredWord)) //Если текущий элемент массива содержит искомое слово, заданное в форме
                    {
                        this.WordFoundList.Items.Add(temp);
                    }
                }
                this.WordFoundList.EndUpdate();
                timeForSearch.Stop();
                this.SearchTimeText.Text = timeForSearch.Elapsed.ToString(); //Вывод времени поиска на экран
            } else {
                MessageBox.Show("Не выбран текстовый файл или заданная для поиска строка пуста!");
            }
        }

        private void InitializeComponent()
        {
            this.ChooseSystemFile = new System.Windows.Forms.Button();
            this.SearchDesiredWord = new System.Windows.Forms.Button();
            this.DesiredWord = new System.Windows.Forms.TextBox();
            this.WordFoundList = new System.Windows.Forms.ListBox();
            this.SearchTimeText = new System.Windows.Forms.TextBox();
            this.SearchTimeLabel = new System.Windows.Forms.Label();
            this.SearchWordLabel = new System.Windows.Forms.Label();
            this.WordListLabel = new System.Windows.Forms.Label();
            this.FilenameLabel = new System.Windows.Forms.TextBox();
            this.LoadTimeLabel = new System.Windows.Forms.Label();
            this.LoadTimeText = new System.Windows.Forms.TextBox();
            this.SaveTimeLabel = new System.Windows.Forms.Label();
            this.SaveTimeText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ChooseSystemFile
            // 
            this.ChooseSystemFile.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ChooseSystemFile.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseSystemFile.ForeColor = System.Drawing.Color.White;
            this.ChooseSystemFile.Location = new System.Drawing.Point(20, 19);
            this.ChooseSystemFile.Name = "ChooseSystemFile";
            this.ChooseSystemFile.Size = new System.Drawing.Size(132, 34);
            this.ChooseSystemFile.TabIndex = 0;
            this.ChooseSystemFile.Text = "Выбрать файл";
            this.ChooseSystemFile.UseVisualStyleBackColor = false;
            this.ChooseSystemFile.Click += new System.EventHandler(this.ChooseSystemFile_Click);
            // 
            // SearchDesiredWord
            // 
            this.SearchDesiredWord.BackColor = System.Drawing.Color.DarkSlateGray;
            this.SearchDesiredWord.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchDesiredWord.ForeColor = System.Drawing.Color.White;
            this.SearchDesiredWord.Location = new System.Drawing.Point(247, 127);
            this.SearchDesiredWord.Name = "SearchDesiredWord";
            this.SearchDesiredWord.Size = new System.Drawing.Size(140, 51);
            this.SearchDesiredWord.TabIndex = 1;
            this.SearchDesiredWord.Text = "Найти введённое слово\r\n";
            this.SearchDesiredWord.UseVisualStyleBackColor = false;
            this.SearchDesiredWord.Click += new System.EventHandler(this.SearchDesiredWord_Click);
            // 
            // DesiredWord
            // 
            this.DesiredWord.BackColor = System.Drawing.Color.DarkSlateGray;
            this.DesiredWord.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DesiredWord.ForeColor = System.Drawing.Color.White;
            this.DesiredWord.Location = new System.Drawing.Point(28, 144);
            this.DesiredWord.Name = "DesiredWord";
            this.DesiredWord.Size = new System.Drawing.Size(213, 27);
            this.DesiredWord.TabIndex = 2;
            // 
            // WordFoundList
            // 
            this.WordFoundList.BackColor = System.Drawing.Color.DarkSlateGray;
            this.WordFoundList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WordFoundList.ForeColor = System.Drawing.Color.White;
            this.WordFoundList.FormattingEnabled = true;
            this.WordFoundList.ItemHeight = 19;
            this.WordFoundList.Location = new System.Drawing.Point(28, 196);
            this.WordFoundList.Name = "WordFoundList";
            this.WordFoundList.Size = new System.Drawing.Size(213, 156);
            this.WordFoundList.TabIndex = 3;
            // 
            // SearchTimeText
            // 
            this.SearchTimeText.BackColor = System.Drawing.Color.DarkSlateGray;
            this.SearchTimeText.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchTimeText.ForeColor = System.Drawing.Color.White;
            this.SearchTimeText.Location = new System.Drawing.Point(393, 172);
            this.SearchTimeText.Name = "SearchTimeText";
            this.SearchTimeText.ReadOnly = true;
            this.SearchTimeText.Size = new System.Drawing.Size(130, 23);
            this.SearchTimeText.TabIndex = 4;
            // 
            // SearchTimeLabel
            // 
            this.SearchTimeLabel.AutoSize = true;
            this.SearchTimeLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchTimeLabel.ForeColor = System.Drawing.Color.White;
            this.SearchTimeLabel.Location = new System.Drawing.Point(389, 150);
            this.SearchTimeLabel.Name = "SearchTimeLabel";
            this.SearchTimeLabel.Size = new System.Drawing.Size(108, 19);
            this.SearchTimeLabel.TabIndex = 5;
            this.SearchTimeLabel.Text = "Время поиска:";
            // 
            // SearchWordLabel
            // 
            this.SearchWordLabel.AutoSize = true;
            this.SearchWordLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchWordLabel.ForeColor = System.Drawing.Color.White;
            this.SearchWordLabel.Location = new System.Drawing.Point(24, 122);
            this.SearchWordLabel.Name = "SearchWordLabel";
            this.SearchWordLabel.Size = new System.Drawing.Size(113, 19);
            this.SearchWordLabel.TabIndex = 6;
            this.SearchWordLabel.Text = "Введите слово:";
            // 
            // WordListLabel
            // 
            this.WordListLabel.AutoSize = true;
            this.WordListLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WordListLabel.ForeColor = System.Drawing.Color.White;
            this.WordListLabel.Location = new System.Drawing.Point(24, 174);
            this.WordListLabel.Name = "WordListLabel";
            this.WordListLabel.Size = new System.Drawing.Size(179, 19);
            this.WordListLabel.TabIndex = 7;
            this.WordListLabel.Text = "Список найденных слов:";
            // 
            // FilenameLabel
            // 
            this.FilenameLabel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.FilenameLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilenameLabel.ForeColor = System.Drawing.Color.White;
            this.FilenameLabel.Location = new System.Drawing.Point(158, 24);
            this.FilenameLabel.Name = "FilenameLabel";
            this.FilenameLabel.ReadOnly = true;
            this.FilenameLabel.Size = new System.Drawing.Size(506, 27);
            this.FilenameLabel.TabIndex = 8;
            // 
            // LoadTimeLabel
            // 
            this.LoadTimeLabel.AutoSize = true;
            this.LoadTimeLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoadTimeLabel.ForeColor = System.Drawing.Color.White;
            this.LoadTimeLabel.Location = new System.Drawing.Point(389, 54);
            this.LoadTimeLabel.Name = "LoadTimeLabel";
            this.LoadTimeLabel.Size = new System.Drawing.Size(167, 19);
            this.LoadTimeLabel.TabIndex = 9;
            this.LoadTimeLabel.Text = "Время загрузки файла:";
            // 
            // LoadTimeText
            // 
            this.LoadTimeText.BackColor = System.Drawing.Color.DarkSlateGray;
            this.LoadTimeText.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoadTimeText.ForeColor = System.Drawing.Color.White;
            this.LoadTimeText.Location = new System.Drawing.Point(393, 76);
            this.LoadTimeText.Name = "LoadTimeText";
            this.LoadTimeText.ReadOnly = true;
            this.LoadTimeText.Size = new System.Drawing.Size(130, 23);
            this.LoadTimeText.TabIndex = 10;
            // 
            // SaveTimeLabel
            // 
            this.SaveTimeLabel.AutoSize = true;
            this.SaveTimeLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveTimeLabel.ForeColor = System.Drawing.Color.White;
            this.SaveTimeLabel.Location = new System.Drawing.Point(389, 102);
            this.SaveTimeLabel.Name = "SaveTimeLabel";
            this.SaveTimeLabel.Size = new System.Drawing.Size(189, 19);
            this.SaveTimeLabel.TabIndex = 11;
            this.SaveTimeLabel.Text = "Время сохранения файла:";
            // 
            // SaveTimeText
            // 
            this.SaveTimeText.BackColor = System.Drawing.Color.DarkSlateGray;
            this.SaveTimeText.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveTimeText.ForeColor = System.Drawing.Color.White;
            this.SaveTimeText.Location = new System.Drawing.Point(393, 124);
            this.SaveTimeText.Name = "SaveTimeText";
            this.SaveTimeText.ReadOnly = true;
            this.SaveTimeText.Size = new System.Drawing.Size(130, 23);
            this.SaveTimeText.TabIndex = 12;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(773, 575);
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
            this.Name = "Form1";
            this.Text = "Забурунов РТ5-31Б, Лаб.4";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
