using ToyRobotChallenge.Command;

namespace ToyRobotChallenge.Toy
{
    public class ToyRobot
    {
        public ToyRobotCoordinate ToyRobotCoordinate { get; private set; }

        public ToyRobot(ToyRobotCoordinate toyRobotCoordinate)
        {
            ToyRobotCoordinate = toyRobotCoordinate;
        }

        public void ExecuteCommand(OrderCommand orderCommand)
        {
            orderCommand.Execute(ToyRobotCoordinate);
        }

        public string ReportPosition()
        {
            return ToyRobotCoordinate.XCoordinate + "," + ToyRobotCoordinate.YCoordinate
                    + "," + ToyRobotCoordinate.Direction;
        }
    }
}