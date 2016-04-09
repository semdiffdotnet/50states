using UnitedStates.Birds;
using UnitedStates.Cities;
using UnitedStates.Flowers;

namespace UnitedStates.States
{
    public class Texas : IState
    {
        private Texas()
        { }

        public static Texas Instance { get; } = new Texas();
        public string Name => "Texas";
        public ICity Capital => Austin.Instance;
        public ICity LargestCity => Houston.Instance;
        public IBird Bird => Mockingbird.Instance;
        public IFlower Flower => Bluebonnet.Instance;
    }
}