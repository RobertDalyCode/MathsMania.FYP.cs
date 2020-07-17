namespace MathsMania.Repositories
{
	public interface MathsManiaSystem
	{
		UserAccountRepository UserAccountRepository { get; }
		UserGroupRepository UserGroupRepository { get; }
	}
}