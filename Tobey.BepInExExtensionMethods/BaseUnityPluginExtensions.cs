using System.Linq;

namespace BepInEx
{
    internal static class BaseUnityPluginExtensions
    {
        public static BaseUnityPlugin GetPlugin(this BaseUnityPlugin plugin, string guid)
        {
            var result = plugin
                .GetComponents<BaseUnityPlugin>()
                .FirstOrDefault(p => p.Info.Metadata.GUID == guid);

            if (result == null && plugin.gameObject != Bootstrap.Chainloader.ManagerObject)
            {
                result = Bootstrap.Chainloader.ManagerObject
                    .GetComponents<BaseUnityPlugin>()
                    .FirstOrDefault(p => p.Info.Metadata.GUID == guid);
            }

            return result;
        }
    }
}
