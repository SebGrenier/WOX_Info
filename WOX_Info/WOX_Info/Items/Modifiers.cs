
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace WOX_Info.Items
{
    public interface IModifier
    {
        string Name { get; }

        string ApplyName(string baseName);

        double ApplyCost(double baseCost);

        List<ListViewItem> ToListViewItems();
    }

    public interface IWeaponModifier : IModifier
    {
        int ApplyMinDamage(int baseMinDamage);
        int ApplyMaxDamage(int baseMaxDamage);
        new List<ListViewItem> ToListViewItems();
    }

    public interface IArmorModifier : IModifier
    {
        int ApplyAc(int baseAc);
        new List<ListViewItem> ToListViewItems();
    }

    public interface IMiscellaneousModifier : IModifier
    {
    }

    public class Metal : IArmorModifier, IWeaponModifier
    {
        public enum MetalType
        {
            Common,
            Rare,
            Precious
        }

        public string Name { get; }
        public int ToHit { get; }
        public int Damage { get; }
        public int ArmorClass { get; }
        public double CostMultiplier { get; }
        public MetalType Type { get; }

        public Metal(string name, int toHit, int damage, int ac, double costmod, MetalType type)
        {
            Name = name;
            ToHit = toHit;
            Damage = damage;
            ArmorClass = ac;
            CostMultiplier = costmod;
            Type = type;
        }

        public string ApplyName(string baseName)
        {
            return Name + " " + baseName;
        }

        public double ApplyCost(double baseCost)
        {
            return baseCost * CostMultiplier;
        }

        public int ApplyAc(int baseAc)
        {
            return baseAc + ArmorClass;
        }
        
        public int ApplyMinDamage(int baseMinDamage)
        {
            return Damage + baseMinDamage;
        }

        public int ApplyMaxDamage(int baseMaxDamage)
        {
            return Damage + baseMaxDamage;
        }

        public List<ListViewItem> ToListViewItems()
        {
            return new List<ListViewItem>();
        }

        List<ListViewItem> IArmorModifier.ToListViewItems()
        {
            // Armor don't have special modifiers to display
            return new List<ListViewItem>();
        }

        List<ListViewItem> IWeaponModifier.ToListViewItems()
        {
            var collection = new List<ListViewItem>();
            var toHit = new ListViewItem(new []{"ToHit", ToHit.ToString(CultureInfo.InvariantCulture)});
            collection.Add(toHit);
            return collection;
        }
    }

    public class Elemental : IArmorModifier, IWeaponModifier, IMiscellaneousModifier
    {
        public enum ElementType
        {
            Fire,
            Electric,
            Cold,
            AcidPoison,
            Energy,
            Magic
        }

        public Elemental(string name, int resistance, int damage, ElementType type)
        {
            Name = name;
            Resistance = resistance;
            Damage = damage;
            Type = type;
        }

        public string Name { get; }
        public int Resistance { get; }
        public int Damage { get; }
        public ElementType Type { get; }

        public string ApplyName(string baseName)
        {
            return $"{Name} {baseName}";
        }

        public double ApplyCost(double baseCost)
        {
            return baseCost;
        }

        List<ListViewItem> IWeaponModifier.ToListViewItems()
        {
            var collection = new List<ListViewItem>();
            var damageItem = new ListViewItem(new[] { Type.ToString(), Damage.ToString(CultureInfo.InvariantCulture) });
            collection.Add(damageItem);
            return collection;
        }

        public int ApplyMinDamage(int baseMinDamage)
        {
            return baseMinDamage + Damage;
        }

        public int ApplyMaxDamage(int baseMaxDamage)
        {
            return baseMaxDamage + Damage;
        }

        List<ListViewItem> IArmorModifier.ToListViewItems()
        {
            var collection = new List<ListViewItem>();
            var resistanceItem = new ListViewItem(new[] { Type.ToString(), Resistance.ToString(CultureInfo.InvariantCulture) });
            collection.Add(resistanceItem);
            return collection;
        }

        public int ApplyAc(int baseAc)
        {
            return baseAc;
        }

        List<ListViewItem> IModifier.ToListViewItems()
        {
            return new List<ListViewItem>();
        }
    }
}
