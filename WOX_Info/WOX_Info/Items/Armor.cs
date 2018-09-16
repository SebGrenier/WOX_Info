using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
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

        public override List<ListViewItem> ToListViewItems()
        {
            var collection = new List<ListViewItem>();

            var armorItem = new ListViewItem(new []{"AC", ArmorClass.ToString(CultureInfo.InvariantCulture)});
            collection.Add(armorItem);

            collection.AddRange(base.ToListViewItems());

            if (Modifier is IArmorModifier armorModifier) collection.AddRange(armorModifier.ToListViewItems());

            return collection;
        }
    }
}
