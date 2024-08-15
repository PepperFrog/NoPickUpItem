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
  # Message displayed when the player wants to take the item
  message_hint: '<b>The<color=#f7ff00>Scientists</color> cannot take this item</b>'
  # Duration for showHint
  duration: 5
  # Can the player take the item (if he can't then = false or if he can't = true)
  is_allowd: true
  # Item that cannot be taken
  no_pick_upit_item_types:
  - GunCrossvec
  - GunE11SR
  # The role that cannot take the item or items that were chosen
  role_types:
  - Scientist
  - ClassD
```
# Installation

**[EXILED](https://github.com/ExMod-Team/EXILED) must be installed for this to work.**

Place the "Cassieauto.dll" file in your Plugins folder.
