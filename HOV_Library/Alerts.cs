using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOV_Library
{
    internal class Alerts
    {
        public static DialogResult Success(string message)
        {
            return MessageBox.Show(message, "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult Error(string message)
        {
            return MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult Confirm(string message)
        {
            return MessageBox.Show(message, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
