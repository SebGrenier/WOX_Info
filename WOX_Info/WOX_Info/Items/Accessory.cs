
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using WOX_Info.Classes;

namespace WOX_Info.Items
{
    public class Accessory : BaseItem
    {
        public Accessory(string name, double cost, int maxEquipped, ClassType allowedClasses)
            : base(name, cost, allowedClasses)
        {
            MaxEquipped = maxEquipped;
        }

        public Accessory(Accessory other)
            : base(other)
        {
            MaxEquipped = other.MaxEquipped;
        }

        public int MaxEquipped { get; }

        public override List<ListViewItem> ToListViewItems()
        {
            var collection = base.ToListViewItems();

            if (Modifier is IAccessoryModifier accessoryModifier) collection.AddRange(accessoryModifier.ToListViewItems());

            return collection;
        }
    }
}
