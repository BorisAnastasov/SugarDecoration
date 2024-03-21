namespace SugarDecoration.Infrastructure.Data.Contracts
{
	public interface IRepository
	{
		IQueryable<T> All<T>() where T: class;
		IQueryable<T> AllReadOnly<T>() where T: class;
	}
}
