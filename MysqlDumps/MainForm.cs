using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MysqlDumps
{
    public partial class MainForm : Form
    {

        public string PATH_MYSQLDUMP = @"C:\Program Files\MySQL\MySQL Server 5.5\bin\mysqldump.exe";

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            txtIP.Text = "127.0.0.1";

            txtUser.Text = "root";

            txtPassword.Text = "root";
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GetDatabases(txtIP.Text, txtUser.Text, txtPassword.Text);
            }
        }

        private void txtIP_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GetDatabases(txtIP.Text, txtUser.Text, txtPassword.Text);
            }
        }

        private void txtUser_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GetDatabases(txtIP.Text, txtUser.Text, txtPassword.Text);
            }
        }

        private void btnGetTables_Click(object sender, EventArgs e)
        {
            GetTables(txtIP.Text, cbDatabaseName.Text, txtUser.Text, txtPassword.Text);
        }



        public void GetTables(string ip, string database, string user, string password)
        {
            try
            {
                tablesList.Items.Clear();

                List<string> tables = MysqlInfo.GetTables(ip, database, user, password);

                foreach (string table in tables)
                {
                    tablesList.Items.Add(table, false);
                }

            }
            catch (Exception ex)
            {
                Message.Err(ex.Message);
            }

        }

        public void GetDatabases(string ip, string user, string password)
        {
            try
            {
                cbDatabaseName.Items.Clear();

                List<string> databases = MysqlInfo.GetDatabaseName(ip, user, password);

                foreach (string database in databases)
                {
                    cbDatabaseName.Items.Add(database);
                }

                if (databases.Count >= 1)
                {
                    cbDatabaseName.SelectedIndex = (0);
                }
            }
            catch (Exception ex)
            {
                Message.Err(ex.Message);
            }

        }

        private void btnFindFolder_Click(object sender, EventArgs e)
        {

            DialogResult result = folderBrowser.ShowDialog();

            if (result == DialogResult.OK)
            {
                lblDirFolder.Text = folderBrowser.SelectedPath;
            }

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(PATH_MYSQLDUMP))
                {
                    ChangePathMysqldump();

                    return;
                }

                string PathFolder = lblDirFolder.Text;

                if (PathFolder.Equals("...") || !Directory.Exists(PathFolder))
                {
                    Message.Warn(String.Format("The directory={0} does not exist ", PathFolder));

                    return;
                }

                string args = String.Format(" --host={0} --user={1} --password={2} ", txtIP.Text, txtUser.Text, txtPassword.Text);

                args += " {0} {1} {2}";

                string additionalArgs = string.Empty;

                if (chbHexBlob.Checked)
                {
                    additionalArgs += chbHexBlob.Text + " ";
                }

                if (chbExtendInsert.Checked)
                {
                    additionalArgs += chbExtendInsert.Text;
                }

                btnStart.Text = "Loanding...";

                btnStart.Enabled = false;

                foreach (var item in tablesList.CheckedItems)
                {
                    MysqlBackup.Backup(PATH_MYSQLDUMP, PathFolder, item.ToString(), String.Format(args, additionalArgs, cbDatabaseName.Text, item.ToString()));
                }

                btnStart.Text = "Start";

                btnStart.Enabled = true;

                Message.Info("Success");
            }
            catch (Exception ex)
            {
                Message.Err(ex.Message);

                btnStart.Text = "Start";

                btnStart.Enabled = true;
            }
        }

        private void setPathMysqldumpexeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePathMysqldump();
        }


        public void ChangePathMysqldump()
        {
            openFile.InitialDirectory = "c:\\Program Files\\MySQL";

            openFile.Filter = "exe | *.exe";

            if (DialogResult.OK == openFile.ShowDialog())
            {
                PATH_MYSQLDUMP = openFile.FileName;
            }
        }
    }
}
