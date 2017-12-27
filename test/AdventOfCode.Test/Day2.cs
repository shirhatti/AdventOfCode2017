using System;
using System.Collections.Generic;
using System.Linq;
using AdventOfCode;
using Xunit;
using Xunit.Extensions;

namespace AdventOfCode.Test
{
    public class UnitTest2
    {
        [Theory]
        [InlineData("5 1 9 5", new int[] {5, 1, 9, 5})]
        [InlineData("7 5 3", new int[] {7, 5, 3})]
        [InlineData("2 4 6 8", new int[] {2, 4, 6, 8})]
        public void LineToList(string Input, int[] ArrayOfNumbers)
        {
            Assert.True(Day2.LineToList(Input).ToArray().SequenceEqual(ArrayOfNumbers));
        }

        public static IEnumerable<object []> MinMaxTestData
        {
            get
            {
                return new[]
                {
                    new object[] {new List<int> {5, 1, 9, 5}, 8},
                    new object[] {new List<int> {7, 5, 3}, 4},
                    new object[] {new List<int> {2, 4, 6, 8}, 6}
                };
            }
        }
        [Theory]
        [MemberData(nameof(MinMaxTestData))]
        public void MinMax(List<int> list, int maxMinusMin){
            var computedMaxMinusMin = Day2.MaxMinusMin(list);
            Assert.Equal(maxMinusMin, computedMaxMinusMin);
        }

        public static IEnumerable<object []> PerfectDivisorTestData
        {
            get
            {
                return new[]
                {
                    new object[] {new List<int> {5, 9, 2, 8}, 4},
                    new object[] {new List<int> {9, 4, 7, 3}, 3},
                    new object[] {new List<int> {3, 8, 6, 5}, 2}
                };
            }
        }
        [Theory]
        [MemberData(nameof(PerfectDivisorTestData))]
        public void PerfectDivisors(List<int> list, int perfectDivisors){
            var computedPerfectDivisors = Day2.PerfectDivisors(list);
            Assert.Equal(perfectDivisors, computedPerfectDivisors);
        }

        [Theory]
        [InlineData("5 1 9 5\n7 5 3\n2 4 6 8", 18)]
        public void ComputeMaxMinusMinChecksum(string input, int result)
        {
            Assert.Equal(result, Day2.ComputeCheckSum(input, Day2.MaxMinusMin));
        }

        [Theory]
        [InlineData("5 9 2 8\n9 4 7 3\n3 8 6 5", 9)]
        public void ComputePerfectDivisorsChecksum(string input, int result)
        {
            Assert.Equal(result, Day2.ComputeCheckSum(input, Day2.PerfectDivisors));
        }
    }
}
