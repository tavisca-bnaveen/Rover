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
            var parser = new Parser();
            var position = parser.InputParser("(0,0,N)");
            var location = new Location();
            var newPosition = location.GetFinalDirection(position, "MMM");
            Assert.Equal(0, newPosition.X);
            Assert.Equal(3, newPosition.Y);
            Assert.Equal('N', newPosition.Direction.ToString()[0]);
            Assert.Equal("(0,3,N)", parser.OutputParser(newPosition));
        }
        [Fact]
        public void Test_For_Final_Location2()
        {
            var parser = new Parser();
            var position = parser.InputParser("(0,1,E)");
            var location = new Location();
            var newPosition = location.GetFinalDirection(position, "MML");
            Assert.Equal(2, newPosition.X);
            Assert.Equal(1, newPosition.Y);
            Assert.Equal('N', newPosition.Direction.ToString()[0]);
            Assert.Equal("(2,1,N)", parser.OutputParser(newPosition));
        }
        [Fact]
        public void Test_For_Final_Location3()
        {
            var parser = new Parser();
            var position = parser.InputParser("(10,5,N)");
            var location = new Location();
            var newPosition = location.GetFinalDirection(position, "MMLMRMML");
            Assert.Equal(9, newPosition.X);
            Assert.Equal(9, newPosition.Y);
            Assert.Equal('W', newPosition.Direction.ToString()[0]);
            Assert.Equal("(9,9,W)", parser.OutputParser(newPosition));

        }

        [Fact]
        public void Test_For_Final_Location4()
        {
            var parser = new Parser();
            var position = parser.InputParser("(0,0,N)");
            var location = new Location();
            var newPosition = location.GetFinalDirection(position, "MMRMRMRMMLMLM");
            Assert.Equal(0, newPosition.X);
            Assert.Equal(0, newPosition.Y);
            Assert.Equal('E', newPosition.Direction.ToString()[0]);
            Assert.Equal("(0,0,E)", parser.OutputParser(newPosition));
        }
    }
}
