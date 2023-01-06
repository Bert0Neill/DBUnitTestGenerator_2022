using DBUnitTestGeneratorExt.Models;
using DBUnitTestGeneratorExt.Services;
using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace DBUnitTestGeneratorExt.EditorUI
{
    public partial class DatabaseDetails : Form
    {
        #region Private Variables
        protected IProjectProperties projectProperties;
     //protected ILog log = LogManager.GetLogger(typeof(DatabaseDetails));

        private readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(DatabaseDetails));
        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //static log4net.ILog log;

        private IHelperMethods helperMethods = null;
        #endregion

        #region Constructors

        public DatabaseDetails()
        {
            try
            {
                InitializeComponent();

                log.Info("ctor DatabaseDetails");
                helperMethods = new HelperMethods();                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.Error(ex);
            }
        }

        public DatabaseDetails(IProjectProperties projectProperties) : this()
        {
            try
            {
                this.projectProperties = projectProperties;
                log.Info("ctor DatabaseDetails : this");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.Error(ex);
            }
        }

        #endregion

        #region Form Events

        private void DatabaseDetails_Load(object sender, EventArgs e)
        {
            try
            {
                // defaults for demo purposes, until more functionality has been added
                this.cboDatabaseType.SelectedIndex = 0; // SQL Server
                this.cboTestFramework.SelectedIndex = 0; //MS test
                this.cboTestLanguage.SelectedIndex = 0; //C#

                this.IsFormValid();

                this.AcceptButton = this.btnConnect; // on Enter key, call the connect button

                log.Info("DatabaseDetails_Load");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.Error(ex);
            }
        }

        #endregion

        #region Control\Page Events

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.Error(ex);
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                this.errorProviderForm.SetError(this.txtConnectionString, ""); // clear any previous error message

                if (!TestConnectionString())
                {
                    this.lblGeneralError.Visible = true;
                    this.errorProviderForm.SetError(this.txtConnectionString, "Connection failed");

                    MessageBox.Show("Connection Failed", "No Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                this.projectProperties.DBConnectionString = this.txtConnectionString.Text;

                this.projectProperties.UnitTestLanguage = cboTestLanguage.SelectedItem.ToString(); //ProjectProperties.EnumUnitTestLanguage.CSharp;
                this.projectProperties.UnitTestType = cboTestFramework.SelectedItem.ToString();//ProjectProperties.EnumUnitTestType.MSTest;
                this.projectProperties.DatabaseType = cboDatabaseType.SelectedItem.ToString();//ProjectProperties.EnumUnitTestType.MSTest;

                // load SQL scripts from file and keep in memory
                if (this.txtBxProjectSQLSetup.Text.Trim() != string.Empty) this.projectProperties.ProjectSetupScriptSQL = System.IO.File.ReadAllText(this.txtBxProjectSQLSetup.Text);
                if (this.txtBxTestSQLSetup.Text.Trim() != string.Empty) this.projectProperties.TestSetupScriptSQL = System.IO.File.ReadAllText(this.txtBxTestSQLSetup.Text);
                if (this.txtBxProjectSQLTearDown.Text.Trim() != string.Empty) this.projectProperties.ProjectTearDownScriptSQL = System.IO.File.ReadAllText(this.txtBxProjectSQLTearDown.Text);
                if (this.txtBxTestSQLTearDown.Text.Trim() != string.Empty) this.projectProperties.TestTearDownScriptSQL = System.IO.File.ReadAllText(this.txtBxTestSQLTearDown.Text);
         
                this.Hide();
                
                DatabaseObjects dbObjs = new DatabaseObjects(this, this.projectProperties);
                dbObjs.ShowDialog();
            }
            catch (Exception ex)
            {
                this.lblGeneralError.Visible = true;
                this.errorProviderForm.SetError(this.lblGeneralError, ex.Message);                
                log.Error(ex);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void txtConnectionString_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.IsFormValid();
            }
            catch (Exception ex)
            {
                this.lblGeneralError.Visible = true;
                this.errorProviderForm.SetError(this.lblGeneralError, ex.Message);                
                log.Error(ex);
            }
        }

        private void cboDatabaseType_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.IsFormValid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.Error(ex);
            }
        }

        private void cboTestLanguage_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.IsFormValid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.Error(ex);
            }
        }

        private void cboTestFramework_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.IsFormValid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.Error(ex);
            }
        }

        private void txtConnectionString_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                this.IsFormValid();
            }
            catch (Exception ex)
            {
                this.errorProviderForm.SetError(this.txtConnectionString, ex.Message);                
                log.Error(ex);
            }
        }

        private void btnBrowseTestScript_Click(object sender, EventArgs e)
        {
            try { 
            this.ofdBrowseFiles.FileName = string.Empty;
                this.ofdBrowseFiles.Filter = "sql files (*.sql)|*.sql;";

                if (ofdBrowseFiles.ShowDialog() == DialogResult.OK)
            {
                if (this.ofdBrowseFiles.FileName.Trim() == string.Empty) MessageBox.Show("No Test SQL script selected", "No Script", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtBxTestSQLSetup.Text = this.ofdBrowseFiles.FileName;
            }
            }
            catch (SqlException ex)
            {
                string error = helperMethods.BuildExeptionSQL(ex);
                Console.WriteLine(error);
                MessageBox.Show("Not able to browse scripts. \nError message - " + error, "Browse Scripts", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                this.errorProviderForm.SetError(this.txtConnectionString, ""); // clear any previous error message

                if (TestConnectionString())
                {
                    MessageBox.Show("Connection Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    this.errorProviderForm.SetError(this.txtConnectionString, "Connection failed");
                    MessageBox.Show("Connection Failed", "No Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                string error = helperMethods.BuildExeptionSQL(ex);
                Console.WriteLine(error);            
                MessageBox.Show("Not able to connection to database. \nError message - " + error, "Not Connected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnBrowseProjectScript_Click(object sender, EventArgs e)
        {
            try
            {
                this.ofdBrowseFiles.FileName = string.Empty;
                this.ofdBrowseFiles.Filter = "sql files (*.sql)|*.sql;";

                if (ofdBrowseFiles.ShowDialog() == DialogResult.OK)
                {
                    if (this.ofdBrowseFiles.FileName.Trim() == string.Empty) MessageBox.Show("No Test SQL script selected", "No Script", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtBxProjectSQLSetup.Text = this.ofdBrowseFiles.FileName;
                }
            }
            catch (SqlException ex)
            {
                string error = helperMethods.BuildExeptionSQL(ex);
                Console.WriteLine(error);
                MessageBox.Show("Not able to browse scripts. \nError message - " + error, "Browse Scripts", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                this.ofdBrowseFiles.FileName = string.Empty;
                this.ofdBrowseFiles.Filter = "db unit test files (*.dbut)|*.dbut;";

                if (ofdBrowseFiles.ShowDialog() == DialogResult.OK)
                {
                    if (this.ofdBrowseFiles.FileName.Trim() == string.Empty)
                    {
                        MessageBox.Show("No 'Auto Generated Test' project file selected", "No file", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // read file into variable (xmlProj)
                    string xmlProj = System.IO.File.ReadAllText(this.ofdBrowseFiles.FileName.Trim());
                    XmlSerializer xmlSer = new XmlSerializer(typeof(ProjectProperties));
                    this.projectProperties = (ProjectProperties)xmlSer.Deserialize(new StringReader(xmlProj));

                    // populate dialog controls
                    this.cboDatabaseType.SelectedItem = this.projectProperties.DatabaseType;
                    this.cboTestFramework.SelectedItem = this.projectProperties.UnitTestType;
                    this.cboTestLanguage.SelectedItem = this.projectProperties.UnitTestLanguage;
                    this.txtConnectionString.Text = this.projectProperties.DBConnectionString;

                    //sql scripts
                    this.txtBxProjectSQLSetup.Text = this.projectProperties.ProjectSetupScriptSQL;
                    this.txtBxTestSQLSetup.Text = this.projectProperties.TestSetupScriptSQL;
                    this.txtBxProjectSQLTearDown.Text = this.projectProperties.ProjectTearDownScriptSQL;
                    this.txtBxTestSQLTearDown.Text = this.projectProperties.TestTearDownScriptSQL;
                }
            }
            catch (SqlException ex)
            {
                string error = helperMethods.BuildExeptionSQL(ex);
                Console.WriteLine(error);
                MessageBox.Show("Not able to browse scripts. \nError message - " + error, "Browse Scripts", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbnBrowseProjectTearDown_Click(object sender, EventArgs e)
        {
            try
            {
                this.ofdBrowseFiles.FileName = string.Empty;
                this.ofdBrowseFiles.Filter = "sql files (*.sql)|*.sql;";

                if (ofdBrowseFiles.ShowDialog() == DialogResult.OK)
                {
                    if (this.ofdBrowseFiles.FileName.Trim() == string.Empty) MessageBox.Show("No Test SQL script selected", "No Script", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtBxProjectSQLTearDown.Text = this.ofdBrowseFiles.FileName;
                }
            }
            catch (SqlException ex)
            {
                string error = helperMethods.BuildExeptionSQL(ex);
                Console.WriteLine(error);
                MessageBox.Show("Not able to browse scripts. \nError message - " + error, "Browse Scripts", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBrowseTestTearDown_Click(object sender, EventArgs e)
        {
            try
            {
                this.ofdBrowseFiles.FileName = string.Empty;
                this.ofdBrowseFiles.Filter = "sql files (*.sql)|*.sql;";

                if (ofdBrowseFiles.ShowDialog() == DialogResult.OK)
                {
                    if (this.ofdBrowseFiles.FileName.Trim() == string.Empty) MessageBox.Show("No Test SQL script selected", "No Script", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtBxTestSQLTearDown.Text = this.ofdBrowseFiles.FileName;
                }
            }
            catch (SqlException ex)
            {
                string error = helperMethods.BuildExeptionSQL(ex);
                Console.WriteLine(error);
                MessageBox.Show("Not able to browse scripts. \nError message - " + error, "Browse Scripts", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Utility methods
        private bool TestConnectionString()
        {
            try
            {
                SqlConnection conn = new SqlConnection(this.txtConnectionString.Text);
                conn.Open();
                conn.Close();

                return true;
            }
            catch (SqlException ex)
            {
                string error = helperMethods.BuildExeptionSQL(ex);
                Console.WriteLine(error);
                return false;
            }
        }

        private bool IsFormValid()
        {
            try
            {
                log.Info("IsFormValid");

                bool isValid = true;

                this.lblGeneralError.Visible = false; // reset general error message
                this.lblGeneralError.Text = String.Empty;

                // validate entry controls
                if (
                    string.IsNullOrEmpty(this.txtConnectionString.Text) ||
                    string.IsNullOrEmpty(cboDatabaseType.Text) ||
                    string.IsNullOrEmpty(cboTestFramework.Text) ||
                    string.IsNullOrEmpty(cboTestLanguage.Text))
                    isValid = false;

                btnConnect.Enabled = isValid; // enable or disable the Connect button

                return isValid;
            }
            catch (Exception ex)
            {
                this.lblGeneralError.Visible = true;
                this.errorProviderForm.SetError(this.lblGeneralError, ex.Message);
                log.Error(ex);
                return false;
            }
        }
        #endregion
    }
}
