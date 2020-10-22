using Logic;
using System;
using System.Threading.Tasks;

namespace QueryHandlerDoodle
{
    public class BarQueryHandler // Could implement : IQueryHandler<BarQuery, string> to help shape the correct pattern, but is not registered or used via that interface
	{
        private BarDbContext _barDbContext;

        internal BarQueryHandler(BarDbContext barDbContext)
        {
            _barDbContext = barDbContext;
        }

        public async virtual Task<string> Execute(BarQuery query)  // <-- can override via inheritance when testing, e.g. StubBarQueryHandler : BarQueryHandler
		{
            _barDbContext.DoWork();
			await Task.Delay(1);
			return query.Preamble + DateTimeOffset.Now.ToString("o");
		}
	}


}
