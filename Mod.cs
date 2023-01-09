using Kitchen;
using KitchenLib;
using KitchenLib.Event;
using KitchenMods;
//using IngredientLib;
using System.Reflection;
using Unity.Collections;
using Unity.Entities;
using UnityEngine;
using System.Linq;

// Namespace should have "Kitchen" in the beginning
namespace Kitchenburritos
{
    public class Mod : BaseMod
    {
        // guid must be unique and is recommended to be in reverse domain name notation
        // mod name that is displayed to the player and listed in the mods menu
        // mod version must follow semver e.g. "1.2.3"
        public const string MOD_GUID = "Aj.PlateUp.burritos";
        public const string MOD_NAME = "burritos";
        public const string MOD_VERSION = "0.1.0";
        public const string MOD_AUTHOR = "Aj";
        public const string MOD_GAMEVERSION = ">=1.1.1";
        // Game version this mod is designed for in semver
        // e.g. ">=1.1.1" current and all future
        // e.g. ">=1.1.1 <=1.2.3" for all from/until

        public Mod() : base(MOD_GUID, MOD_NAME, MOD_AUTHOR, MOD_VERSION, MOD_GAMEVERSION, Assembly.GetExecutingAssembly()) { }

        protected override void Initialise()
        {
            base.Initialise();
            // For log file output so the official plateup support staff can identify if/which a mod is being used

        }

        protected void AddGameData()
        {
            //AddGameDataObject<SaltProvider>();
        }
        protected override void OnUpdate()
        {
            
        }

        
    }

}
