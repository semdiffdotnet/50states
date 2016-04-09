using UnitedStates.Birds;
using UnitedStates.Cities;
using UnitedStates.Flowers;

namespace UnitedStates.States
{
    public class Kentucky : IState
    {
        private Kentucky()
        { }

        public static Kentucky Instance { get; } = new Kentucky();
        public string Name => "Kentucky";
        public ICity Capital => Frankfort.Instance;
        public ICity LargestCity => Louisville.Instance;
        public IBird Bird => Cardinal.Instance;
        public IFlower Flower => Goldenrod.Instance;
    }
}