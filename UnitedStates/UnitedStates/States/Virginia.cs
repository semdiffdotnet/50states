using UnitedStates.Birds;
using UnitedStates.Cities;
using UnitedStates.Flowers;

namespace UnitedStates.States
{
    public class Virginia : IState
    {
        private Virginia()
        { }

        public static Virginia Instance { get; } = new Virginia();
        public string Name => "Virginia";
        public ICity Capital => Richmond.Instance;
        public ICity LargestCity => VirginiaBeach.Instance;
        public IBird Bird => Cardinal.Instance;
        public IFlower Flower => Dogwood.Instance;
    }
}