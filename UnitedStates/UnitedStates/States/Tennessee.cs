using UnitedStates.Birds;
using UnitedStates.Cities;
using UnitedStates.Flowers;

namespace UnitedStates.States
{
    public class Tennessee : IState
    {
        private Tennessee()
        { }

        public static Tennessee Instance { get; } = new Tennessee();
        public string Name => "Tennessee";
        public ICity Capital => Nashville.Instance;
        public ICity LargestCity => Memphis.Instance;
        public IBird Bird => Mockingbird.Instance;
        public IFlower Flower => Iris.Instance;
    }
}