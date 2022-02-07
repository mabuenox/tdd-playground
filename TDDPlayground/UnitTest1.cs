using FluentAssertions;
using Xunit;

namespace TDDPlayground
{
    public class UnitTest1
    {
        [Fact]
        public void Foo()
        {
            true.Should().BeTrue();
        }
    }
}