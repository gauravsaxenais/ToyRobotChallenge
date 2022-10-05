using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyRobotChallenge;
using ToyRobotChallenge.Enums;
using ToyRobotChallenge.Toy;

namespace ToyRobotTest
{
    public class SimulationTest
    {
        private Simulation _simulation;

        [Fact]
        public void SimulationTest_ReturnsNotNullRobot_WhenPlacedInValidLocation()
        {
            // Arrange
            var simulation = new Simulation();
            var testRobot = new ToyRobot(new ToyRobotCoordinate() { Direction = Direction.NORTH, XCoordinate = 0, YCoordinate = 0 });
            
            // Act
            simulation.Place(0, 0, Direction.NORTH);

            // Assert
            Assert.NotNull(simulation._toy);
            Assert.Equal(testRobot.ToyRobotCoordinate.XCoordinate, simulation._toy.ToyRobotCoordinate.XCoordinate);
            Assert.Equal(testRobot.ToyRobotCoordinate.YCoordinate, simulation._toy.ToyRobotCoordinate.YCoordinate);
            Assert.Equal(testRobot.ToyRobotCoordinate.Direction, simulation._toy.ToyRobotCoordinate.Direction);
        }

        [Fact]
        public void SimulationTest_ReturnsNullRobot_WhenPlacedInInValidLocation()
        {
            // Arrange
            var simulation = new Simulation();
            
            // Act
            simulation.Place(6, 0, Direction.NORTH);

            // Assert
            Assert.Null(simulation._toy);
        }
    }
}
