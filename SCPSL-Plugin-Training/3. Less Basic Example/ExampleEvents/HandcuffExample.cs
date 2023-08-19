using System.Threading.Tasks;
using PlayerRoles;
using PluginAPI.Core;
using PluginAPI.Core.Attributes;
using PluginAPI.Enums;
using SCPSL_Plugin_Training._3._Less_Basic_Example.ExampleEvent;

namespace SCPSL_Plugin_Training._3._Less_Basic_Example.ExampleEvents
{
    public class HandcuffExample
    {
        private static SubConfig Config => Main.MainConfig.SubConfig;

        /// <summary>
        /// When a player is handcuffed the hancuffed player is turned into the spectator role and given a message.
        /// </summary>
        /// <param name="player">The player who hancuffs the other.</param>
        /// <param name="target">The player who is hancuffed.</param>
        [PluginEvent(ServerEventType.PlayerHandcuff)]
        public void PlayerChangeRole(Player player, Player target)
        {
            Log.Debug($"{player.Nickname} has handuffed {target.Nickname}");

            target.SetRole(RoleTypeId.Tutorial);

            target.SendBroadcast(Config.String, 10);
        }
    }
}