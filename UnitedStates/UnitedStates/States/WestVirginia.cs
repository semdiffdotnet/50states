using UnitedStates.Birds;
using UnitedStates.Cities;
using UnitedStates.Flowers;

namespace UnitedStates.States
{
    public class WestVirginia : IState
    {
        private WestVirginia()
        { }

        public static WestVirginia Instance { get; } = new WestVirginia();
        public string Name => "West Virginia";
        public ICity Capital => Charleston.Instance;
        public ICity LargestCity => Charleston.Instance;
        public IBird Bird => Cardinal.Instance;
        public IFlower Flower => BigRhododendron.Instance;
    }
}