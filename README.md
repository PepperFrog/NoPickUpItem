[![Github All Releases](https://img.shields.io/github/downloads/xRoier/WHLogs/total?color=blueviolet&style=for-the-badge)]()

# No PickUP Item
Makes it so that if a person has a certain role and wants to take a certain item and they are not authorized to take it then they will not be able to take it

# Features
- Make it so that the player cannot take chosen items
- Put on a showhint to inform the player

# Default config:
```yaml
no_pick_u_p_item:
  is_enabled: true
  debug: false
  # Can the player take the item (if he can't then = false or if he can't = true)
  is_allowd: false
  show_hint: '<b>You can''t take this item</b>'
  show_hint_duration: 4
  # The role that cannot take the item or items that were chosen
  no_pick_up_item:
  - GunCrossvec
  denied_roles:
  - Scientist
```
# Installation

**[EXILED](https://github.com/ExMod-Team/EXILED) must be installed for this to work.**

Place the "Cassieauto.dll" file in your Plugins folder.
