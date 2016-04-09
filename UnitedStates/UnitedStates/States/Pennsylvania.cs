using UnitedStates.Birds;
using UnitedStates.Cities;
using UnitedStates.Flowers;

namespace UnitedStates.States
{
    public class Pennsylvania : IState
    {
        private Pennsylvania()
        { }

        public static Pennsylvania Instance { get; } = new Pennsylvania();
        public string Name => "Pennsylvania";
        public ICity Capital => Harrisburg.Instance;
        public ICity LargestCity => Philadelphia.Instance;
        public IBird Bird => RuffedGrouse.Instance;
        public IFlower Flower => MountainLaurel.Instance;
    }
}