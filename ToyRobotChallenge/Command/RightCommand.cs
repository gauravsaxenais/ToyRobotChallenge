using ToyRobotChallenge.Enums;
using ToyRobotChallenge.Toy;

namespace ToyRobotChallenge.Command
{
    public class RightCommand : OrderCommand
    {
        public override void Execute(ToyRobotCoordinate toyRobotCoordinate)
        {
            switch (toyRobotCoordinate.Direction)
            {
                case Direction.EAST:
                    toyRobotCoordinate.Direction = Direction.SOUTH;
                    break;
                case Direction.WEST:
                    toyRobotCoordinate.Direction = Direction.NORTH;
                    break;
                case Direction.NORTH:
                    toyRobotCoordinate.Direction = Direction.EAST;
                    break;
                case Direction.SOUTH:
                    toyRobotCoordinate.Direction = Direction.WEST;
                    break;
            }
        }
    }
}