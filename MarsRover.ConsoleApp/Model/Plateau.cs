namespace MarsRover.ConsoleApp.Model
{
    public class Plateau
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public int Min_Width { get; set; }
        public int Min_Height { get; set; }
        public Plateau(int width, int height)
        {
            Min_Height = 0;
            Min_Width = 0;
            this.Width = width;
            this.Height = height;
        }
        public Plateau()
        {
            Min_Height = 0;
            Min_Width = 0;
            this.Width = 0;
            this.Height = 0;
        }
    }
}
