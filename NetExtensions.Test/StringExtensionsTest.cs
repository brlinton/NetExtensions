using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace NetExtensions.Test
{
    public class StringExtensionsTest
    {
        [Fact]
        public void CanCreateCsvStringFromStringEnumerable()
        {
            var strings = new [] { "a", "b", "c" };

            var csv = strings.ToCsv();

            Assert.Equal("a,b,c", csv);
        }

        [Fact]
        public void StringEnumerableWithOneStringHasNoCommas()
        {
            var strings = new[] { "a" };

            var csv = strings.ToCsv();

            Assert.DoesNotContain(",", csv);
            Assert.Equal("a", csv);
        }

        [Fact]
        public void EmptyListReturnsStringEmpty()
        {
            var strings = new string[0];

            var csv = strings.ToCsv();

            Assert.Equal(string.Empty, csv);
        }
    }
}
