namespace MathsMania.Repositories.SQLite
{
	using System;
	public partial class MathsManiaDatabase : MathsManiaSystem, DatabaseAgent
	{
		public MathsManiaDatabase(String connectionString)
		{
			this.ConnectionString = connectionString;
			var timeFactorsSqlStatements = new MathsManiaSqlStatements();
			//
			//	repositories
			//
			this.UserAccountRepository = new UserAccountRepositoryComponent(this, timeFactorsSqlStatements);
			this.UserGroupRepository = new UserGroupRepositoryComponent(this, timeFactorsSqlStatements);
		}
		#region Public Properties
		#endregion
		public UserAccountRepository UserAccountRepository { get; }
		public UserGroupRepository UserGroupRepository { get; }
		public String ConnectionString { get; }
	}
}