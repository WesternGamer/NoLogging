using HarmonyLib;
using System.Reflection;
using VRage.Plugins;

namespace NoLogging
{
    public class Main : IPlugin
    {
        public void Dispose()
        {

        }

        public void Init(object gameInstance)
        {
            Harmony harmony = new Harmony("NoLogging");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }

        public void Update()
        {

        }
    }
}
