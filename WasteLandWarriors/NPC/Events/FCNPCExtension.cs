
using WasteLandWarriors.NPC;
using SampSharp.GameMode;
using SampSharp.GameMode.Controllers;
using System;
using WasteLandWarriors.NPC;

[assembly: SampSharpExtension(typeof(FCNPCExtension))]
namespace WasteLandWarriors.NPC
{
    public partial class FCNPCExtension : Extension, IService
    {
        /// <summary>
        /// Gets the game mode.
        /// </summary>
        public BaseMode GameMode { get; private set; }

        //
        public override void LoadServices(BaseMode gameMode)
        {
            GameMode = gameMode;
            gameMode.Services.AddService(this);
            base.LoadServices(gameMode);
        }

        //
        public override void LoadControllers(BaseMode gameMode, ControllerCollection controllerCollection)
        {
            var type = typeof(FCNPCController);
            var instance = Activator.CreateInstance(type);
            var controller = instance as IController;
            controllerCollection.Add(controller);
            base.LoadControllers(gameMode, controllerCollection);
        }
    }
}