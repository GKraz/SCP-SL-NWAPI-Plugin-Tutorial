using System.Threading.Tasks;
using PluginAPI.Core;
using PluginAPI.Core.Attributes;
using PluginAPI.Enums;
using SCPSL_Plugin_Training._3._Less_Basic_Example.ExampleEvent;

namespace SCPSL_Plugin_Training._3._Less_Basic_Example.ExampleEvents;

public class WarheadExample
{
    private static SubConfig Config => Main.Plugin.MainConfig.SubConfig;
    
    /// <summary>
    /// On the detonation of the warhead each player is given a radiation effect that slowly kills them.
    /// </summary>
    [PluginEvent(ServerEventType.WarheadDetonation)]
    public void WarheadDetonation()
    {
        var playerList = Player.GetPlayers();

        foreach (var player in playerList)
        {
            Radiation(player);
        }
    }

    /// <summary>
    /// Gives an effect to a player that slowly kills them.
    /// </summary>
    /// <param name="player">The player that will be affected.</param>
    private static async void Radiation(Player player)
    {
        player.ReceiveHint("You have been irradiated!", 1000);

        while (player.Health > 0)
        {
            await Task.Delay(Config.Interval * 1000);

            player.Health -= 10;
        }

        player.Kill();
        player.ReceiveHint("", 1);
    }
}