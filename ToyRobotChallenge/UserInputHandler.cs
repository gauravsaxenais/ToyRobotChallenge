using System.Text.RegularExpressions;
using ToyRobotChallenge.Enums;

namespace ToyRobotChallenge
{
    public class UserInputHandler
    {
        private readonly string ErrorMessage = "The inputs in the file are not correctly formatted.";
        private readonly Simulation _simulation;
        public UserInputHandler()
        {
            _simulation = new Simulation();
        }
        public string ProcessCommands(string[] commands)
        {
            bool isPlacedCommand = false;
            var message = string.Empty;
            foreach (string command in commands)
            {
                // if place is first command, process other commands
                if (isPlacedCommand && message != ErrorMessage)
                {
                    message = ProcessCommand(command);
                }
                else if (Regex.IsMatch(command, "[PLACE]"))
                {
                    isPlacedCommand = true;
                    message = ProcessCommand(command);
                }
                if (message == ErrorMessage)
                {
                    break;
                }
                if (!string.IsNullOrWhiteSpace(message))
                {
                    Console.WriteLine(message);
                    message = "";
                }
            }
            return message;
        }

        public string ProcessCommand(string command)
        {
            var message = string.Empty;

            if (Regex.IsMatch(command, "^PLACE"))
            {
                string[] coordinates = command.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (coordinates.Length == 4)
                {
                    bool isValidX = int.TryParse(coordinates[1], out int x);
                    bool isValidY = int.TryParse(coordinates[2], out int y);
                    var isValidDirection = Enum.TryParse(coordinates[3], out Direction direction);

                    if (isValidX && isValidY && isValidDirection)
                    {
                        _simulation.Place(x, y, direction);
                    }
                }
                if (_simulation._toy == null)
                {
                    message = ErrorMessage;
                }
            }
            else if (Regex.IsMatch(command, "^MOVE"))
            {
                _simulation.PerformCommand(CommandType.Move);
            }
            else if (Regex.IsMatch(command, "^RIGHT"))
            {
                _simulation.PerformCommand(CommandType.Right);
            }
            else if (Regex.IsMatch(command, "^LEFT"))
            {
                _simulation.PerformCommand(CommandType.Left);
            }
            else if (Regex.IsMatch(command, "^REPORT"))
            {
                message = _simulation.Report();
            }
            else
            {
                message = ErrorMessage;
            }

            return message;
        }
    }
}
