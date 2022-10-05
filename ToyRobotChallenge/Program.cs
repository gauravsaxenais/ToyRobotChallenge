// Automatically executes when application is started.
using ToyRobotChallenge;

if (args == null || args.Length == 0)
{
    Console.WriteLine("Please specify a .txt filepath.");
    return;
}
if (File.Exists(args[0]) && (Path.GetExtension(args[0]) == ".txt"))
{
    string[] commands = File.ReadAllLines(args[0]);

    var inputHandler = new UserInputHandler();
    Console.WriteLine(inputHandler.ProcessCommands(commands));
}
else
{
    Console.WriteLine("Not a .txt file. Please try again.");
    Console.Write(@"The correct command formats are as follows:
PLACE X,Y,DIRECTION
MOVE
RIGHT
LEFT
REPORT
-------------
Please review your input file and try again.");
}