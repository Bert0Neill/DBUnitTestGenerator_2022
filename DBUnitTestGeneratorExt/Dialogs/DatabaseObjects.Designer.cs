namespace DBUnitTestGeneratorExt.EditorUI
{
    partial class DatabaseObjects
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseObjects));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkToggleAllFnxs = new System.Windows.Forms.CheckBox();
            this.chkLstFnxs = new System.Windows.Forms.CheckedListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkToggleAllViews = new System.Windows.Forms.CheckBox();
            this.chkLstViews = new System.Windows.Forms.CheckedListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkToggleAllProcedures = new System.Windows.Forms.CheckBox();
            this.chkLstProcedures = new System.Windows.Forms.CheckedListBox();
            this.btnDBObjBack = new System.Windows.Forms.Button();
            this.imgLstDbObjs = new System.Windows.Forms.ImageList(this.components);
            this.btnDBObjGenerateTests = new System.Windows.Forms.Button();
            this.lblObjectsInfo = new System.Windows.Forms.Label();
            this.btnDBObjClose = new System.Windows.Forms.Button();
            this.chkBxComputedFields = new System.Windows.Forms.CheckBox();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkToggleAllFnxs);
            this.groupBox4.Controls.Add(this.chkLstFnxs);
            this.groupBox4.Location = new System.Drawing.Point(12, 371);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(580, 156);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Custom Functions";
            // 
            // chkToggleAllFnxs
            // 
            this.chkToggleAllFnxs.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkToggleAllFnxs.AutoSize = true;
            this.chkToggleAllFnxs.Location = new System.Drawing.Point(6, 1);
            this.chkToggleAllFnxs.Name = "chkToggleAllFnxs";
            this.chkToggleAllFnxs.Size = new System.Drawing.Size(106, 23);
            this.chkToggleAllFnxs.TabIndex = 5;
            this.chkToggleAllFnxs.Text = "Select all functions";
            this.chkToggleAllFnxs.UseVisualStyleBackColor = true;
            this.chkToggleAllFnxs.CheckedChanged += new System.EventHandler(this.chkToggleAllFnxs_CheckedChanged);
            // 
            // chkLstFnxs
            // 
            this.chkLstFnxs.CheckOnClick = true;
            this.chkLstFnxs.FormattingEnabled = true;
            this.chkLstFnxs.Location = new System.Drawing.Point(6, 34);
            this.chkLstFnxs.Name = "chkLstFnxs";
            this.chkLstFnxs.Size = new System.Drawing.Size(568, 109);
            this.chkLstFnxs.TabIndex = 2;
            this.chkLstFnxs.MouseUp += new System.Windows.Forms.MouseEventHandler(this.chkLstFnxs_MouseUp);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkToggleAllViews);
            this.groupBox3.Controls.Add(this.chkLstViews);
            this.groupBox3.Location = new System.Drawing.Point(12, 207);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(580, 151);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Views";
            // 
            // chkToggleAllViews
            // 
            this.chkToggleAllViews.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkToggleAllViews.AutoSize = true;
            this.chkToggleAllViews.Location = new System.Drawing.Point(6, 1);
            this.chkToggleAllViews.Name = "chkToggleAllViews";
            this.chkToggleAllViews.Size = new System.Drawing.Size(90, 23);
            this.chkToggleAllViews.TabIndex = 4;
            this.chkToggleAllViews.Text = "Select all views";
            this.chkToggleAllViews.UseVisualStyleBackColor = true;
            this.chkToggleAllViews.CheckedChanged += new System.EventHandler(this.chkToggleAllViews_CheckedChanged);
            // 
            // chkLstViews
            // 
            this.chkLstViews.CheckOnClick = true;
            this.chkLstViews.FormattingEnabled = true;
            this.chkLstViews.Location = new System.Drawing.Point(6, 33);
            this.chkLstViews.Name = "chkLstViews";
            this.chkLstViews.Size = new System.Drawing.Size(568, 109);
            this.chkLstViews.TabIndex = 2;
            this.chkLstViews.MouseUp += new System.Windows.Forms.MouseEventHandler(this.chkLstViews_MouseUp);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkToggleAllProcedures);
            this.groupBox2.Controls.Add(this.chkLstProcedures);
            this.groupBox2.Location = new System.Drawing.Point(12, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(580, 157);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stored procedures";
            // 
            // chkToggleAllProcedures
            // 
            this.chkToggleAllProcedures.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkToggleAllProcedures.AutoSize = true;
            this.chkToggleAllProcedures.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkToggleAllProcedures.ImageIndex = 4;
            this.chkToggleAllProcedures.Location = new System.Drawing.Point(6, 1);
            this.chkToggleAllProcedures.Name = "chkToggleAllProcedures";
            this.chkToggleAllProcedures.Size = new System.Drawing.Size(116, 23);
            this.chkToggleAllProcedures.TabIndex = 3;
            this.chkToggleAllProcedures.Text = "Select all procedures";
            this.chkToggleAllProcedures.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkToggleAllProcedures.UseVisualStyleBackColor = true;
            this.chkToggleAllProcedures.CheckedChanged += new System.EventHandler(this.chkToggleAllProcedures_CheckedChanged);
            // 
            // chkLstProcedures
            // 
            this.chkLstProcedures.CheckOnClick = true;
            this.chkLstProcedures.FormattingEnabled = true;
            this.chkLstProcedures.Location = new System.Drawing.Point(6, 37);
            this.chkLstProcedures.Name = "chkLstProcedures";
            this.chkLstProcedures.Size = new System.Drawing.Size(568, 109);
            this.chkLstProcedures.TabIndex = 2;
            this.chkLstProcedures.MouseUp += new System.Windows.Forms.MouseEventHandler(this.chkLstProcedures_MouseUp);
            // 
            // btnDBObjBack
            // 
            this.btnDBObjBack.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDBObjBack.ImageIndex = 1;
            this.btnDBObjBack.ImageList = this.imgLstDbObjs;
            this.btnDBObjBack.Location = new System.Drawing.Point(368, 567);
            this.btnDBObjBack.Name = "btnDBObjBack";
            this.btnDBObjBack.Size = new System.Drawing.Size(75, 23);
            this.btnDBObjBack.TabIndex = 9;
            this.btnDBObjBack.Text = "Back";
            this.btnDBObjBack.UseVisualStyleBackColor = true;
            this.btnDBObjBack.Click += new System.EventHandler(this.btnDBObjBack_Click);
            // 
            // imgLstDbObjs
            // 
            this.imgLstDbObjs.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLstDbObjs.ImageStream")));
            this.imgLstDbObjs.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLstDbObjs.Images.SetKeyName(0, "database-next-icon.png");
            this.imgLstDbObjs.Images.SetKeyName(1, "database-previous-icon.png");
            this.imgLstDbObjs.Images.SetKeyName(2, "database-process-icon.png");
            this.imgLstDbObjs.Images.SetKeyName(3, "database-remove-icon.png");
            this.imgLstDbObjs.Images.SetKeyName(4, "User-Interface-Checked-Checkbox-icon.png");
            // 
            // btnDBObjGenerateTests
            // 
            this.btnDBObjGenerateTests.Enabled = false;
            this.btnDBObjGenerateTests.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDBObjGenerateTests.ImageIndex = 2;
            this.btnDBObjGenerateTests.ImageList = this.imgLstDbObjs;
            this.btnDBObjGenerateTests.Location = new System.Drawing.Point(449, 568);
            this.btnDBObjGenerateTests.Name = "btnDBObjGenerateTests";
            this.btnDBObjGenerateTests.Size = new System.Drawing.Size(140, 23);
            this.btnDBObjGenerateTests.TabIndex = 10;
            this.btnDBObjGenerateTests.Text = "Generate Unit Tests";
            this.btnDBObjGenerateTests.UseVisualStyleBackColor = true;
            this.btnDBObjGenerateTests.Click += new System.EventHandler(this.btnDBObjGenerateTests_Click);
            // 
            // lblObjectsInfo
            // 
            this.lblObjectsInfo.AutoSize = true;
            this.lblObjectsInfo.Location = new System.Drawing.Point(15, 9);
            this.lblObjectsInfo.Name = "lblObjectsInfo";
            this.lblObjectsInfo.Size = new System.Drawing.Size(537, 13);
            this.lblObjectsInfo.TabIndex = 11;
            this.lblObjectsInfo.Text = "Select the objects that you would like Unit tests generated for, and then clickon" +
    " the \'Generate Unit Tests\' button:";
            // 
            // btnDBObjClose
            // 
            this.btnDBObjClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDBObjClose.ImageKey = "database-remove-icon.png";
            this.btnDBObjClose.ImageList = this.imgLstDbObjs;
            this.btnDBObjClose.Location = new System.Drawing.Point(287, 567);
            this.btnDBObjClose.Name = "btnDBObjClose";
            this.btnDBObjClose.Size = new System.Drawing.Size(75, 23);
            this.btnDBObjClose.TabIndex = 12;
            this.btnDBObjClose.Text = "Close";
            this.btnDBObjClose.UseVisualStyleBackColor = true;
            this.btnDBObjClose.Click += new System.EventHandler(this.btnDBObjClose_Click);
            // 
            // chkBxComputedFields
            // 
            this.chkBxComputedFields.AutoSize = true;
            this.chkBxComputedFields.Location = new System.Drawing.Point(14, 541);
            this.chkBxComputedFields.Name = "chkBxComputedFields";
            this.chkBxComputedFields.Size = new System.Drawing.Size(286, 17);
            this.chkBxComputedFields.TabIndex = 13;
            this.chkBxComputedFields.Text = "Generate unit tests for \'Computed\' fields within all tables";
            this.chkBxComputedFields.UseVisualStyleBackColor = true;
            this.chkBxComputedFields.CheckedChanged += new System.EventHandler(this.chkBxComputedFields_CheckedChanged);
            // 
            // DatabaseObjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 607);
            this.Controls.Add(this.chkBxComputedFields);
            this.Controls.Add(this.btnDBObjClose);
            this.Controls.Add(this.lblObjectsInfo);
            this.Controls.Add(this.btnDBObjGenerateTests);
            this.Controls.Add(this.btnDBObjBack);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DatabaseObjects";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Objects";
            this.Load += new System.EventHandler(this.DatabaseObjects_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckedListBox chkLstFnxs;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckedListBox chkLstViews;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckedListBox chkLstProcedures;
        private System.Windows.Forms.Button btnDBObjBack;
        private System.Windows.Forms.Button btnDBObjGenerateTests;
        private System.Windows.Forms.Label lblObjectsInfo;
        private System.Windows.Forms.Button btnDBObjClose;
        private System.Windows.Forms.CheckBox chkToggleAllProcedures;
        private System.Windows.Forms.CheckBox chkToggleAllViews;
        private System.Windows.Forms.CheckBox chkToggleAllFnxs;
        private System.Windows.Forms.CheckBox chkBxComputedFields;
        private System.Windows.Forms.ImageList imgLstDbObjs;
    }
}