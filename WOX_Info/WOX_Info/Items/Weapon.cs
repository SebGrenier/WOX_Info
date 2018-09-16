
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
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
            EquipType = equipType;
        }

        public Weapon(Weapon other)
            : base(other)
        {
            DiceType = other.DiceType;
            EquipType = other.EquipType;
        }

        public DiceType DiceType { get; }
        public EquipType EquipType { get; }

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

        public override List<ListViewItem> ToListViewItems()
        {
            var collection = new List<ListViewItem>();

            var minDamageItem = new ListViewItem(new[] { "Min Damage", MinDamage.ToString(CultureInfo.InvariantCulture) });
            collection.Add(minDamageItem);
            var maxDamageItem = new ListViewItem(new[] { "Max Damage", MaxDamage.ToString(CultureInfo.InvariantCulture) });
            collection.Add(maxDamageItem);

            collection.AddRange(base.ToListViewItems());

            if (Modifier is IWeaponModifier weaponModifier) collection.AddRange(weaponModifier.ToListViewItems());

            return collection;
        }
    }
}
