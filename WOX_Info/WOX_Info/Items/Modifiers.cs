using System;

namespace WOX_Info.Items
{
    public interface IModifier
    {
        string Name { get; }
    }

    public interface IWeaponModifier : IModifier
    {
        void Apply();
    }

    public interface IArmorModifier : IModifier
    {
        Armor Apply(Armor armor);
    }

    public interface IMiscellaneousModifier : IModifier
    {
        void Apply();
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

        void IWeaponModifier.Apply()
        {
            throw new NotImplementedException();
        }

        Armor IArmorModifier.Apply(Armor armor)
        {
            var newArmor = new Armor(armor)
            {
                Name = Name + " " + armor.Name,
                ArmorClass = armor.ArmorClass + ArmorClass,
                Cost = armor.Cost * CostMultiplier
            };

            return newArmor;
        }
    }
}
