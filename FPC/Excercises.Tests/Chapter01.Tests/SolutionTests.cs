using System;
using FluentAssertions;
using Xunit;
using static Excercises.Chapter01.Solutions;

namespace Excercises.Tests.Chapter01.Tests
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(2, true)]
        [InlineData(3, false)]
        public void NegateFuncShouldWorkAsExpected(int num, bool negateValue)
        {
            Func<int, bool> isOdd = x => x % 2 == 1;

            var result = isOdd.Negate()(num);

            result.Should().Be(negateValue);
        }
    }
}
