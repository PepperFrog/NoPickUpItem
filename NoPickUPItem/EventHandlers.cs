using Exiled.Events.EventArgs.Player;

namespace NoPickUPItem;
public class EventHandlers(Config config)
{
    private Config Config { get; set; } = config;

    public void OnPlayerPickUpItem(SearchingPickupEventArgs ev)
    {
        if (ev.Player.Role != null && Config.DeniedRoles.Contains(ev.Player.Role))
        {
            if (ev.Pickup != null && Config.NoPickUpItem.Contains(ev.Pickup.Type))
            {
                ev.IsAllowed = false;
                if (Config.ShowHint)
                {
                    ev.Player.ShowHint(Config.HintMessage, Config.HintDuration);
                }
                
            }
        } 
    }
}