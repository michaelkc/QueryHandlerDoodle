using System.Threading.Tasks;

namespace Core
{
    public interface ICommandHandler<in TCommand>
	{
		Task Execute(TCommand command);
	}
}
