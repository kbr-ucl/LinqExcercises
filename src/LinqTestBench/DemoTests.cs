using System;
using System.Linq;
using NorthWindDataAccess;
using Xunit;

namespace LinqTestBench
{
    public class DemoTests : IClassFixture<DatabaseFixture>
    {
        private NorthwindDbContext _context;

        public DemoTests(DatabaseFixture fixture)
        {
            _context = fixture.Context;
        }
        [Fact]
        public void Test1()
        {
                var actual = _context.Customer.ToList();

        }
    }
}
