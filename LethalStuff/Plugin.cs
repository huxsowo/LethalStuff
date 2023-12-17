using System;
using BepInEx;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;
using BepInEx.Logging;

namespace LethalStuff
{
    [BepInPlugin(modGUID, modName, modVersion)]
    public class LethalStuffMain : BaseUnityPlugin
    {
        private const string modGUID = "Roadhouse.LethalStuff";
        private const string modName = "Lethal Stuff";
        private const string modVersion = "1.0.0";

        private readonly Harmony harmony = new Harmony(modGUID);

        private static LethalStuffMain Instance;

        internal ManualLogSource mls;

        void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }

            mls = BepInEx.Logging.Logger.CreateLogSource(modGUID);

            mls.LogInfo("FEBO IS FATTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT");

            harmony.PatchAll(typeof(LethalStuffMain));
        }
    }
}
