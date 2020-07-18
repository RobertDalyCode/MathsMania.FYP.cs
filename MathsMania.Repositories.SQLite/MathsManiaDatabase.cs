namespace MathsMania.Repositories.SQLite
{
	using System;
	public partial class MathsManiaDatabase : MathsManiaSystem, DatabaseAgent
	{
		public MathsManiaDatabase(String connectionString)
		{
			this.ConnectionString = connectionString;
			var mathsManiaSqlStatements = new MathsManiaSqlStatements();
			//
			//	repositories
			//
			this.UserAccountRepository = new UserAccountRepositoryComponent(this, mathsManiaSqlStatements);
			this.UserGroupRepository = new UserGroupRepositoryComponent(this, mathsManiaSqlStatements);
		}
		#region Public Properties
		#endregion
		public UserAccountRepository UserAccountRepository { get; }
		public UserGroupRepository UserGroupRepository { get; }
		public String ConnectionString { get; }
	}
}