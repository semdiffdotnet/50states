using UnitedStates.Birds;
using UnitedStates.Cities;
using UnitedStates.Flowers;

namespace UnitedStates.States
{
    public class RhodeIsland : IState
    {
        private RhodeIsland()
        { }

        public static RhodeIsland Instance { get; } = new RhodeIsland();
        public string Name => "Rhode Island";
        public ICity Capital => Providence.Instance;
        public ICity LargestCity => Providence.Instance;
        public IBird Bird => RhodeIslandRed.Instance;
        public IFlower Flower => Violet.Instance;
    }
}