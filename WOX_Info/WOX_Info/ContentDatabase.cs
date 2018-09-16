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
            InitWOXItems();
            InitWOXModifiers();
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
            };
            WOXBaseItems.AddRange(weapons);
        }

        private void InitWOXModifiers()
        {
            WOXModifiers = new List<IModifier>();
            InitWOXMetalsModifiers();
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
    }
}
