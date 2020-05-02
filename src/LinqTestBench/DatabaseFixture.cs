using System;
using NorthWindDataAccess;

namespace LinqTestBench
{
    public class DatabaseFixture : IDisposable
    {
        public DatabaseFixture()
        {
            Context = new NorthwindDbContext();
        }

        public NorthwindDbContext Context { get; }

        public void Dispose()
        {
            Context.Dispose();
        }
    }
}