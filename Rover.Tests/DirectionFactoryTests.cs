using Xunit;

namespace Rover.Tests
{
    public class DirectionFactoryTests
    {
        [Fact]
        public void Test_For_East()
        {
            Assert.Equal(Direction.East, DirectionFactory.GetEnumDirection("E"));
        }
        [Fact]
        public void Test_For_West()
        {
            Assert.Equal(Direction.West, DirectionFactory.GetEnumDirection("W"));
        }
        [Fact]
        public void Test_For_North()
        {
            Assert.Equal(Direction.North, DirectionFactory.GetEnumDirection("N"));
        }
        [Fact]
        public void Test_For_South()
        {
            Assert.Equal(Direction.South, DirectionFactory.GetEnumDirection("S"));
        }
    }
}
