using Core;
using Logic;
using System;
using System.Threading.Tasks;

namespace QueryHandlerDoodle
{
    internal class FooQueryHandler : IQueryHandler<FooQuery, string>
	{
        private FooDbContext fooDbContext;

        public FooQueryHandler(FooDbContext fooDbContext)
        {
            this.fooDbContext = fooDbContext;
        }

        public async Task<string> Execute(FooQuery query)
		{
			await Task.Delay(1);
			return query.Preamble + DateTimeOffset.Now.ToString("o");
		}
	}


}
