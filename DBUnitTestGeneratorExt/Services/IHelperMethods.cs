using System.Data.SqlClient;

namespace DBUnitTestGeneratorExt.Services
{
    public interface IHelperMethods
    {
        string BuildExeptionSQL(SqlException ex);
    }
}