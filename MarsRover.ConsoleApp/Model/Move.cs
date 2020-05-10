namespace MarsRover.ConsoleApp.Model
{
    public class Move
    {
        public Plateau Plateau { get; set; }
        public string Moves { get; set; }
        public Position Position { get; set; }
        public Move()
        {
            this.Position = new Position();
            this.Plateau = new Plateau();
            this.Moves = string.Empty;
        }
    }
}
