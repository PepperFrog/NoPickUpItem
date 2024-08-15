using System;
using Exiled.API.Features;
using Exiled.API.Features.Pickups;
using Exiled.Events.EventArgs.Player;
using Exiled.Permissions;
using PlayerRoles;
using PluginAPI.Core.Attributes;

namespace NoPickUPItem;
public class EventHandlers
{
    public void OnPlayerPickUPItem(PickingUpItemEventArgs ev)
    {
        if (Plugin.Singleton.Config.RoleTypes.Contains(ev.Player.Role.Type))
        {
            if (Plugin.Singleton.Config.NoPickUpitItemTypes.Contains(ev.Pickup.Type)) 
            {
                ev.Player.ShowHint(Plugin.Singleton.Config.MessageHint, Plugin.Singleton.Config.Duration);
                ev.IsAllowed = Plugin.Singleton.Config.IsAllowdScientist;
            }
        }
    }
}