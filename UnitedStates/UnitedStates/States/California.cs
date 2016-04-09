using UnitedStates.Birds;
using UnitedStates.Cities;
using UnitedStates.Flowers;

namespace UnitedStates.States
{
    public class California : IState
    {
        private California()
        { }

        public static California Instance { get; } = new California();
        public string Name => "California";
        public ICity Capital => Sacramento.Instance;
        public ICity LargestCity => LosAngeles.Instance;
        public IBird Bird => CaliforniaValleyQuail.Instance;
        public IFlower Flower => GoldenPoppy.Instance;
    }
}