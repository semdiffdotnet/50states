using UnitedStates.Birds;
using UnitedStates.Cities;
using UnitedStates.Flowers;

namespace UnitedStates.States
{
    public class Montana : IState
    {
        private Montana()
        { }

        public static Montana Instance { get; } = new Montana();
        public string Name => "Montana";
        public ICity Capital => Helena.Instance;
        public ICity LargestCity => Billings.Instance;
        public IBird Bird => WesternMeadowlark.Instance;
        public IFlower Flower => Bitterroot.Instance;
    }
}