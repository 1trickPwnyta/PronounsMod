using HarmonyLib;
using Verse;

namespace PronounsMod
{
    public class PronounsModMod : Mod
    {
        public const string PACKAGE_ID = "pronounsmod.1trickPwnyta";
        public const string PACKAGE_NAME = "PronounsMod";

        public PronounsModMod(ModContentPack content) : base(content)
        {
            var harmony = new Harmony(PACKAGE_ID);
            harmony.PatchAll();

            Log.Message($"[{PACKAGE_NAME}] Loaded.");
        }
    }
}
