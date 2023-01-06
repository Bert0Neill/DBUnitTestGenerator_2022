using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBUnitTestGeneratorExt.Services
{
    public class HelperMethods : IHelperMethods
    {
        private StringBuilder errorMessages = null;

        public HelperMethods()
        {
            this.errorMessages = new StringBuilder();
        }
        public string BuildExeptionSQL(SqlException ex)
        {
            for (int loop = 0; loop < ex.Errors.Count; loop++)
            {
                errorMessages.Append("Index #" + loop + "\n" +
                    "Message: " + ex.Errors[loop].Message + "\n" +
                    "LineNumber: " + ex.Errors[loop].LineNumber + "\n" +
                    "Source: " + ex.Errors[loop].Source + "\n" +
                    "Procedure: " + ex.Errors[loop].Procedure + "\n");
            }
            return errorMessages.ToString();
        }
    }
}
