using UnitedStates.Birds;
using UnitedStates.Cities;
using UnitedStates.Flowers;

namespace UnitedStates.States
{
    public class Connecticut : IState
    {
        private Connecticut()
        { }

        public static Connecticut Instance { get; } = new Connecticut();
        public string Name => "Connecticut";
        public ICity Capital => Hartford.Instance;
        public ICity LargestCity => Bridgeport.Instance;
        public IBird Bird => AmericanRobin.Instance;
        public IFlower Flower => MountainLaurel.Instance;
    }
}