using UnitedStates.Birds;
using UnitedStates.Cities;
using UnitedStates.Flowers;

namespace UnitedStates.States
{
    public class Maine : IState
    {
        private Maine()
        { }

        public static Maine Instance { get; } = new Maine();
        public string Name => "Maine";
        public ICity Capital => Augusta.Instance;
        public ICity LargestCity => Portland.Instance;
        public IBird Bird => Chickadee.Instance;
        public IFlower Flower => WhitePineConeAndTassel.Instance;
    }
}