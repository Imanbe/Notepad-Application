using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Note
{
    public partial class FontSettings : Form
    {
        public int fontSize = 0;
        public System.Drawing.FontStyle fontStyle = FontStyle.Regular;
        public System.Drawing.Color fontColor = Color.Black;
 
        public System.Drawing.Color deffontColor = Color.Black;
        public Font defFont;

        private bool fontWasChanged = false;

        public bool FontWasChanged
        {
            get
            {
                return fontWasChanged;
            }
        }

        public FontSettings()
        {
            InitializeComponent();
            fontBox.SelectedItem = fontBox.Items[0];
            styleBox.SelectedItem = styleBox.Items[0];
            colorBox.SelectedItem = colorBox.Items[5];

            defFont = new Font(label2.Font.FontFamily, 1, FontStyle.Regular);
        }

        private void onFontChange(object sender, EventArgs e)
        {
            label2.Font = new Font(label2.Font.FontFamily, int.Parse(fontBox.SelectedItem.ToString()), label2.Font.Style);
            fontSize = int.Parse(fontBox.SelectedItem.ToString());
            checkFontChanging();
            defFont = label2.Font;
        }

        private void onStyleChange(object sender, EventArgs e)
        {
            FontStyle selected_style = new FontStyle();

            switch (styleBox.SelectedItem.ToString())
            {
                case "обычный":
                    selected_style = FontStyle.Regular;
                    break;
                case "курсив" :
                    selected_style = FontStyle.Italic;
                    break;
                case "полужирный" :
                    selected_style = FontStyle.Bold;
                    break;
                case "вычеркивание" :
                    selected_style = FontStyle.Strikeout;
                    break;
                case "подчеркивание" :
                    selected_style = FontStyle.Underline;
                    break;
                default:
                    break;
            }
            label2.Font = new Font(label2.Font.FontFamily, int.Parse(fontBox.SelectedItem.ToString()), selected_style);
            fontStyle = label2.Font.Style;
            checkFontChanging();
            defFont = label2.Font;
        }

        private void onSaveFontClick(object sender, EventArgs e)
        {
            fontWasChanged = false;
            this.Hide();
        }

        private void onColorChange(object sender, EventArgs e)
        {
            Color selected_color = new Color();

            switch(colorBox.SelectedItem.ToString())
            {
                case "красный" :
                    selected_color = Color.Red;
                    break;
                case "синий" :
                    selected_color = Color.Blue;
                    break;
                case "зеленый" :
                    selected_color = Color.Green;
                    break;
                case "желтый" :
                    selected_color = Color.Yellow;
                    break;
                case "белый" :
                    selected_color = Color.White;
                    break;
                case "черный" :
                    selected_color= Color.Black;
                    break;
                default :
                    break;
            }

            label2.Font = new Font(label2.Font.FontFamily, int.Parse(fontBox.SelectedItem.ToString()), fontStyle);
            label2.ForeColor = selected_color;
            fontColor = selected_color;
            checkFontChanging();
            defFont = label2.Font;
        }

        //private void onFormClosing(object sender, FormClosingEventArgs e)
        //{
        //    if (fontWasChanged == false)
        //    {
        //        MessageBox.Show("Сохраните настройки перед закрытием!");
        //        e.Cancel = true;
        //    }
        //}

        private void checkFontChanging()
        {
            if (!label2.Font.Equals(defFont))
            {
                fontWasChanged = true;
            }
        }
    }
}
