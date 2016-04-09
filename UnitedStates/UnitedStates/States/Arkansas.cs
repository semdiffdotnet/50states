using UnitedStates.Birds;
using UnitedStates.Cities;
using UnitedStates.Flowers;

namespace UnitedStates.States
{
    public class Arkansas : IState
    {
        private Arkansas()
        { }

        public static Arkansas Instance { get; } = new Arkansas();
        public string Name => "Arkansas";
        public ICity Capital => LittleRock.Instance;
        public ICity LargestCity => LittleRock.Instance;
        public IBird Bird => Mockingbird.Instance;
        public IFlower Flower => AppleBlossom.Instance;
    }
}