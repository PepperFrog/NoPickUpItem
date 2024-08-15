using System.Collections.Generic;
using Exiled.API.Interfaces;
using PlayerRoles;

namespace NoPickUPItem;

public class Config : IConfig
{
    public bool IsEnabled { get; set; } = true;
		
    public bool Debug { get; set; }

    public string MessageHint { get; set; } = "<b>The<color=#f7ff00>Scientists</color> cannot take this item</b>";
    public float Duration { get; set; } = 5;
    public bool IsAllowdScientist { get; set; } = true;

    public List<ItemType> NoPickUpitItemTypes { get; set; } = new List<ItemType>() 
    { 
       ItemType.GunCrossvec, ItemType.GunE11SR
    };
    public List<RoleTypeId> RoleTypes { get; set; } = new List<RoleTypeId>() 
    { 
        RoleTypeId.Scientist
    };
}