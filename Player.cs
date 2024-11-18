using System.Dynamic;

namespace MarioBrothersEmulator
{
    public class Player
    {
        public int PositionX{get;private set;}
        public int PositionY{get;private set;}
        private const char Representation = '@';

        public Player(int startX, int startY)
        {
            PositionX = startX;
            PositionY = startY;
        }
        
        public void Move(int deltaX)
        {
            PositionX += deltaX;
        }
        public void Jump()
        {
            // jump logic to follow
        }

        public void Draw(World world)
        {
            if (PositionY >= 0 && PositionY < world.Height && PositionX >= 0 && PositionX < world.Width)
            {
                world.SetGridCell(PositionX, PositionY, ' ');
            }
            if (PositionY >= 0 && PositionY < world.Height && PositionX >= 0 && PositionX < world.Width)
            {
                world.SetGridCell(PositionX, PositionY, Representation);
            }
        }
    }
}