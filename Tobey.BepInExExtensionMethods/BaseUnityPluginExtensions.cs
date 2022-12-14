using System.Linq;

namespace BepInEx
{
    internal static class BaseUnityPluginExtensions
    {
        public static BaseUnityPlugin GetPlugin(this BaseUnityPlugin plugin, string guid) =>
            plugin
                .GetComponents<BaseUnityPlugin>()
                .FirstOrDefault(p => p.Info.Metadata.GUID == guid);
    }
}
