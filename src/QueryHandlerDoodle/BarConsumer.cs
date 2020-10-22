using System;
using System.Threading.Tasks;

namespace QueryHandlerDoodle
{
    internal class BarConsumer
	{
		private readonly BarQueryHandler _barHandler;

		// Locks the handler type to the concrete type and its derivatives
		// And forces you to make all constructor dependencies public, which makes it difficult to "hide" implementation 
		// details like DbContext etc., which should not be used outside of the handlers, from consumers 
		// (given that consumer and handler implementation will typically be in different projects)
		public BarConsumer(BarQueryHandler barHandler)
		{
			_barHandler = barHandler;
		}

		public async Task DoSomeWork()
		{
			// F12 on Execute puts you inside BarQueryHandler
			var queryResult = await _barHandler.Execute(new BarQuery("The time is "));
			Console.WriteLine($"My Bar Query returned: {queryResult}");

		}
	}


}
