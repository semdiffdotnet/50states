using UnitedStates.Birds;
using UnitedStates.Cities;
using UnitedStates.Flowers;

namespace UnitedStates.States
{
    public class Ohio : IState
    {
        private Ohio()
        { }

        public static Ohio Instance { get; } = new Ohio();
        public string Name => "Ohio";
        public ICity Capital => Columbus.Instance;
        public ICity LargestCity => Columbus.Instance;
        public IBird Bird => Cardinal.Instance;
        public IFlower Flower => ScarletCarnation.Instance;
    }
}