using System;

namespace Rover
{
    public class Location: ILocation
    {
       
        private Step _step;
        private Direction _direction;
        public Location()
        {
            
            _step = new Step();
        }
        
        public Position GetFinalDirection(Position _position, string _path)
        {
            
            var directionValue = (int)_position.Direction;
            for(int i=0;i< _path.Length; i++)
            {
                switch (_path[i].ToString().ToUpper())
                {
                    case "L":
                        directionValue -= 1;
                        break;
                    case "R":
                        directionValue += 1;
                        break;
                    case "M":
                        _position=_step.MoveForward(_position);
                        break;
                    default:
                        break;
                }
                int tempDirectionValue = directionValue;
                if (directionValue < 0)
                    tempDirectionValue = 4+(directionValue%4);
                Enum.TryParse<Direction>(((tempDirectionValue % 4)).ToString(), out _direction);
                _position.Direction = _direction; 
            }
            return _position;
        }
    }
}
