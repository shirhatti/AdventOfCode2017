using System;
using Xunit;
using AdventOfCode;

namespace AdventOfCode.Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("1122", 3)]
        [InlineData("1111", 4)]
        [InlineData("1234", 0)]
        [InlineData("91212129", 9)]
        public void InverseCaptcha(string Input, int Result)
        {
            Assert.True(Day1.InverseCaptcha(Input).Equals(Result));
        }
    }
}
