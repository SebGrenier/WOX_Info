using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WOX_Info.Classes;

namespace WOX_Info.Items
{
    class BaseItem
    {
        public string Name { get; set; }
        public double Cost { get; set; }
        public ClassType AllowedClasses { get; set; }

        public BaseItem(string name, double cost, ClassType allowed_classes)
        {
            Name = name;
            Cost = cost;
            AllowedClasses = allowed_classes;
        }

        public BaseItem(BaseItem bi)
        {
            Name = string.Copy(bi.Name);
            Cost = bi.Cost;
            AllowedClasses = bi.AllowedClasses;
        }
    }

    class Armor : BaseItem
    {
        public int ArmorClass { get; set; }

        public Armor(string name, int armor_class, double cost, ClassType allowed_classes)
            : base(name, cost, allowed_classes)
        {
            ArmorClass = armor_class;
        }

        public Armor(Armor armor)
            : base(armor)
        {
            ArmorClass = armor.ArmorClass;
        }
    }
}
