using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DBUnitTestGeneratorExt.Models
{
    public interface IProjectProperties
    {
        DateTime CreationDate { get; set; }
        string DatabaseType { get; set; }
        string DBConnectionString { get; set; }
        string LastEditedBy { get; set; }
        DateTime LastEditedTime { get; set; }
        //CheckedListBox.CheckedItemCollection SelectedFnxs { get; set; }
        //CheckedListBox.CheckedItemCollection SelectedProcedures { get; set; }
        //CheckedListBox.CheckedItemCollection SelectedViews { get; set; }
        List<string> SelectedFnxs { get; set; }
        List<string> SelectedProcedures { get; set; }
        List<string> SelectedViews { get; set; }
        string UnitTestLanguage { get; set; }
        string UnitTestType { get; set; }
        string ProjectSetupScriptSQL { get; set; }
        string TestSetupScriptSQL { get; set; }
        string ProjectTearDownScriptSQL { get; set; }
        string TestTearDownScriptSQL { get; set; }
        bool IsUnitTestComputedFields { get; set; }
    }
}