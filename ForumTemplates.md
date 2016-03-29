# Forum Template and Generation #

## Summary ##

Procurement uses a file ForumExportTemplate.txt located in the same folder as the executable. The tool will search for keywords, and replace them with item(s) matching the criteria defined for the keyword. The definitions are listed below.

This allows the user complete control over how the template will be generated, and what will be contained within it. Custom images, specifying indexer specific buyout formats in the spoilers etc.

## Keywords ##

  * **{DropOnlyGems}** - This ones from the wiki(http://pathofexile.gamepedia.com/Drop_Only_Gems). This will exclude quality drop only gems
  * **{IGN}** - IGN of your favorite character in settings
  * **{LastUpdated}** - Current date time. Format is "July 02, 2013 09:35 AM"
  * **{MagicFind}** - Any item with rarity, quantity or both stats will be included
  * **{PopularGems}** - This is based on the Popular Gems list in settings.xml
  * **{QualityXGems}** - Quality gems, where X = 1-20
  * **{LeveledGems}** - Any gems that are level 2 or higher
  * **{DualRes}** - Any item with 2 explicit resist stats
  * **{TripRes}** - Any item with 3 or more explicit resist stats
  * **{Uniques}** - Any unique items
  * **{NormalGear}** - Any normal or white gear
  * **{LvlMaps}** - The keyword currently accepts a value for Lvl between 66 - 100. Some examples would be: {66Maps}, {67Maps}, {68Maps}.
  * **{Stash:Name}** - The keyword will export an entire stash by name. This feature was requested. Some Examples would be {Stash:Uniques}, {Stash:Highlights}. If you have non premium tabs, the format should be {Stash:1}, {Stash:2} etc
  * **{OneHanders}** - All one handed weapons
  * **{TwoHanders}** - All two handed weapons
  * **{Buyouts}** - All items with a buyout set, in spoilers as per the indexers format rules. Buyouts set by right clicking an item, set buyout
  * **{4Link}** - All items with exactly 4 links.
  * **{5Link}** - All items with exactly 5 links.
  * **{6Link}** - All items with exactly 6 links.
  * **{6Socket}** - All items with exactly 6 sockets
  * **{Life}** - All items with +to maximum Life
  * **{LifeRegen}** - All items with Life Regenerated per second
  * **{CritChance}** - All items with crit chance
  * **{GlobalCritChance}** - All items with global crit chance
  * **{GlobalCritMultiplier}** - All items with global crit multiplier
  * **{SpellDamage}** - All items with spell damage
  * **{ManaRegen}** - Items with added mana regen
  * **{QualityXGems}** - Quality gems, where X = 1-20
  * **{PhysicalDamage}** - Items with added physical damage
  * **{IncreasedPhysicalDamage}** - Items with Increased Physical Damage
  * **{EnergyShield}** - Items with increased Energy Shield
  * **{VaalFragments},  {VaalUberFragments}** - Fragments
  * **{CorruptedGems}** - Corrupted Gems




Then, the combinations of the following are valid:

{QualityGearType} where Quality can be: Normal, Magic, Rare, Unique

and GearType can be: Ring, Amulet, Helmet, Chest, Belt, Gloves, Boots, Axe, Claw, Bow, Dagger, Mace, Quiver, Sceptre, Staff, Sword, Shield, Wand, Flask

Some examples: {NormalRing}, {RareChest}, {UniqueBelt}, {NormalFlask}

In Addition, gems can now be filtered by the categories they are listed under. Available categories currently are:
AoE, Attack, Aura, Bow, Cast, Chaining, Chaos, Cold, Curse, Duration, Fire, Lightning, Melee, Mine, Minion, Movement, Projectile, Spell, Totem, Trap and Support. Simple examples are:
  * **{SupportGems}** - All support gems
  * **{AuraGems}** - Aura gems such as Haste or Vitality
  * **{CurseGems}** - Curse gems such as Temporal Chains or Conductivity

Categories can also be combined, but only twice. Examples are:
  * **{ColdSpellGems}** - All cold spell gems
  * **{FireProjectileGems}** - All cold projectile gems

Finally, if you merely want to dump ALL gems regardless of type or level into a spoiler, use {AllGems}