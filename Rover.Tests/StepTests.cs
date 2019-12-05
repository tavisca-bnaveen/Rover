using System;
using Xunit;

namespace Rover.Tests
{
    public class StepTests
    {
        private Step _step;
        private Position _position;
        public StepTests()
        {
            _step = new Step();
            _position = new Position();
            _position.X = 0;
            _position.Y = 0;
        }
        [Fact]
        public void Test_For_Moving_Forward_North()
        {

            _position.direction = DirectionFactory.GetEnumDirection("N");
            _step.MoveForward(_position);
            Assert.Equal(1, _position.Y);
            Assert.Equal(0, _position.X);
        }
        [Fact]
        public void Test_For_Moving_Forward_South()
        {

            _position.direction = DirectionFactory.GetEnumDirection("S");
            _step.MoveForward(_position);
            Assert.Equal(-1, _position.Y);
            Assert.Equal(0, _position.X);
        }
        [Fact]
        public void Test_For_Moving_Forward_West()
        {

            _position.direction = DirectionFactory.GetEnumDirection("W");
            _step.MoveForward(_position);
            Assert.Equal(0, _position.Y);
            Assert.Equal(-1, _position.X);
        }
        [Fact]
        public void Test_For_Moving_Forward_East()
        {

            _position.direction = DirectionFactory.GetEnumDirection("E");
            _step.MoveForward(_position);
            Assert.Equal(0, _position.Y);
            Assert.Equal(1, _position.X);
        }

    }
}
