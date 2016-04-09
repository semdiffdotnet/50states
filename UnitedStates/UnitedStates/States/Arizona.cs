using UnitedStates.Birds;
using UnitedStates.Cities;
using UnitedStates.Flowers;

namespace UnitedStates.States
{
    public class Arizona : IState
    {
        private Arizona()
        { }

        public static Arizona Instance { get; } = new Arizona();
        public string Name => "Arizona";
        public ICity Capital => Phoenix.Instance;
        public ICity LargestCity => Phoenix.Instance;
        public IBird Bird => CactusWren.Instance;
        public IFlower Flower => SaguaroCactusBlossom.Instance;
    }
}