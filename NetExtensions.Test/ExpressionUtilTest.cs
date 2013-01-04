using System;
using Xunit;

namespace NetExtensions.Test
{
    public class ExpressionUtilTest
    {
        public class TestClass
        {
            public string PropertyOne { get; set; }
            public int PropertyTwo { get; set; }
            public double PropertyThree { get; set; }
            public Type PropertyFour { get; set; }
            public TestClass PropertyFive { get; set; }
        }

        [Fact]
        public void CanGetPropertyNameFromStringProperty()
        {
            var result = ExpressionUtil.GetPropertyName<TestClass>(x => x.PropertyOne);

            Assert.Equal("PropertyOne", result);
        }

        [Fact]
        public void CanGetPropertyNameFromIntProperty()
        {
            var result = ExpressionUtil.GetPropertyName<TestClass>(x => x.PropertyTwo);

            Assert.Equal("PropertyTwo", result);
        }

        [Fact]
        public void CanGetPropertyNameFromDoubleProperty()
        {
            var result = ExpressionUtil.GetPropertyName<TestClass>(x => x.PropertyThree);

            Assert.Equal("PropertyThree", result);
        }

        [Fact]
        public void CanGetPropertyNameFromTypeProperty()
        {
            var result = ExpressionUtil.GetPropertyName<TestClass>(x => x.PropertyFour);

            Assert.Equal("PropertyFour", result);
        }

        [Fact]
        public void CanGetPropertyNameFromComplexProperty()
        {
            var result = ExpressionUtil.GetPropertyName<TestClass>(x => x.PropertyFive);

            Assert.Equal("PropertyFive", result);
        }
    }
}
