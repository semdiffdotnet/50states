using UnitedStates.Birds;
using UnitedStates.Cities;
using UnitedStates.Flowers;

namespace UnitedStates.States
{
    public class Alabama : IState
    {
        private Alabama()
        { }

        public static Alabama Instance { get; } = new Alabama();
        public string Name => "Alabama";
        public ICity Capital => Montgomery.Instance;
        public ICity LargestCity => Birmingham.Instance;
        public IBird Bird => Yellowhammer.Instance;
        public IFlower Flower => Camellia.Instance;
    }
}