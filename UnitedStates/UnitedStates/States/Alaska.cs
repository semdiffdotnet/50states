using UnitedStates.Birds;
using UnitedStates.Cities;
using UnitedStates.Flowers;

namespace UnitedStates.States
{
    public class Alaska : IState
    {
        private Alaska()
        { }

        public static Alaska Instance { get; } = new Alaska();
        public string Name => "Alaska";
        public ICity Capital => Juneau.Instance;
        public ICity LargestCity => Anchorage.Instance;
        public IBird Bird => WillowPtarmigan.Instance;
        public IFlower Flower => ForgetMeNot.Instance;
    }
}