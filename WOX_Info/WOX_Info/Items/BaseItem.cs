using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WOX_Info.Classes;

namespace WOX_Info.Items
{
    public class BaseItem
    {
        public string Name { get; set; }
        public double Cost { get; set; }
        public ClassType AllowedClasses { get; set; }

        public BaseItem(string name, double cost, ClassType allowed_classes)
        {
            Name = name;
            Cost = cost;
            AllowedClasses = allowed_classes;
        }

        public BaseItem(BaseItem bi)
        {
            Name = string.Copy(bi.Name);
            Cost = bi.Cost;
            AllowedClasses = bi.AllowedClasses;
        }
    }
}
