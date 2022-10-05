using ToyRobotChallenge.Command;
using ToyRobotChallenge.Enums;
using ToyRobotChallenge.Toy;

namespace ToyRobotChallenge
{
    public class Simulation
    {
        public ToyRobot? _toy;
        public readonly Table _table;

        public Simulation()
        {
            _table = new Table(5, 5);
        }

        public void Place(int x, int y, Direction direction)
        {
            if (_table.IsValidPosition(x, y))
            {
                var toyCoordinate = new ToyRobotCoordinate() { XCoordinate = x, YCoordinate = y, Direction = direction };
                _toy = new ToyRobot(toyCoordinate);
            }
        }

        public void PerformCommand(CommandType commandEnum)
        {
            if (_toy != null)
            {
                // shallow copy
                var oldToyXCoordinate = new ToyRobotCoordinate()
                {
                    XCoordinate = _toy.ToyRobotCoordinate.XCoordinate,
                    YCoordinate = _toy.ToyRobotCoordinate.YCoordinate,
                    Direction = _toy.ToyRobotCoordinate.Direction
                };
                switch (commandEnum)
                {
                    case CommandType.Move:
                        _toy.ExecuteCommand(new MoveCommand());
                        var newCoordinate = _toy.ToyRobotCoordinate;
                        if (!_table.IsValidPosition(newCoordinate.XCoordinate, newCoordinate.YCoordinate))
                            _toy = new ToyRobot(oldToyXCoordinate);
                        break;
                    case CommandType.Left:
                        _toy.ExecuteCommand(new LeftCommand());
                        break;
                    case CommandType.Right:
                        _toy.ExecuteCommand(new RightCommand());
                        break;
                    // maybe a separate custom exception
                    default:
                        throw new InvalidOperationException("Enum " + commandEnum + " of enum " + typeof(CommandType) + " is not supported");
                }
            }
        }
        public string Report()
        {
            return _toy != null ? _toy.ReportPosition() : string.Empty;
        }
    }
}
