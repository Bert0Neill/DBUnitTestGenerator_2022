using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.CheckedListBox;

namespace DBUnitTestGeneratorExt.Models
{
    public class ProjectProperties : IProjectProperties
    {
        public ProjectProperties()
        {
            this.SelectedProcedures = null;
            this.SelectedProcedures = null;
            this.SelectedViews = null;

            this.CreationDate = DateTime.UtcNow; // when the initial unti test project was created     

            this.ProjectSetupScriptSQL = string.Empty;
            this.TestSetupScriptSQL = string.Empty;
            this.ProjectTearDownScriptSQL = string.Empty;
            this.TestTearDownScriptSQL = string.Empty;
            this.DBConnectionString = string.Empty;
            this.LastEditedBy = string.Empty;

            this.SelectedProcedures = new List<string>();
            this.SelectedFnxs = new List<string>();
            this.SelectedViews = new List<string>();
        }

        public string LastEditedBy { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastEditedTime { get; set; }

        public List<string> SelectedProcedures { get; set; }
        public List<string> SelectedFnxs { get; set; }
        public List<string> SelectedViews { get; set; }

        public string ProjectSetupScriptSQL { get; set; }
        public string TestSetupScriptSQL { get; set; }

        public string ProjectTearDownScriptSQL { get; set; }
        public string TestTearDownScriptSQL { get; set; }

        public bool IsUnitTestComputedFields { get; set; }

        public string DBConnectionString { get; set; }

        public string DatabaseType { get; set; }

        public string UnitTestType { get; set; }

        public string UnitTestLanguage { get; set; }


        //public enum EnumDatabaseType
        //{
        //    [Description("SQL Server")]
        //    SQLServer,

        //    [Description("Oracle RDB")]
        //    OracleRDB,

        //    [Description("Oracle 11g")]
        //    Oracle11g,

        //    [Description("MySQL")]
        //    MySQL,

        //    [Description("DB2")]
        //    DB2
        //}


        //public enum EnumUnitTestType
        //{
        //    [Description("MS Test")]
        //    MSTest,

        //    [Description("NUnit")]
        //    NUnit
        //}

        //public enum EnumUnitTestLanguage
        //{
        //    [Description("C#")]
        //    CSharp,

        //    [Description("VB.Net")]
        //    VBNet
        //}
    }
}
