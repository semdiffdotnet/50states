using UnitedStates.Birds;
using UnitedStates.Cities;
using UnitedStates.Flowers;

namespace UnitedStates.States
{
    public class Utah : IState
    {
        private Utah()
        { }

        public static Utah Instance { get; } = new Utah();
        public string Name => "Utah";
        public ICity Capital => SaltLakeCity.Instance;
        public ICity LargestCity => SaltLakeCity.Instance;
        public IBird Bird => CaliforniaGull.Instance;
        public IFlower Flower => SegoLily.Instance;
    }
}