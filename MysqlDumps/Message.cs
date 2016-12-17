using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MysqlDumps
{
    class Message
    {
        public static void Info(string title, string message)
        {

            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Question);

        }

        public static void Info(string message)
        {
            Info("Information", message);
        }

        public static void Warn(string title, string message)
        {

            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        public static void Warn(string message)
        {
            Warn("Warning", message);
        }

        public static void Err(string title, string message)
        {

            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        public static void Err(string message)
        {
            Err("Error", message);
        }



    }
}
