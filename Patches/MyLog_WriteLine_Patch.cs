using HarmonyLib;
using VRage.Utils;

namespace NoLogging.Patches
{
    [HarmonyPatch(typeof(MyLog), MethodType.Normal)]
    [HarmonyPatch("WriteLine", new[] { typeof(string) }, new[] { ArgumentType.Normal })]
    internal class MyLog_WriteLine_Patch
    {
        private static bool Prefix()
        {
            return false;
        }
    }
}
