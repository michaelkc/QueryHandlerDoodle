using Logic;
using System.Threading.Tasks;

namespace QueryHandlerDoodle
{
    class Program
    {
		async static Task Main()
		{
			var fooConsumer = new FooConsumer(DIModuleSimulator.GetFooHandler());
			await fooConsumer.DoSomeWork();

			var barConsumer = new BarConsumer(DIModuleSimulator.GetBarHandler());
			await barConsumer.DoSomeWork();
		}
	}
}
