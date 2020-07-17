namespace MathsMania.Repositories.UnitTests.SQLite
{
	using MathsMania.Repositories.SQLite;
	public class DatabaseBuilder : DatabaseBuilderBase
	{
		// Use Manager User Secrets and add: "SQLiteTestDatabaseConnectionString": "DataSource=mathsmania-v1.sqlite3"
		public DatabaseBuilder() : base(connectionStringKey: "SQLiteTestDatabaseConnectionString")
		{
		}
		public MathsManiaDatabase Build()
		{
			return new MathsManiaDatabase(GetConnectionString());
		}
	}
}