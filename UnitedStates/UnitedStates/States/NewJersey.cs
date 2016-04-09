using UnitedStates.Birds;
using UnitedStates.Cities;
using UnitedStates.Flowers;

namespace UnitedStates.States
{
    public class NewJersey : IState
    {
        private NewJersey()
        { }

        public static NewJersey Instance { get; } = new NewJersey();
        public string Name => "New Jersey";
        public ICity Capital => Trenton.Instance;
        public ICity LargestCity => Newark.Instance;
        public IBird Bird => EasternGoldfinch.Instance;
        public IFlower Flower => Violet.Instance;
    }
}