using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BackupMonitor
{
    public static class Validate
    {

        public static bool IsDouble(string text)
        {
            try
            {
                Convert.ToDouble(text);
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }

        public static bool IsDouble(TextBox textBox)
        {
            return IsDouble(textBox.Text);
        }
    }
}
