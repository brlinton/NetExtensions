using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;
using NetExtensions;

namespace NetExtensions.Test
{
    public class IntExtensionsTest
    {
        [Fact]
        public void CanDeriveDaysFromInt()
        {
            var result = 5.Days();

            Assert.Equal(new TimeSpan(5, 0, 0, 0), result);
            Assert.Equal(new TimeSpan(5, 0, 0, 0).Days, result.Days);
        }

        [Fact]
        public void CanDeriveHoursFromInt()
        {
            var result = 5.Hours();

            Assert.Equal(new TimeSpan(5, 0, 0), result);
            Assert.Equal(new TimeSpan(5, 0, 0).Hours, result.Hours);
        }

        [Fact]
        public void CanDeriveMinutesFromInt()
        {
            var result = 5.Minutes();

            Assert.Equal(new TimeSpan(0, 5, 0), result);
            Assert.Equal(new TimeSpan(0, 5, 0).Minutes, result.Minutes);
        }

        [Fact]
        public void CanDeriveSecondsFromInt()
        {
            var result = 5.Seconds();

            Assert.Equal(new TimeSpan(0, 0, 5), result);
            Assert.Equal(new TimeSpan(0, 0, 5).Seconds, result.Seconds);
        }

        [Fact]
        public void CanDeriveMillisecondsFromInt()
        {
            var result = 5.Milliseconds();

            Assert.Equal(new TimeSpan(0, 0, 0, 0, 5), result);
            Assert.Equal(new TimeSpan(0, 0, 0, 0, 5).Milliseconds, result.Milliseconds);
        }
    }
}
