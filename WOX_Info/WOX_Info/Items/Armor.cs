using WOX_Info.Classes;

namespace WOX_Info.Items
{
    public class Armor : BaseItem
    {
        private readonly int _armorClass;

        public Armor(string name, int armorClass, double cost, ClassType allowedClasses)
            : base(name, cost, allowedClasses)
        {
            _armorClass = armorClass;
        }

        public Armor(Armor armor)
            : base(armor)
        {
            _armorClass = armor._armorClass;
        }

        public int ArmorClass
        {
            get
            {
                var armorModifier = Modifier as IArmorModifier;
                return armorModifier?.ApplyAc(_armorClass) ?? _armorClass;
            }
        }
    }
}
