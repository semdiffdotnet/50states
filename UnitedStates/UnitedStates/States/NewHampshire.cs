using UnitedStates.Birds;
using UnitedStates.Cities;
using UnitedStates.Flowers;

namespace UnitedStates.States
{
    public class NewHampshire : IState
    {
        private NewHampshire()
        { }

        public static NewHampshire Instance { get; } = new NewHampshire();
        public string Name => "New Hampshire";
        public ICity Capital => Concord.Instance;
        public ICity LargestCity => Manchester.Instance;
        public IBird Bird => PurpleFinch.Instance;
        public IFlower Flower => PurpleLilac.Instance;
    }
}