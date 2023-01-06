using DBUnitTestGeneratorExt.Models;
using DBUnitTestGeneratorExt.Resources;
using log4net;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace DBUnitTestGeneratorExt.EditorUI
{
    public partial class DatabaseObjects : Form
    {
        #region Private Variables
        private IProjectProperties projectProperties;
        private DatabaseDetails backForm;
        protected ILog log = LogManager.GetLogger(typeof(DatabaseObjects));
        #endregion

        #region Constructors

        public DatabaseObjects(DatabaseDetails backForm, IProjectProperties projectProperties) : this()
        {
            try
            {
                this.backForm = backForm;
                this.backForm.Hide();
                this.projectProperties = projectProperties;

                log.Info("ctor DatabaseObjects : this");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.Error(ex);
            }
        }

        public DatabaseObjects()
        {
            try
            {
                InitializeComponent();
                log.Info("ctor DatabaseObjects");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.Error(ex);
            }
        }

        #endregion

        #region Form Events
        private void DatabaseObjects_Load(object sender, EventArgs e)
        {
            try
            {
                this.AcceptButton = this.btnDBObjGenerateTests; // on Enter key, call the connect button

                DataSet dsDatabaseObjects = new DataSet("Schema");

                using (SqlConnection conn = new SqlConnection(this.projectProperties.DBConnectionString))
                {
                    if (conn.State != ConnectionState.Open) conn.Open(); // open connection to DB

                    // retrieve database objects
                    using (SqlDataAdapter daSchema = new SqlDataAdapter(SQLStatements.RetrieveDatabaseObjets, conn))
                    {
                        daSchema.Fill(dsDatabaseObjects, "Schema");
                    }

                    // bind to list controls
                    foreach (DataRow drCurrent in dsDatabaseObjects.Tables[0].Rows)
                    {
                        if (drCurrent["ObjectType"].ToString().ToLower() == "procedure")
                        {
                            this.chkLstProcedures.Items.Add("[" + drCurrent["ObjectSchema"].ToString() + "].[" + drCurrent["ObjectName"].ToString() + "]");
                        }
                        else if (drCurrent["ObjectType"].ToString().ToLower() == "function")
                        {
                            this.chkLstFnxs.Items.Add("[" + drCurrent["ObjectSchema"].ToString() + "].[" + drCurrent["ObjectName"].ToString() + "]");
                        }
                        else if (drCurrent["ObjectType"].ToString().ToLower() == "view")
                        {
                            this.chkLstViews.Items.Add("[" + drCurrent["ObjectSchema"].ToString() + "].[" + drCurrent["ObjectName"].ToString() + "]");
                        }
                        else if (drCurrent["ObjectType"].ToString().ToLower() == "trigger")
                        {
                            //this.chkLstTriggers.Items.Add("["+ drCurrent["ObjectSchema"].ToString() + "].[" + drCurrent["ObjectName"].ToString()+ "]");
                        }

                        Debug.WriteLine("{0} {1} {2}", drCurrent["ObjectName"].ToString(), drCurrent["ObjectSchema"].ToString(), drCurrent["ObjectType"].ToString());
                    }
                }

                // checkbox any database objects from previously saved project
                // procedures
                foreach (string sproc in this.projectProperties.SelectedProcedures)
                {
                    int index = this.chkLstProcedures.Items.IndexOf(sproc); // find index of item in collection
                    this.chkLstProcedures.SetItemChecked(index, true);
                }

                // functions
                foreach (string sproc in this.projectProperties.SelectedFnxs)
                {
                    int index = this.chkLstFnxs.Items.IndexOf(sproc); // find index of item in collection
                    this.chkLstFnxs.SetItemChecked(index, true);
                }

                // views
                foreach (string sproc in this.projectProperties.SelectedViews)
                {
                    int index = this.chkLstViews.Items.IndexOf(sproc); // find index of item in collection
                    this.chkLstViews.SetItemChecked(index, true);
                }

                // computed fields
                this.chkBxComputedFields.Checked = this.projectProperties.IsUnitTestComputedFields;

                if (this.chkBxComputedFields.Checked || this.projectProperties.SelectedViews.Count > 0 || this.projectProperties.SelectedFnxs.Count > 0 || this.projectProperties.SelectedProcedures.Count > 0)
                {
                    this.btnDBObjGenerateTests.Enabled = true;
                }
                else this.btnDBObjGenerateTests.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.Error(ex);
            }
        }
        #endregion

        #region Button Methods
        private void btnDBObjClose_Click(object sender, EventArgs e)
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

        private void btnDBObjBack_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                this.backForm.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.Error(ex);
            }
        }

        private void btnDBObjGenerateTests_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();

                this.projectProperties.SelectedProcedures = this.chkLstProcedures.CheckedItems.OfType<string>().ToList();
                this.projectProperties.SelectedFnxs = this.chkLstFnxs.CheckedItems.OfType<string>().ToList();
                this.projectProperties.SelectedViews = this.chkLstViews.CheckedItems.OfType<string>().ToList();

                UnitTests unitTestObjs = new UnitTests(this, this.projectProperties);

                unitTestObjs.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.Error(ex);
            }
        }

        #endregion

        #region Checkbox Methods

        private void chkToggleAllProcedures_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                for (int loop = 0; loop < this.chkLstProcedures.Items.Count; loop++)
                {
                    this.chkLstProcedures.SetItemChecked(loop, chkToggleAllProcedures.Checked);
                }

                this.CheckIfSelectionMade();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.Error(ex);
            }
        }

        private void chkToggleAllViews_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                for (int loop = 0; loop < this.chkLstViews.Items.Count; loop++)
                {
                    this.chkLstViews.SetItemChecked(loop, chkToggleAllViews.Checked);
                }

                this.CheckIfSelectionMade();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.Error(ex);
            }
        }

        private void chkToggleAllFnxs_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                for (int loop = 0; loop < this.chkLstFnxs.Items.Count; loop++)
                {
                    this.chkLstFnxs.SetItemChecked(loop, this.chkToggleAllFnxs.Checked);
                }

                this.CheckIfSelectionMade();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.Error(ex);
            }
        }

        private void chkLstProcedures_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                this.CheckIfSelectionMade();
            }
            catch (Exception ex)
            {
                btnDBObjGenerateTests.Enabled = false;

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.Error(ex);
            }
        }

        private void chkLstViews_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                this.CheckIfSelectionMade();
            }
            catch (Exception ex)
            {
                btnDBObjGenerateTests.Enabled = false;

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.Error(ex);
            }
        }

        private void chkLstFnxs_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                this.CheckIfSelectionMade();
            }
            catch (Exception ex)
            {
                btnDBObjGenerateTests.Enabled = false;

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.Error(ex);
            }
        }

        private void chkBxComputedFields_CheckedChanged(object sender, EventArgs e)
        {
            this.projectProperties.IsUnitTestComputedFields = chkBxComputedFields.Checked;
        }
        #endregion

        #region Private Methods
        private void CheckIfSelectionMade()
        {
            try
            {
                if (this.chkLstProcedures.CheckedItems.Count > 0 || this.chkLstFnxs.CheckedItems.Count > 0 || this.chkLstViews.CheckedItems.Count > 0)
                {
                    btnDBObjGenerateTests.Enabled = true;
                }
                else btnDBObjGenerateTests.Enabled = false;
            }
            catch (Exception ex)
            {
                btnDBObjGenerateTests.Enabled = false;

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.Error(ex);
            }
        }
        #endregion


    }
}
