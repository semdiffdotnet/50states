using UnitedStates.Birds;
using UnitedStates.Cities;
using UnitedStates.Flowers;

namespace UnitedStates.States
{
    public class Iowa : IState
    {
        private Iowa()
        { }

        public static Iowa Instance { get; } = new Iowa();
        public string Name => "Iowa";
        public ICity Capital => DesMoines.Instance;
        public ICity LargestCity => DesMoines.Instance;
        public IBird Bird => EasternGoldfinch.Instance;
        public IFlower Flower => WildRose.Instance;
    }
}