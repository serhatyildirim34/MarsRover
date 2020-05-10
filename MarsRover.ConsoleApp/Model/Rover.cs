namespace MarsRover.ConsoleApp.Model
{
    public class Rover
    {
        public Plateau Plateau { get; set; }
        public string Moves { get; set; }
        public Position Position { get; set; }
        public Rover()
        {
            this.Position = new Position();
            this.Plateau = new Plateau();
            this.Moves = string.Empty;
        }
    }
}
