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

        [Fact]
        public void CanCreatePipeDelimitedListFromStringEnumerable()
        {
            var strings = new [] { "a", "b", "c"};

            var result = strings.ToPipeDelimitedString();

            Assert.Equal("a|b|c", result);
        }

        [Fact]
        public void OneValueCreatesNoPipeFromStringEnumerable()
        {
            var strings = new [] { "a" };

            var result = strings.ToPipeDelimitedString();

            Assert.Equal("a", result);
        }

        [Fact]
        public void EmptyListReturnsStringEmptyForPipeDelimitedString()
        {
            var strings = new string[0];

            var result = strings.ToPipeDelimitedString();

            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void NullReturnsStringEmptyForPipeDelimitedString()
        {
            IEnumerable<string> strings = null;

            var result = strings.ToPipeDelimitedString();

            Assert.Equal(string.Empty, result);
        }
    }
}
