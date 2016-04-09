using UnitedStates.Birds;
using UnitedStates.Cities;
using UnitedStates.Flowers;

namespace UnitedStates.States
{
    public class Idaho : IState
    {
        private Idaho()
        { }

        public static Idaho Instance { get; } = new Idaho();
        public string Name => "Idaho";
        public ICity Capital => Boise.Instance;
        public ICity LargestCity => Boise.Instance;
        public IBird Bird => MountainBluebird.Instance;
        public IFlower Flower => Syringa.Instance;
    }
}