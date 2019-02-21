using MemoryLists.Library;
using System;
using Xunit;

namespace MemoryLists.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(10)]
        [InlineData(14)]
        [InlineData(138972)]
        public void AddedItemsAreContained(int val)
        {
            var list = new MemoryList<int>();

            list.Add(val);

            Assert.True(list.Contains(val));
        }

        [Theory]
        public void 
    }
}
