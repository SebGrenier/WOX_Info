using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WOX_Info.Items
{
    interface IModifier
    {
        string Name { get; }
    }

    interface IWeaponModifier : IModifier
    {
        void Apply();
    }

    interface IArmorModifier : IModifier
    {
        Armor Apply(Armor armor);
    }

    interface IMiscellaneousModifier : IModifier
    {
        void Apply();
    }



    class Metal : IArmorModifier, IWeaponModifier
    {
        public string Name { get; private set; }
        public int ToHit { get; private set; }
        public int Damage { get; private set; }
        public int ArmorClass { get; private set; }
        public double CostMultiplier { get; private set; }

        public Metal(string name, int to_hit, int damage, int ac, double costmod)
        {
            Name = name;
            ToHit = to_hit;
            Damage = damage;
            ArmorClass = ac;
            CostMultiplier = costmod;
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

            return new_armor;
        }
    }


}
