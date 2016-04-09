using UnitedStates.Birds;
using UnitedStates.Cities;
using UnitedStates.Flowers;

namespace UnitedStates.States
{
    public class Michigan : IState
    {
        private Michigan()
        { }

        public static Michigan Instance { get; } = new Michigan();
        public string Name => "Michigan";
        public ICity Capital => Lansing.Instance;
        public ICity LargestCity => Detroit.Instance;
        public IBird Bird => Robin.Instance;
        public IFlower Flower => AppleBlossom.Instance;
    }
}