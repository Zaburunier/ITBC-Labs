using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Lab4Form : Form
    {

        public Lab4Form()
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

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
