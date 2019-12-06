namespace Rover
{
    public static class DirectionFactory
    {
        public static Direction GetEnumDirection(string direction)
        {
            switch (direction.ToUpper())
            {
                case "E":
                    return Direction.East;
                case "N":
                    return Direction.North;
                case "S":
                    return Direction.South;
                case "W":
                    return Direction.West;
                default:
                    return Direction.East;
            }
        }
        
    }
}
