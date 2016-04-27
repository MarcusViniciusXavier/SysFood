using SysFood.Domain;
using System;
using Xunit;

namespace TestsUnit
{
    public class Logar
    {
        [Fact]
        public void TestSomar()
        {
            Assert.True(Domain.Usuario().Logar("marcus", "logar"));
        }
    }
}
