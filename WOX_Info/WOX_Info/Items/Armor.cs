using WOX_Info.Classes;

namespace WOX_Info.Items
{
    public class Armor : BaseItem
    {
        public int ArmorClass { get; set; }

        public Armor(string name, int armorClass, double cost, ClassType allowedClasses)
            : base(name, cost, allowedClasses)
        {
            ArmorClass = armorClass;
        }

        public Armor(Armor armor)
            : base(armor)
        {
            ArmorClass = armor.ArmorClass;
        }
    }
}
