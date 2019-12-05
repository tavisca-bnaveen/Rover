namespace Rover
{
    public class Parser
    {
        private Position _position;
        public Parser()
        {
            _position = new Position(); 
        }
        public Position InputParser(string input)
        {
            var parsedString = input.Split(',');
            _position.X =int.Parse( parsedString[0].Substring(1));
            _position.Y = int.Parse(parsedString[1]);
            _position.direction = DirectionFactory.GetEnumDirection(parsedString[2][0].ToString());
            return _position;
        }
        public string OutputParser(Position position)
        {
            string output = "(";
            output += position.X.ToString();
            output += ",";
            output += position.Y.ToString();
            output += ",";
            output += position.direction.ToString()[0];
            output += ")";
            return output;
        }
    }
}
