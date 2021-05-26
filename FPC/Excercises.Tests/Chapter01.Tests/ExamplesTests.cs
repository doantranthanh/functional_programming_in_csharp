using System;
using System.Collections.Generic;
using System.Text;
using Excercises.Chapter01;
using FluentAssertions;
using Xunit;

namespace Excercises.Tests.Chapter01.Tests
{
    public class ExamplesTests
    {
        [Fact]
        public void ShouldSwapArgsFunctionWork()
        {
            Func<int, int, int> divide = (t1, t2) => t1 / t2;
            var swapArgsFunc = divide.SwapArgs();

            var originalResult = divide(10, 5);
            var swapResult = swapArgsFunc(10, 5);

            originalResult.Should().Be(2);
            swapResult.Should().Be(0);
        }
    }
}