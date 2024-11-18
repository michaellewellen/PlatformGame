using System.Security.Cryptography.X509Certificates;

namespace MarioBrothersEmulator
{
public class World
    {
        private char[,] grid;
        public int Width {get; private set;}
        public int Height {get; private set;}

        public World(int width, int height)
        {
            this.Width = width;
            this.Height = height;
            grid = new char[height, width];

            // initialize the world to be very plain to begin with.
            for (int y = 0; y<height; y++)
            {
                    for (int x = 0; x < width; x ++)
                    {
                        grid[y,x] = ' ';
                    }
            }

            
            // just drawing the ground for now
            for (int x = 0; x < width; x++)
            {
                grid[height-1,x] = (char)('0' + (x % 10));
            }
        }
        public void SetGridCell(int x, int y, char value)
        {
            if(x >=0 && x < Width && y >= 0 && y < Height)
            {
                grid[y,x] = value;
            }
        }
        public void Draw(int PlayerPositionX, int viewWidth, Player player)
        {
            Console.Clear();
            int startColumn = Math.Max(0,PlayerPositionX = (viewWidth/2));
            for(int y = 0; y < Height; y++)
            {
                for (int x = 0; x < startColumn + viewWidth; x ++)
                {
                    if (x < Width)
                    {
                        Console.Write(grid[y,x]);
                    }
                }
                Console.WriteLine();
            }
            player.Draw(this); 
        }
    }
}