using MarsRover.ConsoleApp.Model;
using System;

namespace MarsRover.ConsoleApp
{
    public class PositionService : IPositionService
    {
        private bool IsMoveAvailable(Plateau plateau, Position position)
        {
            return plateau.Min_Width <= position.X && position.X <= plateau.Width && plateau.Min_Height <= position.Y && position.Y <= plateau.Height;
        }
        private Directions Rotate90Left(Directions directions)
        {

            switch (directions)
            {
                case Directions.N:
                    directions = Directions.W;
                    break;
                case Directions.S:
                    directions = Directions.E;
                    break;
                case Directions.E:
                    directions = Directions.N;
                    break;
                case Directions.W:
                    directions = Directions.S;
                    break;
                default:
                    break;
            }
            return directions;
        }

        private Directions Rotate90Right(Directions directions)
        {
            switch (directions)
            {
                case Directions.N:
                    directions = Directions.E;
                    break;
                case Directions.S:
                    directions = Directions.W;
                    break;
                case Directions.E:
                    directions = Directions.S;
                    break;
                case Directions.W:
                    directions = Directions.N;
                    break;
                default:
                    break;
            }
            return directions;
        }

        private Position MoveInSameDirection(Position position)
        {
            switch (position.Direction)
            {
                case Directions.N:
                    position.Y += 1;
                    break;
                case Directions.S:
                    position.Y -= 1;
                    break;
                case Directions.E:
                    position.X += 1;
                    break;
                case Directions.W:
                    position.X -= 1;
                    break;
                default:
                    break;
            }
            return position;
        }

        public Position StartMoving(Move move)
        {
            foreach (var _move in move.Moves)
            {
                switch (_move)
                {
                    case 'M':
                        move.Position = this.MoveInSameDirection(move.Position);
                        break;
                    case 'L':
                        move.Position.Direction = this.Rotate90Left(move.Position.Direction);
                        break;
                    case 'R':
                        move.Position.Direction = this.Rotate90Right(move.Position.Direction);
                        break;
                    default:
                        Console.WriteLine($"Invalid Character {move}");
                        break;
                }
                if (!this.IsMoveAvailable(move.Plateau, move.Position))
                {
                    Console.WriteLine($"Invalid Character {move}");
                }
            }
            return move.Position;
        }


    }
}
