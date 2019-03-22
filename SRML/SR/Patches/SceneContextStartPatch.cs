﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harmony;
namespace SRML.SR.Patches
{
    [HarmonyPatch(typeof(SceneContext))]
    [HarmonyPatch("Start")]
    internal static class SceneContextStartPatch
    {
        static void Postfix(SceneContext __instance)
        {
            SRCallbacks.OnSceneLoaded(__instance);
        }
    }
}