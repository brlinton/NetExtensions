using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NetExtensions;
using Xunit;

namespace NetExtensions.Test
{
    public class ObjectExtensionsTest
    {
        public interface ITester
        {
            int MethodCounter { get; set; }

            void Method();
        }

        public class Tester : ITester
        {
            public int MethodCounter { get; set; }

            public Tester()
            {
                MethodCounter = 0;
            }

            public void Method()
            {
                MethodCounter++;
            }
        }

        [Fact]
        public void AsIfOfCorrectTypeInvokesMethod()
        {
            var tester = new Tester();

            tester.AsIf<ITester>(x => x.Method());

            Assert.Equal(1, tester.MethodCounter);
        }

        [Fact]
        public void AsIfOfIncorrectTypeInvokesNothing()
        {
            var tester = "not a tester object";

            tester.AsIf<ITester>(x => x.Method());
        }
    }
}
