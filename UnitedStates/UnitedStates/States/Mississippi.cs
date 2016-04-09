using UnitedStates.Birds;
using UnitedStates.Cities;
using UnitedStates.Flowers;

namespace UnitedStates.States
{
    public class Mississippi : IState
    {
        private Mississippi()
        { }

        public static Mississippi Instance { get; } = new Mississippi();
        public string Name => "Mississippi";
        public ICity Capital => Jackson.Instance;
        public ICity LargestCity => Jackson.Instance;
        public IBird Bird => Mockingbird.Instance;
        public IFlower Flower => Magnolia.Instance;
    }
}