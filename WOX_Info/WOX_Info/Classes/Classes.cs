using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WOX_Info.Classes
{
    [Flags]
    enum ClassType : short
    {
        Archer = 0,
        Barbarian = 1,
        Cleric = 2,
        Druid = 4,
        Knight = 8,
        Ninja = 16,
        Paladin = 32,
        Ranger = 64,
        Robber = 128,
        Sorcerer = 256
    }

    class Classes
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
