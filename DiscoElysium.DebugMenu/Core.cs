using HarmonyLib;
using Il2CppSunshine;
using MelonLoader;

[assembly: MelonInfo(typeof(DiscoElysium.DebugMenu.Core), "DiscoElysium.DebugMenu", "1.0.0", "kolbasa99", "https://github.com/kolbasa99/DiscoElysium.DebugMenu")]
[assembly: MelonGame("ZAUM Studio", "Disco Elysium")]

namespace DiscoElysium.DebugMenu
{
    public class Core : MelonMod
    {
    }

    [HarmonyPatch(typeof(DebugModes), nameof(DebugModes.Awake))]
    internal static class DebugModes_Awake_Patch
    {
        private static void Postfix()
        {
            DebugModes.CurrentMode = DebugMode.DemoMode;
        }
    }
}