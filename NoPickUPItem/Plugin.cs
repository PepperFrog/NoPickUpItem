using Exiled.API.Features;
using System;

namespace NoPickUPItem;

public class Plugin : Plugin<Config>
{
    public override string Author => "By RomzyyTV";
    public override string Name => "NoPickUPItem";
    public override Version Version => new Version(1, 1,0);
    public override Version RequiredExiledVersion { get; } = new(8, 12, 2);

    public override string Prefix => "nopickup";

    public static EventHandlers Handlers;

    public override void OnEnabled()
    {        
        Handlers = new EventHandlers(Config);

        Exiled.Events.Handlers.Player.SearchingPickup += Handlers.OnPlayerPickUpItem;
        base.OnEnabled();
    }

    public override void OnDisabled()
    {                
        Exiled.Events.Handlers.Player.SearchingPickup -= Handlers.OnPlayerPickUpItem;
        Handlers = null;
        base.OnDisabled();
    }
}