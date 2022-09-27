using System;
using Xunit;
using WeeklyAlgos;

namespace WeeklyAlgos.Tests
{
    public class Week2_Easy
    {
        [Fact]
        public void isNotTheLargest()
        {
            bool actual = Week2.EasyAlgo(25);

            Assert.False(actual);
        }

        [Fact]
        public void isTheLargest()
        {
            bool actual = Week2.EasyAlgo(71);

            Assert.True(actual);
        }

        [Fact]
        public void isPalindromeNumber()
        {
            bool actual = Week2.EasyAlgo(33);

            Assert.True(actual);
        }

    }

    public class Week2_Medium
    {
        [Fact]
        public void hasPostiiveAndNegatives()
        {
            IEnumerable<Double> expected = new Double[] { 0.0145, 1.042, 1.104 };
            IEnumerable<Double> actual = Week2.MediumAlgo(new Double[] { -0.11, 1.2, -1.3, 4.256, 1.104, 2.102, 0.0145, 1.042 });

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void doesNotHaveThreePositiveNumbers()
        {
            IEnumerable<Double> expected = new Double[] { 0.0145, 4.01 };
            IEnumerable<Double> actual = Week2.MediumAlgo(new Double[] { -0.11, -1.3, -4.256, -1.104, -2.102, 0.0145, 4.01 });

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void hasNoPositiveNumbers()
        {
            IEnumerable<Double> expected = Enumerable.Empty<Double>();
            IEnumerable<Double> actual = Week2.MediumAlgo(new Double[] { -0.11, -1.3, -4.256, -1.104, -2.102, -0.0145, -4.01 });

            Assert.Equal(expected, actual);
        }
    }

    public class Week2_Hard
    {

        [Fact]
        public void handlesXAxis()
        {
            int expected = 4;
            int actual = Week2.HardAlgo(new int[] { 4, 1 }, new int[] { 8, 1 });
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void handlesYAxis()
        {
            int expected = 9;
            int actual = Week2.HardAlgo(new int[] { -2, 9 }, new int[] { -2, 0 });
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void handlesQuadrantOne()
        {
            int expected = 8;
            int actual = Week2.HardAlgo(new int[] { 2, 1 }, new int[] { 4, 7 });
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void handlesQuadrantThree()
        {
            int expected = 13;
            int actual = Week2.HardAlgo(new int[] { -5, -2 }, new int[] { 4, 2 });
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void handlesNoMoves()
        {
            int expected = 0;
            int actual = Week2.HardAlgo(new int[] { 4, 0 }, new int[] { 4, 0 });
            Assert.Equal(expected, actual);
        }
    }
}

