using UnitedStates.Birds;
using UnitedStates.Cities;
using UnitedStates.Flowers;

namespace UnitedStates.States
{
    public class Colorado : IState
    {
        private Colorado()
        { }

        public static Colorado Instance { get; } = new Colorado();
        public string Name => "Colorado";
        public ICity Capital => Denver.Instance;
        public ICity LargestCity => Denver.Instance;
        public IBird Bird => LarkBunting.Instance;
        public IFlower Flower => Columbine.Instance;
    }
}