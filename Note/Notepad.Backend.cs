using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Note
{
    public partial class Notepad
    {
        private void StrRawsCount()
        {
            string text = textBox.Text;
            int str = 1, raws = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text.Length == 0)
                {
                    break;
                }
                raws++;
                if (text[i] == '\n')
                {
                    raws = 0;
                    str++;
                }
            }
            st_bar_rws_clmms.Text = "стр " + str.ToString() + ", стлб " + raws.ToString();
        }
    }
}
