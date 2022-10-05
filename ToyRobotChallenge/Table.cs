using ToyRobotChallenge.Toy;

namespace ToyRobotChallenge
{
    public class Table
    {
        public int Rows { get; private set; }
        public int Columns { get; private set; }

        public Table(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
        }

        public bool IsValidPosition(int x, int y)
        {
            ToyRobotCoordinate coordinate = new() { XCoordinate = x, YCoordinate = y };
            return coordinate.XCoordinate < Rows && coordinate.XCoordinate >= 0 &&
                   coordinate.YCoordinate < Columns && coordinate.YCoordinate >= 0;
        }
    }
}