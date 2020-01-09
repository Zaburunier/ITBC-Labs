using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Lab4
{
    public partial class Form1
    {


        #region Код, автоматически созданный конструктором форм Windows

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

        #endregion

        private Button ChooseSystemFile;
        private Button SearchDesiredWord;
        private TextBox DesiredWord;
        private ListBox WordFoundList;
        private TextBox SearchTimeText;
        private Label SearchTimeLabel;
        private Label SearchWordLabel;
        private Label WordListLabel;
        private TextBox FilenameLabel;
        private Label LoadTimeLabel;
        private TextBox LoadTimeText;
        private Label SaveTimeLabel;
        private TextBox SaveTimeText;
    }
}

