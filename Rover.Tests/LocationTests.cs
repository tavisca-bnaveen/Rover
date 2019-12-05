using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Rover.Tests
{
    public class LocationTests
    {
        [Fact]
        public void Test_For_Final_Location()
        {
            var position = new Position();
            position.X = 0;
            position.Y = 0;
            position.direction = DirectionFactory.GetEnumDirection("N");
            var location = new Location();
            var newPosition = location.GetFinalDirection(position, "MMM");
            Assert.Equal(0, newPosition.X);
            Assert.Equal(3, newPosition.Y);
            Assert.Equal('N', newPosition.direction.ToString()[0]);
        }
        [Fact]
        public void Test_For_Final_Location2()
        {
            var position = new Position();
            position.X = 0;
            position.Y = 1;
            position.direction = DirectionFactory.GetEnumDirection("E");
            var location = new Location();
            var newPosition = location.GetFinalDirection(position, "MML");
            Assert.Equal(2, newPosition.X);
            Assert.Equal(1, newPosition.Y);
            Assert.Equal('N', newPosition.direction.ToString()[0]);
        }
        [Fact]
        public void Test_For_Final_Location3()
        {
            var position = new Position();
            position.X = 10;
            position.Y = 5;
            position.direction = DirectionFactory.GetEnumDirection("N");
            var location = new Location();
            var newPosition = location.GetFinalDirection(position, "MMLMRMML");
            Assert.Equal(9, newPosition.X);
            Assert.Equal(9, newPosition.Y);
            Assert.Equal('W', newPosition.direction.ToString()[0]);
        }

        [Fact]
        public void Test_For_Final_Location4()
        {
            var position = new Position();
            position.X = 0;
            position.Y = 0;
            position.direction = DirectionFactory.GetEnumDirection("N");
            var location = new Location();
            var newPosition = location.GetFinalDirection(position, "MMRMRMRMMLMLM");
            Assert.Equal(0, newPosition.X);
            Assert.Equal(0, newPosition.Y);
            Assert.Equal('E', newPosition.direction.ToString()[0]);
        }
    }
}
