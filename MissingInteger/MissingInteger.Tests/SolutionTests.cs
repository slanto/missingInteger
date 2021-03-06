﻿namespace MissingInteger.Tests
{
    using MissingInteger.Core;

    using Xunit;

    public class SolutionTests
    {
        [Theory]
        [InlineData(new [] { 1, 3, 6, 4, 1, 2 }, 5)]
        [InlineData(new[] { int.MinValue, 0, 2, 4, 3, int.MinValue }, 1)]        
        public void GetMissingInteger_ReturnsMissingIntegerFromGivenArray(int[] array, int expected)
        {
            var sut = new Solution();
            var actual = sut.GetMissingInteger(array);
            Assert.Equal(expected, actual);
        }
    }
}
