using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace YourUnitTestProjectName
{
	[TestClass]
	public class YourUnitClassName
	{


		#region Private Variables
		private static string connString = "Data Source=LHTU0CND7501B6S;Initial Catalog=P2;Integrated Security=True;MultipleActiveResultSets=True";
		public TestContext TestContext { get; set; }
		private static StringBuilder errorMessages = null;
		private static TestContext testContext;
		#endregion

		#region Initialise & Cleanup Methods
		[ClassInitialize()]
		public static void ClassInit(TestContext context)
		{

		}

		[TestInitialize()]
		public void Initialize()
		{

		}

		[ClassCleanup()]
		public static void ClassCleanup()
		{

		}

		[TestCleanup]
		public void Cleanup()
		{

		}
		#endregion

		#region MSTests - Database Stored Procedures
		[TestMethod]
		public void StoredProcedure_RetrieveClaimsByProcessors()
		{
			try
			{
				using (SqlConnection con = new SqlConnection(connString))
				{
					using (SqlCommand cmd = new SqlCommand("[dbo].[RetrieveClaimsByProcessors]", con))
					{
						cmd.CommandType = CommandType.StoredProcedure;

						// add parameters (if needed)
						cmd.Parameters.Add("@AssignedTo", SqlDbType.Int).Value = 67;


						SqlDataAdapter da = new SqlDataAdapter();
						da.SelectCommand = cmd;

						DataSet ds = new DataSet();
						da.Fill(ds, "data");

						Assert.IsTrue(ds.Tables.Count == 1);
						Assert.IsTrue(ds.Tables[0].Rows.Count == 10);
					}
				}
			}
			catch (SqlException ex)
			{
				Console.WriteLine(BuildExeptionSQL(ex));
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
		#endregion
		#region MSTests - Database Functions

		#endregion
		#region MSTests - Database Views

		#endregion
		#region MSTests - Database Computed Fields

		#endregion
		#region MSTests - Utility methods

		#region Private Utility Methods
		private static string BuildExeptionSQL(SqlException ex)
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
		#endregion

		#endregion

	}
}
