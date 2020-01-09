using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Lab5Form : Form
    {
        public Lab5Form()
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
            }
            else
            { //Если файл не выбран, то сообщаем об ошибке
                MessageBox.Show("Ошибка; необходимо выбрать файл!");
            }
        }

        private void SearchDesiredWord_Click(object sender, EventArgs e) //Процедура для поиска заданного слова после нажатия кнопки
        {
            string desiredWord = this.DesiredWord.Text.Trim(); //Искомое слово
            if (!System.String.IsNullOrWhiteSpace(desiredWord) && wordList.Count > 0) //Если строка и файл не пустые
            {
                System.Diagnostics.Stopwatch timeForSearch = new System.Diagnostics.Stopwatch();
                timeForSearch.Start();
                this.WordFoundList.BeginUpdate();
                this.WordFoundList.Items.Clear();
                string desiredWordUppercase = desiredWord.ToUpper(); //Перевод всех букв в один регистр для исключения ошибок
                foreach (string temp in wordList) 
                //Проход по каждому слову из файла
                {
                    if (temp.ToUpper().Contains(desiredWordUppercase)) //Если текущий элемент массива содержит искомое слово, заданное в форме
                    {
                        this.WordFoundList.Items.Add(temp);
                    }
                }
                this.WordFoundList.EndUpdate();
                timeForSearch.Stop();
                this.SearchTimeText.Text = timeForSearch.Elapsed.ToString(); //Вывод времени поиска на экран
            }
            else
            {
                MessageBox.Show("Не выбран текстовый файл или заданная для поиска строка пуста!");
            }
        }

        private void SearchDesiredWord_withDistance_Click(object sender, EventArgs e)
        {
            string desiredWord = this.DesiredWord.Text.Trim(); //Искомое слово
            if (!System.String.IsNullOrWhiteSpace(desiredWord) && wordList.Count > 0) //Если строка и файл не пустые
            {
                int distanceMax;
                if (!int.TryParse(this.Distance.Text.Trim(), out distanceMax)) //Обработка возможных ошибок
                {
                    MessageBox.Show("Необходимо указать максимальное расстояние");
                    return;
                }
                if (distanceMax < 1 || distanceMax > 5)
                {
                    MessageBox.Show("Ошибка; расстояние может быть равно 1, 2 или 3!");
                    return;
                }
                System.Diagnostics.Stopwatch timeForSearch = new System.Diagnostics.Stopwatch();
                timeForSearch.Start();
                this.WordFoundList.BeginUpdate();
                this.WordFoundList.Items.Clear();
                foreach (string str in wordList) //Вычисление расстояния для каждого слова
                {
                    int tempDistance = DistanceLibrary_Lab5.Levenshtein.Distance(str.ToUpper(), desiredWord);                
                    if (tempDistance <= distanceMax)
                    { //Если по критерию расстояния наше слово подходит, то мы заносим его в список 
                        string temp = str + "; расстояние - " + tempDistance;
                        this.WordFoundList.Items.Add(temp);
                    }
                }
                this.WordFoundList.EndUpdate();
                timeForSearch.Stop();
                this.SearchTimeWithDistanceText.Text = timeForSearch.Elapsed.ToString();
            }
            else
            {
                MessageBox.Show("Необходимо выбрать файл и ввести слово для поиска");
            }
        }
    }
}
