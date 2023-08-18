using PlayerRoles;
using PluginAPI.Core;
using PluginAPI.Core.Attributes;
using PluginAPI.Enums;

namespace SCPSL_Plugin_Training._3._Less_Basic_Example.ExampleEvent
{
    public class Event
    {
        [PluginEvent(ServerEventType.PlayerHandcuff)]
        public void PlayerChangeRole(Player player, Player target)
        {
            Log.Debug($"{player.Nickname} has handuffed {target.Nickname}");
            
            target.SetRole(RoleTypeId.Tutorial);
        }
    }
}