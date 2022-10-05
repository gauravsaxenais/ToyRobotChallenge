using ToyRobotChallenge.Command;
using ToyRobotChallenge.Toy;
using Xunit;

namespace ToyRobotTest
{
    public class ToyRobotTest
    {
        private ToyRobot? _toyRobot;

        public ToyRobotTest()
        { }

        [Fact]
        public void ToyRobotTest_ReturnsWestDirection_WhenRobotIsTurnedLeftFacingNorth()
        {
            // Arrange
            _toyRobot = new ToyRobot(new ToyRobotCoordinate() { Direction = ToyRobotChallenge.Enums.Direction.NORTH });

            // Act
            _toyRobot.ExecuteCommand(new LeftCommand());

            // Assert
            Assert.Equal(ToyRobotChallenge.Enums.Direction.WEST, _toyRobot.ToyRobotCoordinate.Direction);
        }

        [Fact]
        public void ToyRobotTest_ReturnsEastDirection_WhenRobotIsTurnedRightFacingNorth()
        {
            // Arrange
            _toyRobot = new ToyRobot(new ToyRobotCoordinate() { Direction = ToyRobotChallenge.Enums.Direction.NORTH });

            // Act
            _toyRobot.ExecuteCommand(new RightCommand());

            // Assert
            Assert.Equal(ToyRobotChallenge.Enums.Direction.EAST, _toyRobot.ToyRobotCoordinate.Direction);
        }

        [Fact]
        public void ToyRobotTest_ReturnsNorthDirection_WhenRobotIsTurnedLeftFacingEast()
        {
            // Arrange
            _toyRobot = new ToyRobot(new ToyRobotCoordinate() { Direction = ToyRobotChallenge.Enums.Direction.EAST });

            // Act
            _toyRobot.ExecuteCommand(new LeftCommand());

            // Assert
            Assert.Equal(ToyRobotChallenge.Enums.Direction.NORTH, _toyRobot.ToyRobotCoordinate.Direction);
        }

        [Fact]
        public void ToyRobotTest_ReturnsNorthDirection_WhenRobotIsTurnedRightFacingWest()
        {
            // Arrange
            _toyRobot = new ToyRobot(new ToyRobotCoordinate() { Direction = ToyRobotChallenge.Enums.Direction.WEST });

            // Act
            _toyRobot.ExecuteCommand(new RightCommand());

            // Assert
            Assert.Equal(ToyRobotChallenge.Enums.Direction.NORTH, _toyRobot.ToyRobotCoordinate.Direction);
        }
    }
}