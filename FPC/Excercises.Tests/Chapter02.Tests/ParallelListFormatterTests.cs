using System.Linq;
using Excercises.Chapter02.Examples;
using Xunit;

namespace Excercises.Tests.Chapter02.Tests
{
    public class ParallelListFormatterTests
    {
        [Fact]
        public void ItWorksOnAVeryLongList()
        {
            var size = 100000;
            var input = Enumerable.Range(1, size).Select(i => $"item{i}");

            var output = new ListFormatter().ImpureParalell(input.ToList());

            Assert.Equal("100000. Item100000", output[size - 1]);
        }

        [Fact]
        public void ItWorksOnAVeryLongListWithoutParallel()
        {
            var size = 100000;
            var input = Enumerable.Range(1, size).Select(i => $"item{i}");

            var output = new ListFormatter().Impure(input.ToList());

            Assert.Equal("100000. Item100000", output[size - 1]);
        }

        [Fact]
        public void ItWorksOnAVeryLongListWithoutZip()
        {
            var size = 100000;
            var input = Enumerable.Range(1, size).Select(i => $"item{i}");

            var output = ListFormatter.FormatZip(input.ToList());

            Assert.Equal("100000. Item100000", output[size - 1]);
        }
    }
}