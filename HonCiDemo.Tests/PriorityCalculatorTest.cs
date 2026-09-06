using System;
using System.Collections.Generic;
using System.Text;

using Xunit;

namespace Hon.Demo.Tests
{
    public class PriorityCalculatorTest
    {
        [Fact]
        public void HighScoreReturnsHigh()
        {
            var calc = new PriorityCalculator();
            Assert.Equal("HIGH", calc.Calculate(90));
        }

        [Fact]
        public void MediumScoreReturnsMedium()
        {
            var calc = new PriorityCalculator();
            Assert.Equal("MEDIUM", calc.Calculate(60));
        }

        [Fact]
        public void LowScoreReturnsLow()
        {
            var calc = new PriorityCalculator();
            Assert.Equal("LOW", calc.Calculate(30));
        }
    }
}

