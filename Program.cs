using System.Collections;

namespace MarioBrothersEmulator
{
    class Program
    {
        static void Main(string[] args)
        {
            const int worldWidth = 250;
            const int worldHeight = 25;
            const int viewWidth = 50;

            World world = new World(worldWidth, worldHeight);
            Player player = new Player(0, worldHeight -2);

            int playerPosX = player.PositionX;

            while(true)
            {
                world.Draw(player.PositionX,viewWidth, player);
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                switch(keyInfo.Key)
                {
                    case ConsoleKey.RightArrow:
                        player.Move(1);
                        playerPosX = player.PositionX;

                        if(playerPosX > (viewWidth/2) && playerPosX < worldWidth - (viewWidth/2))
                        {
                            playerPosX++;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        player.Move(-1);
                        playerPosX = player.PositionX;
                        break;
                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}