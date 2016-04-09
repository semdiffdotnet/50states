using UnitedStates.Birds;
using UnitedStates.Cities;
using UnitedStates.Flowers;

namespace UnitedStates.States
{
    public class Delaware : IState
    {
        private Delaware()
        { }

        public static Delaware Instance { get; } = new Delaware();
        public string Name => "Delaware";
        public ICity Capital => Dover.Instance;
        public ICity LargestCity => Wilmington.Instance;
        public IBird Bird => BlueHenChicken.Instance;
        public IFlower Flower => PeachBlossom.Instance;
    }
}