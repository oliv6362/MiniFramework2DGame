

using GameClassLibrary;
using GameClassLibraryFramework.Config;

Console.WriteLine("Hello, World!");


GameConfig gameConfig = new GameConfig();
gameConfig.LoadConfig();

World world = new World(gameConfig.MaxY, gameConfig.MaxX);


