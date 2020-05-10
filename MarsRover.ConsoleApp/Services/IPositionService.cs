
using MarsRover.ConsoleApp.Model;

namespace MarsRover.ConsoleApp
{
    public interface IPositionService
    {
        Position StartMoving(Move move);
    }
}
