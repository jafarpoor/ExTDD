using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDD.Services;
using Xunit;

namespace TDD.Test
{
  public  class SumTest
    {
        [Theory]
        [InlineData("0",0)]
        [InlineData("", 0)]
        [InlineData("50 ,20", 70)]
        [InlineData("50 ,20,30,", 100)]
        public void Execute_SumNumbers_When_StringNumber(string Numbers , int expected)
        {
            //Arange
            Sum sum = new Sum();

            //Act
            var result = sum.Execute(Numbers);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}
