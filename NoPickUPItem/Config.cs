using System.Collections.Generic;
using System.ComponentModel;
using Exiled.API.Interfaces;
using PlayerRoles;

namespace NoPickUPItem;

public class Config : IConfig
{
    public bool IsEnabled { get; set; } = true;
		
    public bool Debug { get; set; }

    [Description("Message displayed when the player wants to take the item")]
    public string MessageHint { get; set; } = "<b>The<color=#f7ff00>Scientists</color> cannot take this item</b>";
    [Description("Duration for showHint")]
    public float Duration { get; set; } = 5;
    [Description("Can the player take the item (if he can't then = false or if he can't = true)")]
    public bool IsAllowd { get; set; } = true;
    
    [Description("Item that cannot be taken")]
    public List<ItemType> NoPickUpitItemTypes { get; set; } = new List<ItemType>() 
    { 
       ItemType.GunCrossvec, ItemType.GunE11SR
    };
    
    [Description("The role that cannot take the item or items that were chosen")]
    public List<RoleTypeId> RoleTypes { get; set; } = new List<RoleTypeId>() 
    { 
        RoleTypeId.Scientist, RoleTypeId.ClassD
    };
}