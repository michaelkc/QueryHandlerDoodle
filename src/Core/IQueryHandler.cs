using System.Threading.Tasks;

namespace Core
{
    public interface IQueryHandler<in TQuery, TResult>
	{
		Task<TResult> Execute(TQuery query);
	}
}
