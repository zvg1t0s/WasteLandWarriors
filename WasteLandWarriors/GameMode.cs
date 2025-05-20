using SampSharp.GameMode;
using SampSharp.GameMode.Events;
using SampSharp.GameMode.World;
using System;
using WasteLandWarriors.Others;
using WasteLandWarriors.WorldObjects;

namespace WasteLandWarriors
{
    public class GameMode : BaseMode
    {
        WorldPickUps PickUps;
        WorldActors Actors;
        
        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);
            
            Console.WriteLine("\n----------------------------------");
            Console.WriteLine(" Blank game mode by your name here");
            Console.WriteLine("----------------------------------\n");

            SetGameModeText("Blank game mode");
            PickUps = new WorldPickUps();
            Actors = new WorldActors();
            WorldMappingObjects.Create();
            Loot.Create();
            // TODO: Put logic to initialize your game mode here
        }
        protected override void OnPlayerPickUpPickup(BasePlayer player, PickUpPickupEventArgs e)
        {
            PickUps.OnPickUp(player, e);
        }

    }
}