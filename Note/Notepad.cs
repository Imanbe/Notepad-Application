using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Note
{
    public partial class Notepad : Form
    {
        private int _fontSize = 0;
        private System.Drawing.FontStyle _fontStyle = FontStyle.Regular;
        private System.Drawing.Color _fontColor = Color.Black;
        private FontSettings fontSetts = new FontSettings();

        // menu_file
        //
        private string filename;
        private bool isFileChanged = true;
        public Notepad()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            filename = "";
            isFileChanged = false;
            UpdateTextWithTitle();
        }

        private void CreateNewDocument(object sender, EventArgs e)
        {
            SaveUnsavedFile();
            textBox.Text = "";
            filename = "";
            UpdateTextWithTitle();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            SaveUnsavedFile();
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamReader sr = new StreamReader(openFileDialog1.FileName);

                    textBox.Text = sr.ReadToEnd();
                    if (sr != null) sr.Close();
                    Text = Text.Replace('*'.ToString(), String.Empty);

                    filename = openFileDialog1.FileName;
                    isFileChanged = false;
                    textBox.SelectionStart = textBox.Text.Length;
                } catch
                {
                    MessageBox.Show("Невозможно открыть файл");
                }
                UpdateTextWithTitle();
            } else
            {
                return;
            }
        }

        private void SaveFile(string _filename)
        {
            if (_filename == "")
            {
                DialogResult res = saveFileDialog1.ShowDialog();
                if (res == DialogResult.OK)
                {
                    _filename = saveFileDialog1.FileName;
                } else if (res == DialogResult.Cancel)
                {
                    return;
                }
            }
            try
            {
                StreamWriter sw = new StreamWriter(_filename + ".txt");

                sw.Write(textBox.Text);
                if (sw != null) sw.Close();

                Text = Text.Replace('*'.ToString(), String.Empty);

                filename = _filename;
                isFileChanged = false;
            } catch
            {
                MessageBox.Show("Невозможно сохранить файл!");
            }
            UpdateTextWithTitle();
        }
        private void UpdateTextWithTitle()
        {
            if (filename != string.Empty)
            {
                Text = filename + " - Notepad";
            } else
            {
                Text = "Безымяннный - Notepad";
            }
        }

        private void SaveUnsavedFile()
        {
            if (isFileChanged)
            {
                DialogResult result = MessageBox.Show("Сохранить изменения в файле?", "Сохранение файла", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    SaveFile(filename);
                }
            }
        }

        private void Save(object sender, EventArgs e)
        {
            SaveFile(filename); 
        }

        private void SaveAs(object sender, EventArgs e)
        {
            SaveFile("");
        }

        //
        //menu_pravka
        //

        private void CopyText()
        {
            if (textBox.SelectedText != String.Empty)
            {
                Clipboard.SetText(textBox.SelectedText);
            }
        }

        private void CutText()
        {
            if (textBox.SelectedText != String.Empty)
            {
                string copied = textBox.SelectedText;
                int sPos = textBox.SelectionStart;
                textBox.SelectedText = textBox.SelectedText.Replace(copied, "");
                textBox.SelectionStart = sPos;
                Clipboard.SetText(copied);
            }
        }

        private void PasteText()
        {
            int sPos = textBox.SelectionStart;
            string text = Clipboard.GetText();

            if (textBox.SelectedText != String.Empty)
            {
                textBox.SelectedText = textBox.SelectedText.Replace(textBox.SelectedText, text);
            } else
            {
                textBox.Text = textBox.Text.Insert(textBox.SelectionStart, text);
                textBox.SelectionStart = sPos + text.Length;
            }
        }

        //
        //
        //
        private void textBoxChanging(object sender, EventArgs e)
        {
            StrRawsCount();
            onTextChanged();
        }
        private void TypeTimeAndData(object sender, EventArgs e)
        {
            int sPos = textBox.SelectionStart;
            textBox.Text += DateTime.Now.ToString();
            textBox.SelectionStart = textBox.Text.Length;

        }
        private void OnCutClick(object sender, EventArgs e)
        {
            CutText();
        }

        private void OnCopyClick(object sender, EventArgs e)
        {
            CopyText();
        }

        private void OnPastClick(object sender, EventArgs e)
        {
            PasteText();
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            SaveUnsavedFile();
        }

        private void OnFontClick(object sender, EventArgs e)
        {
            fontSetts.ShowDialog();
        }

        private void onFocus(object sender, EventArgs e)
        {
            if (!fontSetts.FontWasChanged)
            {
                _fontSize = fontSetts.fontSize;
                _fontStyle = fontSetts.fontStyle;
                _fontColor = fontSetts.fontColor;

                if (textBox.SelectedText != String.Empty)
                {
                    textBox.SelectionFont = new Font(textBox.SelectionFont.FontFamily, _fontSize, _fontStyle);
                    textBox.SelectionColor = _fontColor;
                } else
                {
                    textBox.Font = new Font(textBox.Font.FontFamily, _fontSize, _fontStyle);
                    textBox.ForeColor = _fontColor;
                }
                fontSetts.Hide();
            }
        }

        private void onExitClick(object sender, EventArgs e)
        {
            SaveUnsavedFile();
            fontSetts.Close();
            Application.Exit();
        }
        
        private void onTextChanged()
        {
            if (!isFileChanged)
            {
                Text = "*" + Text;
                isFileChanged = true;
            }
        }



        private void onPrintClick(object sender, EventArgs e)
        {

            // объект для печати
            PrintDocument printDocument = new PrintDocument();

            // обработчик события печати
            printDocument.PrintPage += PrintPageHandler;

            // диалог настройки печати
            PrintDialog printDialog = new PrintDialog();

            // установка объекта печати для его настройки
            printDialog.Document = printDocument;

            // если в диалоге было нажато ОК
            if (printDialog.ShowDialog() == DialogResult.OK)
                printDialog.Document.Print(); // печатаем
        }

        private void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            // печать строки result
            e.Graphics.DrawString(textBox.Text, textBox.Font, Brushes.Black, 0, 0);
        }
    }
}
