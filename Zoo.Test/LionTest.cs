using System;
using Xunit;
using Zoo.Lib;

namespace Zoo.Test
{
    public class LionTest
    {
        [Fact]
        public void Declare_LionWithNameOnly_HasCorrectName()
        {
            //arrange
            Lion lion;

            //act
            var name = "ABCD";
            lion = new Lion(name);
            var actual = lion.Name;

            var expected = name;
            //assert
            Assert.Equal(expected, actual);

        }
    }
}
