using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Shouldly;

namespace Demo.Lib.v7.Test
{
    public class ExtendedOperationTest
    {
        [Fact]
        public void Add_WithValues_ShouldBe()
        {
            var sut = new ExtendedOperation();
            var result = sut.Add(3.2m, 1.8m);
            result.ShouldBe(5.0m);
        }
    }
}
