
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

    public interface IAccessoryModifier : IModifier
    {
        new List<ListViewItem> ToListViewItems();
    }

    public class Metal : IArmorModifier, IWeaponModifier, IAccessoryModifier
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

        List<ListViewItem> IAccessoryModifier.ToListViewItems()
        {
            return new List<ListViewItem>();
        }
    }

    public class Elemental : IArmorModifier, IWeaponModifier, IAccessoryModifier
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

        List<ListViewItem> IAccessoryModifier.ToListViewItems()
        {
            var collection = new List<ListViewItem>();
            var resistanceItem = new ListViewItem(new[] { Type.ToString(), Resistance.ToString(CultureInfo.InvariantCulture) });
            collection.Add(resistanceItem);
            return collection;
        }
    }

    public class Attribute : IArmorModifier, IWeaponModifier, IAccessoryModifier
    {
        public enum AttributeType
        {
            Might,
            Intellect,
            Personality,
            Speed,
            Accuracy,
            Luck,
            HitPoint,
            SpellPoint,
            ArmorClass,
            Thievery
        }

        public Attribute(string name, int bonus, AttributeType type)
        {
            Name = name;
            Bonus = bonus;
            Type = type;
        }

        public string Name { get; }
        public int Bonus { get; }
        public AttributeType Type { get; }

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
            return CommonListViewItems();
        }

        public int ApplyMinDamage(int baseMinDamage)
        {
            return baseMinDamage;
        }

        public int ApplyMaxDamage(int baseMaxDamage)
        {
            return baseMaxDamage;
        }

        List<ListViewItem> IArmorModifier.ToListViewItems()
        {
            return CommonListViewItems();
        }

        public int ApplyAc(int baseAc)
        {
            if (Type == AttributeType.ArmorClass)
                return baseAc + Bonus;
            return baseAc;
        }

        List<ListViewItem> IModifier.ToListViewItems()
        {
            return CommonListViewItems();
        }

        List<ListViewItem> IAccessoryModifier.ToListViewItems()
        {
            return CommonListViewItems();
        }

        private List<ListViewItem> CommonListViewItems()
        {
            var collection = new List<ListViewItem>();
            var item = new ListViewItem(new[] { Type.ToString(), Bonus.ToString(CultureInfo.InvariantCulture) });
            collection.Add(item);
            return collection;
        }
    }
}
