using UnitedStates.Birds;
using UnitedStates.Cities;
using UnitedStates.Flowers;

namespace UnitedStates.States
{
    public class Louisiana : IState
    {
        private Louisiana()
        { }

        public static Louisiana Instance { get; } = new Louisiana();
        public string Name => "Louisiana";
        public ICity Capital => BatonRouge.Instance;
        public ICity LargestCity => NewOrleans.Instance;
        public IBird Bird => Pelican.Instance;
        public IFlower Flower => Magnolia.Instance;
    }
}