using HarmonyLib;

namespace StatCardSellPrice
{
    //Universal Components
    [HarmonyPatch(typeof(PLShipComponent), "GetExtraLineLeft")]
    internal class StatLineLeftComponentPatch
    {
        static void Postfix(ref string __result)
        {
            __result = __result + $"{PLLocalize.Localize("Price")}\n";
        }
    }
    [HarmonyPatch(typeof(PLShipComponent), "GetExtraLineRight")]
    internal class StatLineRightComponentPatch
    {
        static void Postfix(PLWare __instance, ref string __result)
        {
            __result = __result + $"{__instance.GetScaledMarketPrice(true)}\n";
        }
    }

    //Universal Items
    [HarmonyPatch(typeof(PLWare), "GetExtraLineLeft")]
    internal class StatLineLeftPawnItemPatch
    {
        static void Postfix(ref string __result)
        {
            __result = __result + $"{PLLocalize.Localize("Price")}\n";
        }
    }
    [HarmonyPatch(typeof(PLWare), "GetExtraLineRight")]
    internal class StatLineRightPawnItemPatch
    {
        static void Postfix(PLWare __instance, ref string __result)
        {
            __result = __result + $"{__instance.GetScaledMarketPrice(true)}\n";
        }
    }

    //Extractor Components
    [HarmonyPatch(typeof(PLExtractor), "GetExtraLineLeft")]
    internal class StatLineLeftExtractorPatch
    {
        static void Postfix(ref string __result)
        {
            __result = __result + $"{PLLocalize.Localize("Price")}\n";
        }
    }
    [HarmonyPatch(typeof(PLExtractor), "GetExtraLineRight")]
    internal class StatLineRightExtractorPatch
    {
        static void Postfix(PLWare __instance, ref string __result)
        {
            __result = __result + $"{__instance.GetScaledMarketPrice(true)}\n";
        }
    }

    //Program Components
    [HarmonyPatch(typeof(PLWarpDriveProgram), "GetExtraLineLeft")]
    internal class StatLineLeftProgramsPatch
    {
        static void Postfix(ref string __result)
        {
            __result = __result + $"{PLLocalize.Localize("Price")}\n";
        }
    }
    [HarmonyPatch(typeof(PLWarpDriveProgram), "GetExtraLineRight")]
    internal class StatLineRightProgramsPatch
    {
        static void Postfix(PLWare __instance, ref string __result)
        {
            __result = __result + $"{__instance.GetScaledMarketPrice(true)}\n";
        }
    }
}
