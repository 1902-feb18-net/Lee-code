using CollectionTesting.Library;
using System;
using Xunit;

namespace CollectionTesting.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }

        [Fact]
        public void TestingAddAndContains()
        {
            // 1. Arrange
            var collection = new MyStringCollectionTests();
            // 2. Act

            // 3. Assert
        }

        [Fact]
        public void RemoveEmptyShouldRemoveOneEmpty()
        {
            var sut = new MyStringCollectionTests();

            sut.Add("");

            sut.RemoveEmpty();

            Assert.False(sut.Contains(""));
        }

        public void GetFirstShouldGetFirstFromNonEmptyList()
        {
            var sut = new MyStringCollectionTests();
            sut.Add("asdf");
            sut.Add("gklj");

            var result = sut.GetFirst();

            Assert.Equal("asdf", result);
        }
    }
}
