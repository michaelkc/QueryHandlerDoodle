using Core;
using QueryHandlerDoodle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{

    // Imagine this is a module for DI where the "interface" of handlers is registrered
    // Instead of a crummy service locator
    public static class DIModuleSimulator
    {
        public static IQueryHandler<FooQuery, string> GetFooHandler()
        {
            return new FooQueryHandler(new FooDbContext());
        }

        public static BarQueryHandler GetBarHandler()
        {
            return new BarQueryHandler(new BarDbContext());
        }
    }
}
