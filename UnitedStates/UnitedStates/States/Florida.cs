using UnitedStates.Birds;
using UnitedStates.Cities;
using UnitedStates.Flowers;

namespace UnitedStates.States
{
    public class Florida : IState
    {
        private Florida()
        { }

        public static Florida Instance { get; } = new Florida();
        public string Name => "Florida";
        public ICity Capital => Tallahassee.Instance;
        public ICity LargestCity => Jacksonville.Instance;
        public IBird Bird => Mockingbird.Instance;
        public IFlower Flower => OrangeBlossom.Instance;
    }
}