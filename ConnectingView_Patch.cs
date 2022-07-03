using HarmonyLib;
using ProjectM.UI;

namespace AutoReady;

[HarmonyPatch]
internal static class ConnectingView_Patch
{
    [HarmonyPostfix]
    [HarmonyPatch(typeof(ConnectingView), nameof(ConnectingView.Update))]
    private static void Update(ConnectingView __instance)
    {
        if (__instance._Ready)
            __instance.BackgroundButton_OnClick();
    }
}
