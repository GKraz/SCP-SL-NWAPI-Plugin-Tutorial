using PlayerStatsSystem;
using PluginAPI.Core;
using PluginAPI.Core.Attributes;
using PluginAPI.Enums;
using PluginAPI.Events;

namespace SCPSL_Plugin_Training._2._Basic_Example
{
    public class BasicExample
    {
        // The PluginEntryPoint attribute is where NorthWoodAPI looks for the initialization of the plugin.
        // This method is ran when the server starts.
        /// <summary>
        /// Registers the events used and initializes the plugin.
        /// </summary>
        [PluginEntryPoint(pluginName: "BasicExample", pluginVersion: "0.0.0", description: "A basic plugin example", author: "DMFGames")]
        public void EntryPoint()
        {
            // This registers all the events in the ExampleBasic class using a generic type.
            // The argument passed through is the class instance where the PluginEntryPoint attribute is used.
            EventManager.RegisterEvents<BasicExample>(plugin: this);
            
            // The Log class is used to print information to the server console. 
            Log.Info(message: "BasicExample loaded successfully!");
        }

        // The PluginEvent attribute calls the method it is attached to when the specific event happens.
        // In this example, the PlayerDeath method will run when a player dies.
        /// <summary>
        /// Sends a message to the player who died.
        /// </summary>
        /// <param name="player">The player who died.</param>
        /// <param name="attacker">The person who killed the now dead player (unused)</param>
        /// <param name="damageHandler">The damage handler used (unused)</param>
        [PluginEvent(ServerEventType.PlayerDeath)]
        // Some events REQUIRE paramaters to be in the method associated with the event.
        // To check which paramaters are needed go to NwPluginAPI/Events/EventManager.cs in https://github.com/northwood-studios/NwPluginAPI/tree/master
        public void PlayerDeath(Player player, Player attacker, DamageHandlerBase damageHandler)
        {
            // Sends a broadcast (text at the top of the screen) to the player who died.
            player.SendBroadcast(message: "You died loser!", duration: 5);
        }
    }

    
    // This is the same code without the comments and signitures.
    public class BasicExampleNoComments
    {
        [PluginEntryPoint("BasicExample", "0.0.0", "A basic plugin example", "DMFGames")]
        public void EntryPoint()
        {
            EventManager.RegisterEvents<BasicExampleNoComments>(this);
            
            Log.Info("BasicExample loaded successfully!");
        }
        
        
        [PluginEvent(ServerEventType.PlayerDeath)]
        public void PlayerDeath(Player player, Player attacker, DamageHandlerBase damageHandler)
        {
            player.SendBroadcast("You died loser!", 5);
        }
    }
}