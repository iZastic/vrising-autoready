using HarmonyLib;
using ProjectM.UI;
using UnityEngine;
using UnityEngine.Rendering;

namespace AutoReady;

[HarmonyPatch]
internal static class ConnectingView_Patch
{
    [HarmonyPostfix]
    [HarmonyPatch(typeof(ConnectingView), nameof(ConnectingView.Update))]
    private static void Update(ConnectingView __instance)
    {
        Plugin.Logger.LogMessage("Trying to skip");
        if (__instance._Ready)
            __instance.BackgroundButton_OnClick();
    }
}
