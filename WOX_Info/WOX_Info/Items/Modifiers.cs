using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public string Name { get; private set; }
        public int ToHit { get; private set; }
        public int Damage { get; private set; }
        public int ArmorClass { get; private set; }
        public double CostMultiplier { get; private set; }
        public MetalType Type { get; private set; }

        public Metal(string name, int to_hit, int damage, int ac, double costmod, MetalType type)
        {
            Name = name;
            ToHit = to_hit;
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
            Armor new_armor = new Armor(armor);
            new_armor.Name = Name + " " + armor.Name;
            new_armor.ArmorClass = armor.ArmorClass + ArmorClass;
            new_armor.Cost = armor.Cost * CostMultiplier;

            return new_armor;
        }
    }
}
