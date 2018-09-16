
namespace WOX_Info.Items
{
    public interface IModifier
    {
        string Name { get; }

        string ApplyName(string baseName);

        double ApplyCost(double baseCost);
    }

    public interface IWeaponModifier : IModifier
    {
        int ApplyMinDamage(int baseMinDamage);
        int ApplyMaxDamage(int baseMaxDamage);
    }

    public interface IArmorModifier : IModifier
    {
        int ApplyAc(int baseAc);
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
    }
}
