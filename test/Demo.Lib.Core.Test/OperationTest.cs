using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Demo.Lib.Core.Test
{
    public class OperationTest
    {
        [Fact]
        public void Add_WithValue_ShouldBeNumber()
        {
            var sut = new Operation();
            sut.Add(2, 3).ShouldBe(5);
        }

        [Fact]
        public void Multiply_WithValue_ShouldBe()
        {
            var sut = new Operation();
            sut.Multiply(2, 3).ShouldBe(6);
        }

        [Fact]
        public void Multiply_WithValue_ShouldBeWrongNumber()
        {
            var sut = new Operation();
            sut.Multiply(2, 3).ShouldBe(7);
        }
    }
}
