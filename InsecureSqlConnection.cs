using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeQL_Query_Writing_Demo
{
	//TODO: set encrypt to true when creating a SQL Connection!
	class InsecureSqlConnection
	{
		public void Case1()
		{
			SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder("Server=(local);Database=AdventureWorks;UID=ab;Pwd= a!Pass@@;encrypt=false");
		}

		public void Case2()
		{
			string connectionString = "Server=(local);Database=AdventureWorks;UID=ab;Pwd= a!Pass@@;encrypt=false";
			SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(connectionString);

		}
		public void Case3()
		{
			string connectionString = "Server=(local);Database=AdventureWorks;UID=ab;Pwd= a!Pass@@;";
			SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(connectionString) { Encrypt = true};
		}
	}
}