namespace MysqlDumps
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGetTables = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbDatabaseName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tablesList = new System.Windows.Forms.CheckedListBox();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.btnFindFolder = new System.Windows.Forms.Button();
            this.lblDirFolder = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbHexBlob = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setPathMysqldumpexeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.chbExtendInsert = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGetTables);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbDatabaseName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtUser);
            this.panel1.Controls.Add(this.txtIP);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 182);
            this.panel1.TabIndex = 0;
            // 
            // btnGetTables
            // 
            this.btnGetTables.Location = new System.Drawing.Point(141, 150);
            this.btnGetTables.Name = "btnGetTables";
            this.btnGetTables.Size = new System.Drawing.Size(75, 23);
            this.btnGetTables.TabIndex = 9;
            this.btnGetTables.Text = "Get Tables";
            this.btnGetTables.UseVisualStyleBackColor = true;
            this.btnGetTables.Click += new System.EventHandler(this.btnGetTables_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Datebase Name";
            // 
            // cbDatabaseName
            // 
            this.cbDatabaseName.FormattingEnabled = true;
            this.cbDatabaseName.Location = new System.Drawing.Point(141, 112);
            this.cbDatabaseName.Name = "cbDatabaseName";
            this.cbDatabaseName.Size = new System.Drawing.Size(154, 21);
            this.cbDatabaseName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "User";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(141, 76);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(154, 20);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyUp);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(141, 39);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(154, 20);
            this.txtUser.TabIndex = 2;
            this.txtUser.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtUser_KeyUp);
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(141, 3);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(154, 20);
            this.txtIP.TabIndex = 1;
            this.txtIP.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtIP_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // tablesList
            // 
            this.tablesList.FormattingEnabled = true;
            this.tablesList.Location = new System.Drawing.Point(3, 218);
            this.tablesList.Name = "tablesList";
            this.tablesList.Size = new System.Drawing.Size(350, 214);
            this.tablesList.TabIndex = 1;
            // 
            // btnFindFolder
            // 
            this.btnFindFolder.Location = new System.Drawing.Point(3, 438);
            this.btnFindFolder.Name = "btnFindFolder";
            this.btnFindFolder.Size = new System.Drawing.Size(75, 23);
            this.btnFindFolder.TabIndex = 2;
            this.btnFindFolder.Text = "Find Folder";
            this.btnFindFolder.UseVisualStyleBackColor = true;
            this.btnFindFolder.Click += new System.EventHandler(this.btnFindFolder_Click);
            // 
            // lblDirFolder
            // 
            this.lblDirFolder.AutoSize = true;
            this.lblDirFolder.Location = new System.Drawing.Point(84, 443);
            this.lblDirFolder.Name = "lblDirFolder";
            this.lblDirFolder.Size = new System.Drawing.Size(16, 13);
            this.lblDirFolder.TabIndex = 3;
            this.lblDirFolder.Text = "...";
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnStart.Location = new System.Drawing.Point(144, 573);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbExtendInsert);
            this.groupBox1.Controls.Add(this.chbHexBlob);
            this.groupBox1.Location = new System.Drawing.Point(3, 467);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parameters";
            // 
            // chbHexBlob
            // 
            this.chbHexBlob.AutoSize = true;
            this.chbHexBlob.Location = new System.Drawing.Point(9, 29);
            this.chbHexBlob.Name = "chbHexBlob";
            this.chbHexBlob.Size = new System.Drawing.Size(72, 17);
            this.chbHexBlob.TabIndex = 0;
            this.chbHexBlob.Text = "--hex-blob";
            this.chbHexBlob.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(356, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setPathMysqldumpexeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // setPathMysqldumpexeToolStripMenuItem
            // 
            this.setPathMysqldumpexeToolStripMenuItem.Name = "setPathMysqldumpexeToolStripMenuItem";
            this.setPathMysqldumpexeToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.setPathMysqldumpexeToolStripMenuItem.Text = "Set path mysqldump.exe";
            this.setPathMysqldumpexeToolStripMenuItem.Click += new System.EventHandler(this.setPathMysqldumpexeToolStripMenuItem_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // chbExtendInsert
            // 
            this.chbExtendInsert.AutoSize = true;
            this.chbExtendInsert.Location = new System.Drawing.Point(216, 29);
            this.chbExtendInsert.Name = "chbExtendInsert";
            this.chbExtendInsert.Size = new System.Drawing.Size(128, 17);
            this.chbExtendInsert.TabIndex = 1;
            this.chbExtendInsert.Text = "--extended-insert=true";
            this.chbExtendInsert.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 599);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblDirFolder);
            this.Controls.Add(this.btnFindFolder);
            this.Controls.Add(this.tablesList);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MysqlDumps  by  LuFerLux";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbDatabaseName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetTables;
        private System.Windows.Forms.CheckedListBox tablesList;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.Button btnFindFolder;
        private System.Windows.Forms.Label lblDirFolder;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chbHexBlob;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setPathMysqldumpexeToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.CheckBox chbExtendInsert;
    }
}

