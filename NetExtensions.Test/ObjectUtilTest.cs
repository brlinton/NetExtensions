﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace NetExtensions.Test
{
    public class ObjectUtilTest
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
            var result = ObjectUtil.GetPropertyName<TestClass>(x => x.PropertyOne);

            Assert.Equal("PropertyOne", result);
        }

        [Fact]
        public void CanGetPropertyNameFromIntProperty()
        {
            var result = ObjectUtil.GetPropertyName<TestClass>(x => x.PropertyTwo);

            Assert.Equal("PropertyTwo", result);
        }

        [Fact]
        public void CanGetPropertyNameFromDoubleProperty()
        {
            var result = ObjectUtil.GetPropertyName<TestClass>(x => x.PropertyThree);

            Assert.Equal("PropertyThree", result);
        }

        [Fact]
        public void CanGetPropertyNameFromTypeProperty()
        {
            var result = ObjectUtil.GetPropertyName<TestClass>(x => x.PropertyFour);

            Assert.Equal("PropertyFour", result);
        }

        [Fact]
        public void CanGetPropertyNameFromComplexProperty()
        {
            var result = ObjectUtil.GetPropertyName<TestClass>(x => x.PropertyFive);

            Assert.Equal("PropertyFive", result);
        }
    }
}
