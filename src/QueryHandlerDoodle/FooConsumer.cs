using Core;
using System;
using System.Threading.Tasks;

namespace QueryHandlerDoodle
{
    internal class FooConsumer
	{
		private readonly IQueryHandler<FooQuery, string> _fooHandler;

		// Allows us to swap handler types entirely, as long as they implement the interface. 
		public FooConsumer(IQueryHandler<FooQuery, string> fooHandler)
		{
			_fooHandler = fooHandler;
		}

		public async Task DoSomeWork()
		{
			// F12 on Execute puts you inside IQueryHandler
			var queryResult = await _fooHandler.Execute(new FooQuery("The time is "));
			Console.WriteLine($"My Foo Query returned: {queryResult}");

		}
	}


}
