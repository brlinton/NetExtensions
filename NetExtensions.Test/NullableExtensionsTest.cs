using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace NetExtensions.Test
{
    public class NullableExtensionsTest
    {
        [Fact]
        public void CanParseNullableIntSafelyForNull()
        {
            // Arrange
            string test = null;
            
            // Act
            var result = test.TryParse<int>();

            // Assert
            Assert.Equal(null, result);
        }

        [Fact]
        public void CanParseNullableIntSafelyForValue()
        {
            // Arrange
            string test = "5";

            // Act
            var result = test.TryParse<int>();

            // Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void CanParseNullableDoubleSafelyForNull()
        {
            // Arrange
            string test = null;

            // Act
            var result = test.TryParse<double>();

            // Assert
            Assert.Equal(null, result);
        }

        [Fact]
        public void CanParseNullableDoubleSafelyForValue()
        {
            // Arrange
            string test = "5.5";

            // Act
            var result = test.TryParse<double>();

            // Assert
            Assert.Equal(5.5, result);
        }
    }
}
