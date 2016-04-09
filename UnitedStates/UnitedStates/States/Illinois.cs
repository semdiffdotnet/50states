using UnitedStates.Birds;
using UnitedStates.Cities;
using UnitedStates.Flowers;

namespace UnitedStates.States
{
    public class Illinois : IState
    {
        private Illinois()
        { }

        public static Illinois Instance { get; } = new Illinois();
        public string Name => "Illinois";
        public ICity Capital => Springfield.Instance;
        public ICity LargestCity => Chicago.Instance;
        public IBird Bird => Cardinal.Instance;
        public IFlower Flower => Violet.Instance;
    }
}