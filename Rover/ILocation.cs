namespace Rover
{
    public interface ILocation
    {
        Position GetFinalDirection(Position _position, string _path);
    }
}
