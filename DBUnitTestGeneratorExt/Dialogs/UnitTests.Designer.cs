namespace DBUnitTestGeneratorExt.EditorUI
{
    partial class UnitTests
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnitTests));
            this.btnTestsBack = new System.Windows.Forms.Button();
            this.imgLstGenUnitTests = new System.Windows.Forms.ImageList(this.components);
            this.btnTestsClose = new System.Windows.Forms.Button();
            this.btnTestsClipboard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TextPanel = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTestsBack
            // 
            this.btnTestsBack.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTestsBack.ImageKey = "database-previous-icon.png";
            this.btnTestsBack.ImageList = this.imgLstGenUnitTests;
            this.btnTestsBack.Location = new System.Drawing.Point(543, 516);
            this.btnTestsBack.Name = "btnTestsBack";
            this.btnTestsBack.Size = new System.Drawing.Size(75, 23);
            this.btnTestsBack.TabIndex = 1;
            this.btnTestsBack.Text = "Back";
            this.btnTestsBack.UseVisualStyleBackColor = true;
            this.btnTestsBack.Click += new System.EventHandler(this.btnTestsBack_Click);
            // 
            // imgLstGenUnitTests
            // 
            this.imgLstGenUnitTests.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLstGenUnitTests.ImageStream")));
            this.imgLstGenUnitTests.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLstGenUnitTests.Images.SetKeyName(0, "database-next-icon.png");
            this.imgLstGenUnitTests.Images.SetKeyName(1, "database-previous-icon.png");
            this.imgLstGenUnitTests.Images.SetKeyName(2, "database-process-icon.png");
            this.imgLstGenUnitTests.Images.SetKeyName(3, "database-refresh-icon.png");
            this.imgLstGenUnitTests.Images.SetKeyName(4, "database-remove-icon.png");
            this.imgLstGenUnitTests.Images.SetKeyName(5, "database-save-icon.png");
            this.imgLstGenUnitTests.Images.SetKeyName(6, "database-search-icon.png");
            this.imgLstGenUnitTests.Images.SetKeyName(7, "database-pencil-icon.png");
            this.imgLstGenUnitTests.Images.SetKeyName(8, "database-sql-icon.png");
            this.imgLstGenUnitTests.Images.SetKeyName(9, "clipboard-icon.png");
            this.imgLstGenUnitTests.Images.SetKeyName(10, "Clipboard-Paste-icon.png");
            this.imgLstGenUnitTests.Images.SetKeyName(11, "page-copy-icon.png");
            // 
            // btnTestsClose
            // 
            this.btnTestsClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTestsClose.ImageIndex = 4;
            this.btnTestsClose.ImageList = this.imgLstGenUnitTests;
            this.btnTestsClose.Location = new System.Drawing.Point(462, 516);
            this.btnTestsClose.Name = "btnTestsClose";
            this.btnTestsClose.Size = new System.Drawing.Size(75, 23);
            this.btnTestsClose.TabIndex = 2;
            this.btnTestsClose.Text = "Close";
            this.btnTestsClose.UseVisualStyleBackColor = true;
            this.btnTestsClose.Click += new System.EventHandler(this.btnTestsClose_Click);
            // 
            // btnTestsClipboard
            // 
            this.btnTestsClipboard.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTestsClipboard.ImageIndex = 9;
            this.btnTestsClipboard.ImageList = this.imgLstGenUnitTests;
            this.btnTestsClipboard.Location = new System.Drawing.Point(705, 516);
            this.btnTestsClipboard.Name = "btnTestsClipboard";
            this.btnTestsClipboard.Size = new System.Drawing.Size(135, 23);
            this.btnTestsClipboard.TabIndex = 3;
            this.btnTestsClipboard.Text = "Copy to Clipboard";
            this.btnTestsClipboard.UseVisualStyleBackColor = true;
            this.btnTestsClipboard.Click += new System.EventHandler(this.btnTestsClipboard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Copy the unit tests below to your test classes:";
            // 
            // TextPanel
            // 
            this.TextPanel.AutoSize = true;
            this.TextPanel.Location = new System.Drawing.Point(16, 29);
            this.TextPanel.Name = "TextPanel";
            this.TextPanel.Size = new System.Drawing.Size(824, 481);
            this.TextPanel.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.ImageIndex = 5;
            this.btnSave.ImageList = this.imgLstGenUnitTests;
            this.btnSave.Location = new System.Drawing.Point(624, 516);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // UnitTests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 551);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.TextPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTestsClipboard);
            this.Controls.Add(this.btnTestsClose);
            this.Controls.Add(this.btnTestsBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UnitTests";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generated Unit Tests";
            this.Load += new System.EventHandler(this.UnitTests_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTestsBack;
        private System.Windows.Forms.Button btnTestsClose;
        private System.Windows.Forms.Button btnTestsClipboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imgLstGenUnitTests;
        private System.Windows.Forms.Panel TextPanel;
        private System.Windows.Forms.Button btnSave;
    }
}