namespace MathsMania.Repositories.SQLite
{
	using System;
	public partial class MathsManiaDatabase : MathsManiaSystem, DatabaseAgent
	{
		public MathsManiaDatabase(String connectionString)
		{
			this.ConnectionString = connectionString;
			var sqlStatements = new MathsManiaSqlStatements();
			//
			//	repositories
			//
			this.UserAccountRepository = new UserAccountRepositoryComponent(this, sqlStatements);
			this.UserGroupRepository = new UserGroupRepositoryComponent(this, sqlStatements);
		}
		#region Public Properties
		#endregion
		public UserAccountRepository UserAccountRepository { get; }
		public UserGroupRepository UserGroupRepository { get; }
		public String ConnectionString { get; }
	}
}