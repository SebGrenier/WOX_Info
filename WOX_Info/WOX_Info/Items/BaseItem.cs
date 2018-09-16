using WOX_Info.Classes;

namespace WOX_Info.Items
{
    public class BaseItem
    {
        private readonly string _name;
        private readonly double _cost;

        public BaseItem(string name, double cost, ClassType allowedClasses)
        {
            _name = name;
            _cost = cost;
            AllowedClasses = allowedClasses;
            Modifier = null;
        }

        public BaseItem(BaseItem bi)
        {
            _name = string.Copy(bi._name);
            _cost = bi._cost;
            AllowedClasses = bi.AllowedClasses;
            Modifier = bi.Modifier;
        }

        public string Name => Modifier?.ApplyName(_name) ?? _name;
        public double Cost => Modifier?.ApplyCost(_cost) ?? _cost;

        public ClassType AllowedClasses { get; set; }
        public IModifier Modifier { get; set; }
    }
}
