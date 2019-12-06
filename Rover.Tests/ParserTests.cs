using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Rover.Tests
{
    public class ParserTests
    {
        private Parser _parser;
        public ParserTests()
        {
            _parser = new Parser();
        }
        [Fact]
        public void Test_For_Input_Parser()
        {
           var position= _parser.InputParser("(9,9,W)");
            Assert.Equal(9, position.X);
            Assert.Equal(9, position.Y);
            Assert.Equal(Direction.West, position.Direction);
        }
        [Fact]
        public void Test_For_Output_Parser()
        {
            var position = new Position();
            position.X = 9;
            position.Y = 9;
            position.Direction = Direction.West;

            Assert.Equal("(9,9,W)", _parser.OutputParser(position));
        }

        [Fact]
        public void Test_For_Parser_Flow()
        {
            var position = _parser.InputParser("(9,9,W)");
            
            Assert.Equal("(9,9,W)", _parser.OutputParser(position));
        }

    }
}
