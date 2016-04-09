using UnitedStates.Birds;
using UnitedStates.Cities;
using UnitedStates.Flowers;

namespace UnitedStates.States
{
    public class Wyoming : IState
    {
        private Wyoming()
        { }

        public static Wyoming Instance { get; } = new Wyoming();
        public string Name => "Wyoming";
        public ICity Capital => Cheyenne.Instance;
        public ICity LargestCity => Cheyenne.Instance;
        public IBird Bird => Meadowlark.Instance;
        public IFlower Flower => IndianPaintbrush.Instance;
    }
}