using System.Collections.Generic;
using WOX_Info.Classes;
using WOX_Info.Items;

namespace WOX_Info
{
    public sealed class ContentDatabase
    {
        public ContentDatabase()
        {
            InitWOXDatabase();
        }

        public List<Classes.Classes> WOXClasses { get; private set; }

        public List<BaseItem> WOXBaseItems { get; private set; }

        public List<IModifier> WOXModifiers { get; private set; }

        private void InitWOXDatabase()
        {
            InitWOXClasses();

            // Init modifiers before the items!
            InitWOXModifiers();
            InitWOXItems();
        }

        private void InitWOXClasses()
        {
            WOXClasses = new List<Classes.Classes>
            {
                new Classes.Classes("Archer", ClassType.Archer),
                new Classes.Classes("Barbarian", ClassType.Barbarian),
                new Classes.Classes("Cleric", ClassType.Cleric),
                new Classes.Classes("Druid", ClassType.Druid),
                new Classes.Classes("Knight", ClassType.Knight),
                new Classes.Classes("Ninja", ClassType.Ninja),
                new Classes.Classes("Paladin", ClassType.Paladin),
                new Classes.Classes("Ranger", ClassType.Ranger),
                new Classes.Classes("Robber", ClassType.Robber),
                new Classes.Classes("Sorcerer", ClassType.Sorcerer)
            };
        }

        private void InitWOXItems()
        {
            WOXBaseItems = new List<BaseItem>();
            InitWOXArmors();
            InitWOXWeapons();
            InitWOXAccessories();
        }

        private void InitWOXArmors()
        {
            var armors = new List<Armor>
            {
                new Armor("Robes", 1, 150, ClassType.All),
                new Armor("Scale Mail", 4, 100, ClassType.All ^ (ClassType.Sorcerer | ClassType.Druid)),
                new Armor("Ring Mail", 5, 200, ClassType.All ^ (ClassType.Sorcerer | ClassType.Druid | ClassType.Barbarian)),
                new Armor("Chain Mail", 6, 400, ClassType.All ^ (ClassType.Sorcerer | ClassType.Druid | ClassType.Barbarian | ClassType.Ninja)),
                new Armor("Splint Mail", 7, 600, ClassType.All ^ (ClassType.Sorcerer | ClassType.Druid | ClassType.Barbarian | ClassType.Ninja | ClassType.Archer | ClassType.Robber)),
                new Armor("Plate Mail", 8, 1000, ClassType.Paladin | ClassType.Knight),
                new Armor("Plate Armor", 10, 2000, ClassType.Paladin | ClassType.Knight),
                new Armor("Cloak", 1, 250, ClassType.All),
                new Armor("Cape", 1, 200, ClassType.All),
                new Armor("Shield", 4, 100, ClassType.All ^ (ClassType.Druid | ClassType.Ninja | ClassType.Sorcerer | ClassType.Archer)),
                new Armor("Helm", 2, 60, ClassType.All),
                new Armor("Gauntlet", 1, 100, ClassType.All),
                new Armor("Boots", 1, 40, ClassType.All),
                new Armor("Belt", 0, 100, ClassType.All)
            };
            WOXBaseItems.AddRange(armors);

            foreach (var modifier in WOXModifiers)
            {
                foreach (var baseArmor in armors)
                {
                    var newArmor = new Armor(baseArmor) {Modifier = modifier};
                    WOXBaseItems.Add(newArmor);
                }
            }
        }

        private void InitWOXWeapons()
        {
            var noClDrNS = ClassType.All ^ (ClassType.Cleric | ClassType.Druid | ClassType.Ninja | ClassType.Sorcerer);
            var weapons = new List<Weapon>
            {
                new Weapon("Long Sword", new DiceType(3, 3), 50, EquipType.Onehand, noClDrNS),
                new Weapon("Short Sword", new DiceType(2, 3), 15, EquipType.Onehand, noClDrNS),
                new Weapon("Broad Sword", new DiceType(3, 4), 100, EquipType.Onehand, noClDrNS),
                new Weapon("Scimitar", new DiceType(2, 5), 80, EquipType.Onehand, noClDrNS),
                new Weapon("Cutlass", new DiceType(2, 4), 40, EquipType.Onehand, noClDrNS),
                new Weapon("Sabre", new DiceType(4, 2), 60, EquipType.Onehand, noClDrNS),
                new Weapon("Club", new DiceType(1, 3), 1, EquipType.Onehand, ClassType.All),
                new Weapon("Hand Axe", new DiceType(2, 3), 10, EquipType.Onehand, ClassType.All ^ (ClassType.Cleric | ClassType.Sorcerer)),
                new Weapon("Katana", new DiceType(4, 3), 150, EquipType.Onehand, ClassType.Knight | ClassType.Ninja),
                new Weapon("Nunchakas", new DiceType(2, 3), 30, EquipType.Onehand, ClassType.Knight | ClassType.Ninja),
                new Weapon("Wakazashi", new DiceType(3, 3), 60, EquipType.Onehand, ClassType.Knight | ClassType.Ninja),
                new Weapon("Dagger", new DiceType(2, 2), 8, EquipType.Onehand, ClassType.All ^ ClassType.Cleric),
                new Weapon("Mace", new DiceType(2, 4), 50, EquipType.Onehand, ClassType.All ^ ClassType.Sorcerer),
                new Weapon("Flail", new DiceType(1, 10), 100, EquipType.Onehand, ClassType.All ^ ClassType.Sorcerer),
                new Weapon("Cudgel", new DiceType(1, 6), 15, EquipType.Onehand, ClassType.All ^ ClassType.Sorcerer),
                new Weapon("Maul", new DiceType(1, 8), 30, EquipType.Onehand, ClassType.All ^ ClassType.Sorcerer),
                new Weapon("Spear", new DiceType(1, 9), 15, EquipType.Onehand, ClassType.All ^ (ClassType.Sorcerer | ClassType.Cleric)),
                new Weapon("Bardiche", new DiceType(4, 4), 200, EquipType.Twohand, ClassType.All ^ (ClassType.Sorcerer | ClassType.Cleric | ClassType.Druid)),
                new Weapon("Glaive", new DiceType(4, 3), 80, EquipType.Twohand, ClassType.All ^ (ClassType.Sorcerer | ClassType.Cleric | ClassType.Druid)),
                new Weapon("Halberd", new DiceType(3, 6), 250, EquipType.Twohand, ClassType.All ^ (ClassType.Sorcerer | ClassType.Cleric | ClassType.Druid)),
                new Weapon("Pike", new DiceType(2, 8), 150, EquipType.Twohand, ClassType.All ^ (ClassType.Sorcerer | ClassType.Cleric | ClassType.Druid)),
                new Weapon("Flamberge", new DiceType(4, 5), 400, EquipType.Twohand, ClassType.All ^ (ClassType.Sorcerer | ClassType.Cleric | ClassType.Druid | ClassType.Ninja | ClassType.Barbarian | ClassType.Robber)),
                new Weapon("Trident", new DiceType(2, 6), 100, EquipType.Twohand, ClassType.All ^ (ClassType.Sorcerer | ClassType.Cleric | ClassType.Druid)),
                new Weapon("Staff", new DiceType(2, 4), 40, EquipType.Twohand, ClassType.All),
                new Weapon("Hammer", new DiceType(2, 5), 120, EquipType.Twohand, ClassType.All ^ ClassType.Sorcerer),
                new Weapon("Naginata", new DiceType(5, 3), 300, EquipType.Twohand, ClassType.Knight | ClassType.Ninja),
                new Weapon("Battle Axe", new DiceType(3, 5), 100, EquipType.Twohand, noClDrNS),
                new Weapon("Grand Axe", new DiceType(3, 6), 200, EquipType.Twohand, noClDrNS),
                new Weapon("Great Axe", new DiceType(3, 7), 100, EquipType.Twohand, noClDrNS),
                new Weapon("Short Bow", new DiceType(3, 2), 25, EquipType.OneHandMissile, ClassType.All ^ (ClassType.Cleric | ClassType.Sorcerer | ClassType.Druid)),
                new Weapon("Long Bow", new DiceType(5, 2), 100, EquipType.OneHandMissile, ClassType.All ^ (ClassType.Cleric | ClassType.Sorcerer | ClassType.Druid)),
                new Weapon("Crossbow", new DiceType(4, 2), 50, EquipType.OneHandMissile, ClassType.All ^ (ClassType.Cleric | ClassType.Sorcerer | ClassType.Druid)),
                new Weapon("Sling", new DiceType(2, 2), 15, EquipType.OneHandMissile, ClassType.All ^ (ClassType.Cleric | ClassType.Sorcerer | ClassType.Druid))
            };
            WOXBaseItems.AddRange(weapons);

            foreach (var modifier in WOXModifiers)
            {
                foreach (var baseWeapon in weapons)
                {
                    var newWeapon = new Weapon(baseWeapon) { Modifier = modifier };
                    WOXBaseItems.Add(newWeapon);
                }
            }

            var xeenSlayerSword = new Weapon("Xeen Slayer Sword", new DiceType(6, 4), 1, EquipType.Twohand, ClassType.All);
            WOXBaseItems.Add(xeenSlayerSword);
        }

        private void InitWOXModifiers()
        {
            WOXModifiers = new List<IModifier>();
            InitWOXMetalsModifiers();
            InitWOXElementalModifiers();
            InitWOXAttributeModifiers();
        }

        private void InitWOXMetalsModifiers()
        {
            var metals = new List<Metal>
            {
                new Metal("Wooden", -3, -3, -3, 0.1, Metal.MetalType.Common),
                new Metal("Leather", -4, -6, 0, 0.25, Metal.MetalType.Common),
                new Metal("Brass", 3, -4, -2, 0.5, Metal.MetalType.Common),
                new Metal("Bronze", 2, -2, -1, 0.75, Metal.MetalType.Common),
                new Metal("Iron", 1, 2, 1, 2, Metal.MetalType.Common),
                new Metal("Silver", 2, 4, 2, 5, Metal.MetalType.Common),
                new Metal("Steel", 3, 6, 4, 10, Metal.MetalType.Common),
                new Metal("Gold", 4, 8, 6, 20, Metal.MetalType.Common),
                new Metal("Platinum", 6, 10, 8, 50, Metal.MetalType.Common),
                new Metal("Glass", 0, 0, 0, 2, Metal.MetalType.Rare),
                new Metal("Coral", 1, 1, 1, 3, Metal.MetalType.Rare),
                new Metal("Crystal", 1, 1, 1, 5, Metal.MetalType.Rare),
                new Metal("Lapis", 2, 2, 2, 10, Metal.MetalType.Rare),
                new Metal("Pearl", 2, 2, 2, 20, Metal.MetalType.Rare),
                new Metal("Amber", 3, 3, 3, 30, Metal.MetalType.Rare),
                new Metal("Ebony", 4, 4, 4, 40, Metal.MetalType.Rare),
                new Metal("Quartz", 5, 5, 5, 50, Metal.MetalType.Rare),
                new Metal("Ruby", 6, 12, 10, 60, Metal.MetalType.Precious),
                new Metal("Emerald", 7, 15, 12, 70, Metal.MetalType.Precious),
                new Metal("Sapphire", 8, 20, 14, 80, Metal.MetalType.Precious),
                new Metal("Diamond", 9, 30, 16, 90, Metal.MetalType.Precious),
                new Metal("Obsidian", 10, 50, 20, 100, Metal.MetalType.Precious)
            };
            WOXModifiers.AddRange(metals);
        }

        private void InitWOXElementalModifiers()
        {
            var elements = new List<Elemental>
            {
                new Elemental("Burning", 5, 2, Elemental.ElementType.Fire),
                new Elemental("Fiery", 7, 3, Elemental.ElementType.Fire),
                new Elemental("Pyric", 9, 4, Elemental.ElementType.Fire),
                new Elemental("Fuming", 12, 5, Elemental.ElementType.Fire),
                new Elemental("Flaming", 15, 10, Elemental.ElementType.Fire),
                new Elemental("Seething", 20, 15, Elemental.ElementType.Fire),
                new Elemental("Blazing", 25, 20, Elemental.ElementType.Fire),
                new Elemental("Scorching", 30, 30, Elemental.ElementType.Fire),
                new Elemental("Flickering", 5, 2, Elemental.ElementType.Electric),
                new Elemental("Sparking", 7, 3, Elemental.ElementType.Electric),
                new Elemental("Static", 9, 4, Elemental.ElementType.Electric),
                new Elemental("Flashing", 12, 5, Elemental.ElementType.Electric),
                new Elemental("Shocking", 15, 10, Elemental.ElementType.Electric),
                new Elemental("Electric", 20, 15, Elemental.ElementType.Electric),
                new Elemental("Dyna", 25, 20, Elemental.ElementType.Electric),
                new Elemental("Icy", 5, 2, Elemental.ElementType.Cold),
                new Elemental("Frost", 10, 4, Elemental.ElementType.Cold),
                new Elemental("Freezing", 15, 5, Elemental.ElementType.Cold),
                new Elemental("Cold", 20, 10, Elemental.ElementType.Cold),
                new Elemental("Cryo", 25, 20, Elemental.ElementType.Cold),
                new Elemental("Acidic", 10, 2, Elemental.ElementType.AcidPoison),
                new Elemental("Venomous", 15, 4, Elemental.ElementType.AcidPoison),
                new Elemental("Poisonous", 20, 8, Elemental.ElementType.AcidPoison),
                new Elemental("Toxic", 25, 16, Elemental.ElementType.AcidPoison),
                new Elemental("Noxious", 40, 32, Elemental.ElementType.AcidPoison),
                new Elemental("Glowing", 5, 2, Elemental.ElementType.Energy),
                new Elemental("Incandescent", 7, 3, Elemental.ElementType.Energy),
                new Elemental("Dense", 9, 4, Elemental.ElementType.Energy),
                new Elemental("Sonic", 11, 5, Elemental.ElementType.Energy),
                new Elemental("Power", 13, 10, Elemental.ElementType.Energy),
                new Elemental("Thermal", 15, 15, Elemental.ElementType.Energy),
                new Elemental("Radiating", 20, 20, Elemental.ElementType.Energy),
                new Elemental("Kinetic", 25, 30, Elemental.ElementType.Energy),
                new Elemental("Mystic", 5, 5, Elemental.ElementType.Magic),
                new Elemental("Magical", 10, 10, Elemental.ElementType.Magic),
                new Elemental("Ectoplasmic", 20, 25, Elemental.ElementType.Magic)
            };
            WOXModifiers.AddRange(elements);
        }

        private void InitWOXAttributeModifiers()
        {
            var attributes = new List<Attribute>
            {
                new Attribute("Might", 2, Attribute.AttributeType.Might),
                new Attribute("Strenght", 3, Attribute.AttributeType.Might),
                new Attribute("Warrior", 5, Attribute.AttributeType.Might),
                new Attribute("Ogre", 8, Attribute.AttributeType.Might),
                new Attribute("Giant", 12, Attribute.AttributeType.Might),
                new Attribute("Thunder", 17, Attribute.AttributeType.Might),
                new Attribute("Force", 23, Attribute.AttributeType.Might),
                new Attribute("Power", 30, Attribute.AttributeType.Might),
                new Attribute("Dragon", 38, Attribute.AttributeType.Might),
                new Attribute("Photon", 47, Attribute.AttributeType.Might),
                new Attribute("Clever", 2, Attribute.AttributeType.Intellect),
                new Attribute("Mind", 3, Attribute.AttributeType.Intellect),
                new Attribute("Sage", 5, Attribute.AttributeType.Intellect),
                new Attribute("Thought", 8, Attribute.AttributeType.Intellect),
                new Attribute("Knowledge", 12, Attribute.AttributeType.Intellect),
                new Attribute("Intellect", 17, Attribute.AttributeType.Intellect),
                new Attribute("Wisdom", 23, Attribute.AttributeType.Intellect),
                new Attribute("Genius", 30, Attribute.AttributeType.Intellect),
                new Attribute("Buddy", 2, Attribute.AttributeType.Personality),
                new Attribute("Friendship", 3, Attribute.AttributeType.Personality),
                new Attribute("Charm", 5, Attribute.AttributeType.Personality),
                new Attribute("Personality", 8, Attribute.AttributeType.Personality),
                new Attribute("Charisma", 12, Attribute.AttributeType.Personality),
                new Attribute("Leadership", 17, Attribute.AttributeType.Personality),
                new Attribute("Ego", 23, Attribute.AttributeType.Personality),
                new Attribute("Holy", 30, Attribute.AttributeType.Personality),
                new Attribute("Quick", 2, Attribute.AttributeType.Speed),
                new Attribute("Swift", 3, Attribute.AttributeType.Speed),
                new Attribute("Fast", 5, Attribute.AttributeType.Speed),
                new Attribute("Rapid", 8, Attribute.AttributeType.Speed),
                new Attribute("Speed", 12, Attribute.AttributeType.Speed),
                new Attribute("Wind", 17, Attribute.AttributeType.Speed),
                new Attribute("Accelerator", 23, Attribute.AttributeType.Speed),
                new Attribute("Velocity", 30, Attribute.AttributeType.Speed),
                new Attribute("Sharp", 3, Attribute.AttributeType.Accuracy),
                new Attribute("Accurate", 5, Attribute.AttributeType.Accuracy),
                new Attribute("Marskman", 10, Attribute.AttributeType.Accuracy),
                new Attribute("Precision", 15, Attribute.AttributeType.Accuracy),
                new Attribute("True", 20, Attribute.AttributeType.Accuracy),
                new Attribute("Exacto", 30, Attribute.AttributeType.Accuracy),
                new Attribute("Clover", 5, Attribute.AttributeType.Luck),
                new Attribute("Chance", 10, Attribute.AttributeType.Luck),
                new Attribute("Winner", 15, Attribute.AttributeType.Luck),
                new Attribute("Luck", 20, Attribute.AttributeType.Luck),
                new Attribute("Gamblers", 25, Attribute.AttributeType.Luck),
                new Attribute("Leprechauns", 30, Attribute.AttributeType.Luck),
                new Attribute("Vigor", 4, Attribute.AttributeType.HitPoint),
                new Attribute("Health", 6, Attribute.AttributeType.HitPoint),
                new Attribute("Life", 10, Attribute.AttributeType.HitPoint),
                new Attribute("Troll", 20, Attribute.AttributeType.HitPoint),
                new Attribute("Vampiric", 50, Attribute.AttributeType.HitPoint),
                new Attribute("Spell", 4, Attribute.AttributeType.SpellPoint),
                new Attribute("Castors", 8, Attribute.AttributeType.SpellPoint),
                new Attribute("Witch", 12, Attribute.AttributeType.SpellPoint),
                new Attribute("Mage", 16, Attribute.AttributeType.SpellPoint),
                new Attribute("Archmage", 20, Attribute.AttributeType.SpellPoint),
                new Attribute("Arcane", 25, Attribute.AttributeType.SpellPoint),
                new Attribute("Protection", 2, Attribute.AttributeType.ArmorClass),
                new Attribute("Armored", 4, Attribute.AttributeType.ArmorClass),
                new Attribute("Defender", 6, Attribute.AttributeType.ArmorClass),
                new Attribute("Stealth", 10, Attribute.AttributeType.ArmorClass),
                new Attribute("Divine", 16, Attribute.AttributeType.ArmorClass),
                new Attribute("Mugger", 4, Attribute.AttributeType.Thievery),
                new Attribute("Burglar", 6, Attribute.AttributeType.Thievery),
                new Attribute("Looter", 8, Attribute.AttributeType.Thievery),
                new Attribute("Brigand", 10, Attribute.AttributeType.Thievery),
                new Attribute("Filch", 12, Attribute.AttributeType.Thievery),
                new Attribute("Thief", 14, Attribute.AttributeType.Thievery),
                new Attribute("Rogue", 16, Attribute.AttributeType.Thievery),
                new Attribute("Plunderer", 18, Attribute.AttributeType.Thievery),
                new Attribute("Criminal", 20, Attribute.AttributeType.Thievery),
                new Attribute("Pirate", 25, Attribute.AttributeType.Thievery),
            };
            WOXModifiers.AddRange(attributes);
        }

        private void InitWOXAccessories()
        {
            var accessories = new List<Accessory>
            {
                new Accessory("Broach", 250, 2, ClassType.All),
                new Accessory("Medal", 100, 2, ClassType.All),
                new Accessory("Charm", 50, 2, ClassType.All),
                new Accessory("Cameo", 300, 2, ClassType.All),
                new Accessory("Scarab", 200, 2, ClassType.All),
                new Accessory("Pendant", 500, 1, ClassType.All),
                new Accessory("Necklace", 1000, 1, ClassType.All),
                new Accessory("Amulet", 2000, 1, ClassType.All),
                new Accessory("Ring", 100, 2, ClassType.All),
            };
            WOXBaseItems.AddRange(accessories);

            foreach (var modifier in WOXModifiers)
            {
                foreach (var baseAccessory in accessories)
                {
                    var newAccessory = new Accessory(baseAccessory) { Modifier = modifier };
                    WOXBaseItems.Add(newAccessory);
                }
            }
        }
    }
}
