using ToyRobotChallenge.Enums;
using ToyRobotChallenge.Toy;

namespace ToyRobotChallenge.Command
{
    public class MoveCommand : OrderCommand
    {
        public override void Execute(ToyRobotCoordinate toyRobotCoordinate)
        {
            switch (toyRobotCoordinate.Direction)
            {
                case Direction.NORTH:
                    toyRobotCoordinate.YCoordinate += 1;
                    break;
                case Direction.SOUTH:
                    toyRobotCoordinate.YCoordinate -= 1;
                    break;
                case Direction.EAST:
                    toyRobotCoordinate.XCoordinate += 1;
                    break;
                case Direction.WEST:
                    toyRobotCoordinate.XCoordinate -= 1;
                    break;
            }
        }
    }
}