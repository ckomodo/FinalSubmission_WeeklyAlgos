using System;
using Xunit;
using WeeklyAlgos;

namespace WeeklyAlgos.Tests
{
    public class Week1_Easy
    {
        [Fact]
        public void Test1()
        {
            int expected = 6;
            int actual = Week1.EasyAlgo("There are two types of people, introverts and extraverts.");

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CountsBothCases()
        {
            int expected = 4;
            int actual = Week1.EasyAlgo("Who Framed Roger Rabbit was a classic");

            Assert.Equal(expected, actual);
        }
    }

    public class Week1_Medium
    {
        [Fact]
        public void NoCommas()
        {
            string expected = "45";
            string actual = Week1.MediumAlgo(45);

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void MultipleCommas()
        {
            string expected = "20,000,000";
            string actual = Week1.MediumAlgo(20000000);

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void OneComma()
        {
            string expected = "3,800";
            string actual = Week1.MediumAlgo(3800);

            Assert.Equal(expected, actual);
        }
    }

    public class Week1_Hard
    {
        [Fact]
        public void NothingInCommon()
        {
            string expected = "";
            string actual = Week1.HardAlgo("basketball", "");

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void SameString()
        {
            string expected = "kayaking";
            string actual = Week1.HardAlgo("kayaking", "kayaking");

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void SomePartsInCommon()
        {
            string expected = "tball";
            string actual = Week1.HardAlgo("softball", "football");

            Assert.Equal(expected, actual);
        }
    }
}
