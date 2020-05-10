using System.Collections.Generic;

namespace MarsRover.ConsoleApp.Model
{
    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Directions Direction { get; set; }
        public Position(int x, int y, Directions directions)
        {
            this.X = x;
            this.Y = y;
            this.Direction = directions;
        }
        public Position()
        {
            this.X = 0;
            this.Y = 0;
            this.Direction = Directions.N;

        }

    }
}
