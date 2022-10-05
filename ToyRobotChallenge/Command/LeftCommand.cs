using ToyRobotChallenge.Enums;
using ToyRobotChallenge.Toy;

namespace ToyRobotChallenge.Command
{
    public class LeftCommand : OrderCommand
    {
        public override void Execute(ToyRobotCoordinate toyRobotCoordinate)
        {
            switch (toyRobotCoordinate.Direction)
            {
                case Direction.EAST:
                    toyRobotCoordinate.Direction = Direction.NORTH;
                    break;
                case Direction.WEST:
                    toyRobotCoordinate.Direction = Direction.SOUTH;
                    break;
                case Direction.NORTH:
                    toyRobotCoordinate.Direction = Direction.WEST;
                    break;
                case Direction.SOUTH:
                    toyRobotCoordinate.Direction = Direction.EAST;
                    break;
            }
        }
    }
}