using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBUnitTestGeneratorExt.Models
{
    public class GeneratedParameters : IGeneratedParameters
    {
        public GeneratedParameters()
        {
            Parameters = new StringBuilder();
        }

        public StringBuilder Parameters { get; set; }
        public string SQLReturnDataType { get; set; }
        public string CSharpReturnDataType { get; set; }
        public string FnxSelectStatement { get; set; }

      
    }
}
