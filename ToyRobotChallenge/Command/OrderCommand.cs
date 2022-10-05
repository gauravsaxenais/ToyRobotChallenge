using ToyRobotChallenge.Toy;

namespace ToyRobotChallenge.Command
{
    /// <summary>
    /// The Command abstract class
    /// </summary>
    public abstract class OrderCommand
    {
        public abstract void Execute(ToyRobotCoordinate toyRobotCoordinate);
    }
}
