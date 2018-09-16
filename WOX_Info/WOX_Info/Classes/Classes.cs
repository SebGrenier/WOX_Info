using System;

namespace WOX_Info.Classes
{
    [Flags]
    public enum ClassType : short
    {
        None = 0,
        Archer = 0x1,
        Barbarian = 0x2,
        Cleric = 0x4,
        Druid = 0x8,
        Knight = 0x10,
        Ninja = 0x20,
        Paladin = 0x40,
        Ranger = 0x80,
        Robber = 0x100,
        Sorcerer = 0x200,
        All = Archer | Barbarian | Cleric | Druid | Knight | Ninja | Paladin | Ranger | Robber | Sorcerer
    }

    public class Classes
    {
        public string Name { get; set; }
        public ClassType Type { get; set; }

        public Classes(string name, ClassType type)
        {
            Name = name;
            Type = type;
        }
    }
}
