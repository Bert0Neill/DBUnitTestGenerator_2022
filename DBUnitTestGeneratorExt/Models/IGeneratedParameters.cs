using System.Text;

namespace DBUnitTestGeneratorExt.Models
{
    public interface IGeneratedParameters
    {
        StringBuilder Parameters { get; set; }
        string SQLReturnDataType { get; set; }
        string CSharpReturnDataType { get; set; }
        string FnxSelectStatement{ get; set; }
}
}