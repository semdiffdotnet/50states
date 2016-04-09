using UnitedStates.Birds;
using UnitedStates.Cities;
using UnitedStates.Flowers;

namespace UnitedStates.States
{
    public class Wisconsin : IState
    {
        private Wisconsin()
        { }

        public static Wisconsin Instance { get; } = new Wisconsin();
        public string Name => "Wisconsin";
        public ICity Capital => Madison.Instance;
        public ICity LargestCity => Milwaukee.Instance;
        public IBird Bird => Robin.Instance;
        public IFlower Flower => WoodViolet.Instance;
    }
}