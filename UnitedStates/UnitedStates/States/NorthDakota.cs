using UnitedStates.Birds;
using UnitedStates.Cities;
using UnitedStates.Flowers;

namespace UnitedStates.States
{
    public class NorthDakota : IState
    {
        private NorthDakota()
        { }

        public static NorthDakota Instance { get; } = new NorthDakota();
        public string Name => "North Dakota";
        public ICity Capital => Bismarck.Instance;
        public ICity LargestCity => Fargo.Instance;
        public IBird Bird => WesternMeadowlark.Instance;
        public IFlower Flower => WildPrairieRose.Instance;
    }
}