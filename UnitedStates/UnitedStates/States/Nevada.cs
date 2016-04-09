using UnitedStates.Birds;
using UnitedStates.Cities;
using UnitedStates.Flowers;

namespace UnitedStates.States
{
    public class Nevada : IState
    {
        private Nevada()
        { }

        public static Nevada Instance { get; } = new Nevada();
        public string Name => "Nevada";
        public ICity Capital => CarsonCity.Instance;
        public ICity LargestCity => LasVegas.Instance;
        public IBird Bird => MountainBluebird.Instance;
        public IFlower Flower => Sagebrush.Instance;
    }
}