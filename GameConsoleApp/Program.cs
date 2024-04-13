using GameClassLibraryFramework.Config;
using GameClassLibraryFramework.Entity;
using GameClassLibraryFramework.FactoryDesignPattern;
using GameClassLibraryFramework.Interfaces;
using GameClassLibraryFramework.Manager;
using GameClassLibraryFramework.TracingAndLogger;
using System.Numerics;

//SOLID Principles


//Design Patterns
//1.GameLogger.cs => Singleton Pattern
//2. WorldObjectFactory.cs, IworldObjectFactory, GameWorldManager => Factory Method Pattern



/// <summary>
/// Example of how to use the game framework.
/// </summary>

/// <summary>
/// Initialize configurations
/// </summary>
IGameConfig gameConfig = new GameConfig();
gameConfig.LoadConfig("(YOUR_XML_FILE_PATH)");

/// <summary>
/// Initialize the game world
/// </summary>
IGameWorld gameWorld = new GameWorld(gameConfig.MaxX, gameConfig.MaxY);

/// <summary>
/// Setup the Game World Manager & Combat Manager
/// </summary>
//GameWorldManager gameWorldManager = new GameWorldManager(gameWorld, gameConfig);
IWorldObjectFactory objectFactory = new WorldObjectFactory();
GameWorldManager gameWorldManager = new GameWorldManager(gameWorld, gameConfig, objectFactory);
CombatManager combatManager = new CombatManager();


Console.WriteLine();

/// <summary>
///  Factory design pattern - worldobjects treasure chest, Shack and Bow
/// </summary>
gameWorldManager.AddWorldObject(1, "Treasure Chest", new Vector2(10, 7), true, false);
gameWorldManager.AddWorldObject(2, "Old shack", new Vector2(6, 8), false, false);
gameWorldManager.AddWorldObject(3, "Strong Bow", new Vector2(1, 9), false, true);


Console.WriteLine();


/// <summary>
///Creating a skeleton creature and adding it to the game world.
/// </summary>
Creature skeleton = new Creature(1, "Skeleton", 75, 75, new Vector2(0, 5));
gameWorldManager.AddCreature(skeleton);

/// <summary>
/// Creating & adding weapons and armors to the skeleton
/// </summary>
IWeapon axe = new Weapon(1, "Fire Sword", 15, 2);
skeleton.AddWeapon(axe);

IArmor helmet = new Armor(1, "Metal helmet", 5);
skeleton.AddArmor(helmet);


Console.WriteLine();

/// <summary>
///´Creating a goblin creature and adding it to the game world.
/// </summary>
Creature goblin = new Creature(2, "Goblin", 50, 50, new Vector2(5, 5));
gameWorldManager.AddCreature(goblin);

/// <summary>
///Creating & adding weapons and armors to the goblin
/// </summary>
IWeapon dagger = new Weapon(1, "Pointy dagger", 10, 1);
goblin.AddWeapon(dagger);

IArmor shield = new Armor(1, "Wooden shield", 4);
goblin.AddArmor(shield);


Console.WriteLine();


// move the Creature to a new position
if (skeleton is IMovable movableSkeleton)
{
    movableSkeleton.Move(new Vector2(3, 5));
    Console.WriteLine($"skeleton moved to new position: {movableSkeleton.Position}");
}

// Move the hero to a new position
if (goblin is IMovable movableGoblin)
{
    movableGoblin.Move(new Vector2(2, 5));
    Console.WriteLine($"Goblin moved to new position: {movableGoblin.Position}");
}


Console.WriteLine();

/// <summary>
/// Start combat between the skeleton and the goblin. The skeleton is the attacker and the goblin is the defender.
/// </summary>
combatManager.Engage(skeleton, goblin);


Console.WriteLine();

/// <summary>
/// Announcer all world objects using LINQ and iterations
/// </summary>
gameWorldManager.DisplayAllWorldObjects();

Console.WriteLine();
