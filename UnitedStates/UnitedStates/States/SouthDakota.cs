using UnitedStates.Birds;
using UnitedStates.Cities;
using UnitedStates.Flowers;

namespace UnitedStates.States
{
    public class SouthDakota : IState
    {
        private SouthDakota()
        { }

        public static SouthDakota Instance { get; } = new SouthDakota();
        public string Name => "South Dakota";
        public ICity Capital => Pierre.Instance;
        public ICity LargestCity => SiouxFalls.Instance;
        public IBird Bird => RingNeckedPheasant.Instance;
        public IFlower Flower => AmericanPasqueflower.Instance;
    }
}