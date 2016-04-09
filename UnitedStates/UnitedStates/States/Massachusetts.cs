using UnitedStates.Birds;
using UnitedStates.Cities;
using UnitedStates.Flowers;

namespace UnitedStates.States
{
    public class Massachusetts : IState
    {
        private Massachusetts()
        { }

        public static Massachusetts Instance { get; } = new Massachusetts();
        public string Name => "Massachusetts";
        public ICity Capital => Boston.Instance;
        public ICity LargestCity => Boston.Instance;
        public IBird Bird => Chickadee.Instance;
        public IFlower Flower => Mayflower.Instance;
    }
}