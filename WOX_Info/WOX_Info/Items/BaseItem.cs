using WOX_Info.Classes;

namespace WOX_Info.Items
{
    public class BaseItem
    {
        public string Name { get; set; }
        public double Cost { get; set; }
        public ClassType AllowedClasses { get; set; }

        public BaseItem(string name, double cost, ClassType allowedClasses)
        {
            Name = name;
            Cost = cost;
            AllowedClasses = allowedClasses;
        }

        public BaseItem(BaseItem bi)
        {
            Name = string.Copy(bi.Name);
            Cost = bi.Cost;
            AllowedClasses = bi.AllowedClasses;
        }
    }
}
