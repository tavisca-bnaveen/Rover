namespace Rover
{
    public class Step
    {
        public Position MoveForward(Position position)
        {
            switch (position.Direction.ToString().ToLower())
            {
                case "north":
                    position.Y += 1;
                    break;
                case "east":
                    position.X += 1;
                    break;
                case "west":
                    position.X -= 1;
                    break;
                case "south":
                    position.Y -= 1;
                    break;
                default:
                    break;
            }
            return position;

        }
    }
}
