using MarsRover.ConsoleApp.Model;

namespace MarsRover.ConsoleApp
{
    public interface IRoverService
    {
        Position StartMoving(Rover move);
    }
}
