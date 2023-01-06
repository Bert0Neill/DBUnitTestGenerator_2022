namespace DBUnitTestGeneratorExt.EditorUI
{
    partial class DatabaseDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseDetails));
            this.txtConnectionString = new System.Windows.Forms.TextBox();
            this.grpBxDatabase = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.imgLstIcons = new System.Windows.Forms.ImageList(this.components);
            this.lblGeneralError = new System.Windows.Forms.Label();
            this.lblTestLanguage = new System.Windows.Forms.Label();
            this.cboTestLanguage = new System.Windows.Forms.ComboBox();
            this.cboTestFramework = new System.Windows.Forms.ComboBox();
            this.lblTestFramework = new System.Windows.Forms.Label();
            this.lblDBType = new System.Windows.Forms.Label();
            this.cboDatabaseType = new System.Windows.Forms.ComboBox();
            this.lblConnString = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.errorProviderForm = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpBxSQLScripts = new System.Windows.Forms.GroupBox();
            this.btnBrowseTestScript = new System.Windows.Forms.Button();
            this.btnBrowseProjectScript = new System.Windows.Forms.Button();
            this.txtBxTestSQLSetup = new System.Windows.Forms.TextBox();
            this.txtBxProjectSQLSetup = new System.Windows.Forms.TextBox();
            this.lblTestInitialise = new System.Windows.Forms.Label();
            this.lblProjectInitialise = new System.Windows.Forms.Label();
            this.ofdBrowseFiles = new System.Windows.Forms.OpenFileDialog();
            this.tlTipDetails = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBrowseTestTearDown = new System.Windows.Forms.Button();
            this.tbnBrowseProjectTearDown = new System.Windows.Forms.Button();
            this.txtBxTestSQLTearDown = new System.Windows.Forms.TextBox();
            this.txtBxProjectSQLTearDown = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.grpBxDatabase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderForm)).BeginInit();
            this.grpBxSQLScripts.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Location = new System.Drawing.Point(104, 24);
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Size = new System.Drawing.Size(413, 20);
            this.txtConnectionString.TabIndex = 0;
            this.txtConnectionString.Text = "Data Source=LHTU0CND7501B6S;Initial Catalog=P2;Integrated Security=True;MultipleA" +
    "ctiveResultSets=True";
            this.txtConnectionString.TextChanged += new System.EventHandler(this.txtConnectionString_TextChanged);
            this.txtConnectionString.Validating += new System.ComponentModel.CancelEventHandler(this.txtConnectionString_Validating);
            // 
            // grpBxDatabase
            // 
            this.grpBxDatabase.Controls.Add(this.textBox1);
            this.grpBxDatabase.Controls.Add(this.btnTestConnection);
            this.grpBxDatabase.Controls.Add(this.lblTestLanguage);
            this.grpBxDatabase.Controls.Add(this.cboTestLanguage);
            this.grpBxDatabase.Controls.Add(this.cboTestFramework);
            this.grpBxDatabase.Controls.Add(this.lblTestFramework);
            this.grpBxDatabase.Controls.Add(this.lblDBType);
            this.grpBxDatabase.Controls.Add(this.cboDatabaseType);
            this.grpBxDatabase.Controls.Add(this.lblConnString);
            this.grpBxDatabase.Controls.Add(this.txtConnectionString);
            this.grpBxDatabase.Location = new System.Drawing.Point(12, 16);
            this.grpBxDatabase.Name = "grpBxDatabase";
            this.grpBxDatabase.Size = new System.Drawing.Size(580, 143);
            this.grpBxDatabase.TabIndex = 1;
            this.grpBxDatabase.TabStop = false;
            this.grpBxDatabase.Text = "Database Details";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(297, 55);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(275, 73);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTestConnection.ImageIndex = 0;
            this.btnTestConnection.ImageList = this.imgLstIcons;
            this.btnTestConnection.Location = new System.Drawing.Point(523, 23);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(51, 23);
            this.btnTestConnection.TabIndex = 9;
            this.btnTestConnection.Text = "Test";
            this.btnTestConnection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTestConnection.UseVisualStyleBackColor = true;
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // imgLstIcons
            // 
            this.imgLstIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLstIcons.ImageStream")));
            this.imgLstIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLstIcons.Images.SetKeyName(0, "database-search-icon.png");
            this.imgLstIcons.Images.SetKeyName(1, "database-delete-icon.png");
            this.imgLstIcons.Images.SetKeyName(2, "Database-Download-Data-icon.png");
            this.imgLstIcons.Images.SetKeyName(3, "database-edit-icon.png");
            this.imgLstIcons.Images.SetKeyName(4, "database-error-icon.png");
            this.imgLstIcons.Images.SetKeyName(5, "database-gear-icon.png");
            this.imgLstIcons.Images.SetKeyName(6, "database-go-icon (1).png");
            this.imgLstIcons.Images.SetKeyName(7, "database-go-icon.png");
            this.imgLstIcons.Images.SetKeyName(8, "database-lightning-icon.png");
            this.imgLstIcons.Images.SetKeyName(9, "database-link-icon.png");
            this.imgLstIcons.Images.SetKeyName(10, "database-refresh-icon.png");
            this.imgLstIcons.Images.SetKeyName(11, "folder-search-icon (1).png");
            this.imgLstIcons.Images.SetKeyName(12, "database-next-icon.png");
            this.imgLstIcons.Images.SetKeyName(13, "database-previous-icon.png");
            this.imgLstIcons.Images.SetKeyName(14, "database-remove-icon.png");
            // 
            // lblGeneralError
            // 
            this.lblGeneralError.AutoSize = true;
            this.lblGeneralError.ForeColor = System.Drawing.Color.Red;
            this.lblGeneralError.Location = new System.Drawing.Point(19, 395);
            this.lblGeneralError.Name = "lblGeneralError";
            this.lblGeneralError.Size = new System.Drawing.Size(0, 13);
            this.lblGeneralError.TabIndex = 8;
            this.lblGeneralError.Visible = false;
            // 
            // lblTestLanguage
            // 
            this.lblTestLanguage.AutoSize = true;
            this.lblTestLanguage.Location = new System.Drawing.Point(7, 109);
            this.lblTestLanguage.Name = "lblTestLanguage";
            this.lblTestLanguage.Size = new System.Drawing.Size(79, 13);
            this.lblTestLanguage.TabIndex = 7;
            this.lblTestLanguage.Text = "Test Language";
            // 
            // cboTestLanguage
            // 
            this.cboTestLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTestLanguage.FormattingEnabled = true;
            this.cboTestLanguage.Items.AddRange(new object[] {
            "C#",
            "VB.Net"});
            this.cboTestLanguage.Location = new System.Drawing.Point(104, 107);
            this.cboTestLanguage.Name = "cboTestLanguage";
            this.cboTestLanguage.Size = new System.Drawing.Size(183, 21);
            this.cboTestLanguage.TabIndex = 6;
            this.cboTestLanguage.SelectedValueChanged += new System.EventHandler(this.cboTestLanguage_SelectedValueChanged);
            // 
            // cboTestFramework
            // 
            this.cboTestFramework.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTestFramework.FormattingEnabled = true;
            this.cboTestFramework.Items.AddRange(new object[] {
            "MS Test",
            "NUnit"});
            this.cboTestFramework.Location = new System.Drawing.Point(104, 79);
            this.cboTestFramework.Name = "cboTestFramework";
            this.cboTestFramework.Size = new System.Drawing.Size(183, 21);
            this.cboTestFramework.TabIndex = 5;
            this.cboTestFramework.SelectedValueChanged += new System.EventHandler(this.cboTestFramework_SelectedValueChanged);
            // 
            // lblTestFramework
            // 
            this.lblTestFramework.AutoSize = true;
            this.lblTestFramework.Location = new System.Drawing.Point(7, 82);
            this.lblTestFramework.Name = "lblTestFramework";
            this.lblTestFramework.Size = new System.Drawing.Size(83, 13);
            this.lblTestFramework.TabIndex = 4;
            this.lblTestFramework.Text = "Test Framework";
            // 
            // lblDBType
            // 
            this.lblDBType.AutoSize = true;
            this.lblDBType.Location = new System.Drawing.Point(7, 55);
            this.lblDBType.Name = "lblDBType";
            this.lblDBType.Size = new System.Drawing.Size(80, 13);
            this.lblDBType.TabIndex = 3;
            this.lblDBType.Text = "Database Type";
            // 
            // cboDatabaseType
            // 
            this.cboDatabaseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDatabaseType.FormattingEnabled = true;
            this.cboDatabaseType.Items.AddRange(new object[] {
            "SQL Server",
            "Oracle RDB",
            "Oracle 11g",
            "ODBC (System)"});
            this.cboDatabaseType.Location = new System.Drawing.Point(104, 51);
            this.cboDatabaseType.Name = "cboDatabaseType";
            this.cboDatabaseType.Size = new System.Drawing.Size(183, 21);
            this.cboDatabaseType.TabIndex = 2;
            this.cboDatabaseType.SelectedValueChanged += new System.EventHandler(this.cboDatabaseType_SelectedValueChanged);
            // 
            // lblConnString
            // 
            this.lblConnString.AutoSize = true;
            this.lblConnString.Location = new System.Drawing.Point(7, 27);
            this.lblConnString.Name = "lblConnString";
            this.lblConnString.Size = new System.Drawing.Size(91, 13);
            this.lblConnString.TabIndex = 1;
            this.lblConnString.Text = "Connection String";
            // 
            // btnClose
            // 
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.ImageKey = "database-remove-icon.png";
            this.btnClose.ImageList = this.imgLstIcons;
            this.btnClose.Location = new System.Drawing.Point(338, 390);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Enabled = false;
            this.btnConnect.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConnect.ImageKey = "database-next-icon.png";
            this.btnConnect.ImageList = this.imgLstIcons;
            this.btnConnect.Location = new System.Drawing.Point(508, 390);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(84, 23);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // errorProviderForm
            // 
            this.errorProviderForm.ContainerControl = this;
            // 
            // grpBxSQLScripts
            // 
            this.grpBxSQLScripts.Controls.Add(this.btnBrowseTestScript);
            this.grpBxSQLScripts.Controls.Add(this.btnBrowseProjectScript);
            this.grpBxSQLScripts.Controls.Add(this.txtBxTestSQLSetup);
            this.grpBxSQLScripts.Controls.Add(this.txtBxProjectSQLSetup);
            this.grpBxSQLScripts.Controls.Add(this.lblTestInitialise);
            this.grpBxSQLScripts.Controls.Add(this.lblProjectInitialise);
            this.grpBxSQLScripts.Location = new System.Drawing.Point(12, 169);
            this.grpBxSQLScripts.Name = "grpBxSQLScripts";
            this.grpBxSQLScripts.Size = new System.Drawing.Size(580, 100);
            this.grpBxSQLScripts.TabIndex = 7;
            this.grpBxSQLScripts.TabStop = false;
            this.grpBxSQLScripts.Text = "Setup SQL Scripts (optional)";
            // 
            // btnBrowseTestScript
            // 
            this.btnBrowseTestScript.ImageKey = "folder-search-icon (1).png";
            this.btnBrowseTestScript.ImageList = this.imgLstIcons;
            this.btnBrowseTestScript.Location = new System.Drawing.Point(542, 60);
            this.btnBrowseTestScript.Name = "btnBrowseTestScript";
            this.btnBrowseTestScript.Size = new System.Drawing.Size(30, 23);
            this.btnBrowseTestScript.TabIndex = 7;
            this.btnBrowseTestScript.UseVisualStyleBackColor = true;
            this.btnBrowseTestScript.Click += new System.EventHandler(this.btnBrowseTestScript_Click);
            // 
            // btnBrowseProjectScript
            // 
            this.btnBrowseProjectScript.ImageKey = "folder-search-icon (1).png";
            this.btnBrowseProjectScript.ImageList = this.imgLstIcons;
            this.btnBrowseProjectScript.Location = new System.Drawing.Point(542, 26);
            this.btnBrowseProjectScript.Name = "btnBrowseProjectScript";
            this.btnBrowseProjectScript.Size = new System.Drawing.Size(30, 23);
            this.btnBrowseProjectScript.TabIndex = 6;
            this.btnBrowseProjectScript.UseVisualStyleBackColor = true;
            this.btnBrowseProjectScript.Click += new System.EventHandler(this.btnBrowseProjectScript_Click);
            // 
            // txtBxTestSQLSetup
            // 
            this.txtBxTestSQLSetup.Location = new System.Drawing.Point(128, 62);
            this.txtBxTestSQLSetup.Name = "txtBxTestSQLSetup";
            this.txtBxTestSQLSetup.ReadOnly = true;
            this.txtBxTestSQLSetup.Size = new System.Drawing.Size(408, 20);
            this.txtBxTestSQLSetup.TabIndex = 5;
            // 
            // txtBxProjectSQLSetup
            // 
            this.txtBxProjectSQLSetup.Location = new System.Drawing.Point(128, 27);
            this.txtBxProjectSQLSetup.Name = "txtBxProjectSQLSetup";
            this.txtBxProjectSQLSetup.ReadOnly = true;
            this.txtBxProjectSQLSetup.Size = new System.Drawing.Size(408, 20);
            this.txtBxProjectSQLSetup.TabIndex = 4;
            // 
            // lblTestInitialise
            // 
            this.lblTestInitialise.AutoSize = true;
            this.lblTestInitialise.Location = new System.Drawing.Point(7, 65);
            this.lblTestInitialise.Name = "lblTestInitialise";
            this.lblTestInitialise.Size = new System.Drawing.Size(110, 13);
            this.lblTestInitialise.TabIndex = 3;
            this.lblTestInitialise.Text = "Each Test SQL Script";
            // 
            // lblProjectInitialise
            // 
            this.lblProjectInitialise.AutoSize = true;
            this.lblProjectInitialise.Location = new System.Drawing.Point(7, 30);
            this.lblProjectInitialise.Name = "lblProjectInitialise";
            this.lblProjectInitialise.Size = new System.Drawing.Size(94, 13);
            this.lblProjectInitialise.TabIndex = 2;
            this.lblProjectInitialise.Text = "Project SQL Script";
            // 
            // ofdBrowseFiles
            // 
            this.ofdBrowseFiles.DefaultExt = "sql";
            this.ofdBrowseFiles.FileName = "openFileDialog1";
            this.ofdBrowseFiles.Filter = "sql files (*.sql)|*.sql;";
            this.ofdBrowseFiles.InitialDirectory = "C:\\";
            this.ofdBrowseFiles.RestoreDirectory = true;
            this.ofdBrowseFiles.Title = "Browse SQL Scripts";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBrowseTestTearDown);
            this.groupBox1.Controls.Add(this.tbnBrowseProjectTearDown);
            this.groupBox1.Controls.Add(this.txtBxTestSQLTearDown);
            this.groupBox1.Controls.Add(this.txtBxProjectSQLTearDown);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 284);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tear Down SQL Scripts (optional)";
            // 
            // btnBrowseTestTearDown
            // 
            this.btnBrowseTestTearDown.ImageKey = "folder-search-icon (1).png";
            this.btnBrowseTestTearDown.ImageList = this.imgLstIcons;
            this.btnBrowseTestTearDown.Location = new System.Drawing.Point(542, 60);
            this.btnBrowseTestTearDown.Name = "btnBrowseTestTearDown";
            this.btnBrowseTestTearDown.Size = new System.Drawing.Size(30, 23);
            this.btnBrowseTestTearDown.TabIndex = 7;
            this.btnBrowseTestTearDown.UseVisualStyleBackColor = true;
            this.btnBrowseTestTearDown.Click += new System.EventHandler(this.btnBrowseTestTearDown_Click);
            // 
            // tbnBrowseProjectTearDown
            // 
            this.tbnBrowseProjectTearDown.ImageKey = "folder-search-icon (1).png";
            this.tbnBrowseProjectTearDown.ImageList = this.imgLstIcons;
            this.tbnBrowseProjectTearDown.Location = new System.Drawing.Point(542, 26);
            this.tbnBrowseProjectTearDown.Name = "tbnBrowseProjectTearDown";
            this.tbnBrowseProjectTearDown.Size = new System.Drawing.Size(30, 23);
            this.tbnBrowseProjectTearDown.TabIndex = 6;
            this.tbnBrowseProjectTearDown.UseVisualStyleBackColor = true;
            this.tbnBrowseProjectTearDown.Click += new System.EventHandler(this.tbnBrowseProjectTearDown_Click);
            // 
            // txtBxTestSQLTearDown
            // 
            this.txtBxTestSQLTearDown.Location = new System.Drawing.Point(128, 62);
            this.txtBxTestSQLTearDown.Name = "txtBxTestSQLTearDown";
            this.txtBxTestSQLTearDown.ReadOnly = true;
            this.txtBxTestSQLTearDown.Size = new System.Drawing.Size(408, 20);
            this.txtBxTestSQLTearDown.TabIndex = 5;
            // 
            // txtBxProjectSQLTearDown
            // 
            this.txtBxProjectSQLTearDown.Location = new System.Drawing.Point(128, 27);
            this.txtBxProjectSQLTearDown.Name = "txtBxProjectSQLTearDown";
            this.txtBxProjectSQLTearDown.ReadOnly = true;
            this.txtBxProjectSQLTearDown.Size = new System.Drawing.Size(408, 20);
            this.txtBxProjectSQLTearDown.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Each Test SQL Script";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Project SQL Script";
            // 
            // btnLoad
            // 
            this.btnLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoad.ImageIndex = 0;
            this.btnLoad.ImageList = this.imgLstIcons;
            this.btnLoad.Location = new System.Drawing.Point(423, 390);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(79, 23);
            this.btnLoad.TabIndex = 9;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // DatabaseDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 423);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblGeneralError);
            this.Controls.Add(this.grpBxSQLScripts);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grpBxDatabase);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DatabaseDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Details";
            this.Load += new System.EventHandler(this.DatabaseDetails_Load);
            this.grpBxDatabase.ResumeLayout(false);
            this.grpBxDatabase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderForm)).EndInit();
            this.grpBxSQLScripts.ResumeLayout(false);
            this.grpBxSQLScripts.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConnectionString;
        private System.Windows.Forms.GroupBox grpBxDatabase;
        private System.Windows.Forms.Label lblConnString;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblDBType;
        private System.Windows.Forms.ComboBox cboDatabaseType;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblTestLanguage;
        private System.Windows.Forms.ComboBox cboTestLanguage;
        private System.Windows.Forms.ComboBox cboTestFramework;
        private System.Windows.Forms.Label lblTestFramework;
        private System.Windows.Forms.ErrorProvider errorProviderForm;
        private System.Windows.Forms.Label lblGeneralError;
        private System.Windows.Forms.GroupBox grpBxSQLScripts;
        private System.Windows.Forms.Button btnBrowseTestScript;
        private System.Windows.Forms.Button btnBrowseProjectScript;
        private System.Windows.Forms.TextBox txtBxTestSQLSetup;
        private System.Windows.Forms.TextBox txtBxProjectSQLSetup;
        private System.Windows.Forms.Label lblTestInitialise;
        private System.Windows.Forms.Label lblProjectInitialise;
        private System.Windows.Forms.OpenFileDialog ofdBrowseFiles;
        private System.Windows.Forms.Button btnTestConnection;
        private System.Windows.Forms.ImageList imgLstIcons;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolTip tlTipDetails;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBrowseTestTearDown;
        private System.Windows.Forms.Button tbnBrowseProjectTearDown;
        private System.Windows.Forms.TextBox txtBxTestSQLTearDown;
        private System.Windows.Forms.TextBox txtBxProjectSQLTearDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLoad;
    }
}