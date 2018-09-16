
using WOX_Info.Classes;

namespace WOX_Info.Items
{
    public enum EquipType
    {
        Onehand,
        Twohand,
        OneHandMissile
    }

    public class DiceType
    {
        public DiceType(int count, int sides)
        {
            Count = count;
            Sides = sides;
        }

        public int Count { get; }
        public int Sides { get; }

        public int MinDamage => Count;
        public int MaxDamage => Count * Sides;
    }

    public class Weapon : BaseItem
    {
        public Weapon(string name, DiceType diceType, double cost, EquipType equipType, ClassType allowedClasses)
            : base(name, cost, allowedClasses)
        {
            DiceType = diceType;
        }

        public DiceType DiceType { get; }

        public int MinDamage
        {
            get
            {
                var weaponModifier = Modifier as IWeaponModifier;
                return weaponModifier?.ApplyMinDamage(DiceType.MinDamage) ?? DiceType.MinDamage;
            }
        }

        public int MaxDamage
        {
            get
            {
                var weaponModifier = Modifier as IWeaponModifier;
                return weaponModifier?.ApplyMaxDamage(DiceType.MaxDamage) ?? DiceType.MaxDamage;
            }
        }
    }
}
