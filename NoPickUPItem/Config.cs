using Exiled.API.Interfaces;
using PlayerRoles;
using System.Collections.Generic;
using System.ComponentModel;

namespace NoPickUPItem;

public class Config : IConfig
{
    public bool IsEnabled { get; set; } = true;

    public bool Debug { get; set; }

    [Description("Message that appears when the player wants to take an item")]
    public bool ShowHint { get; set; } = false;

    [Description("Message that appears when the player wants to take an item")]
    public string HintMessage { get; set; } = "<size=18><b>You can't take this item</size></b>";

    [Description("Duration of the message displayed")]
    public float HintDuration { get; set; } = 4f;

    [Description("The role that cannot take the item or items that were chosen")]
    public List<ItemType> NoPickUpItem { get; set; } =
    [
        ItemType.Jailbird,
        ItemType.MicroHID,
        ItemType.ParticleDisruptor,
        ItemType.KeycardO5
    ];

    public List<RoleTypeId> DeniedRoles { get; set; } =
    [
        RoleTypeId.Scp3114
    ];
}