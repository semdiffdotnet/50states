using UnitedStates.Birds;
using UnitedStates.Cities;
using UnitedStates.Flowers;

namespace UnitedStates.States
{
    public class Minnesota : IState
    {
        private Minnesota()
        { }

        public static Minnesota Instance { get; } = new Minnesota();
        public string Name => "Minnesota";
        public ICity Capital => StPaul.Instance;
        public ICity LargestCity => Minneapolis.Instance;
        public IBird Bird => CommonLoon.Instance;
        public IFlower Flower => PinkandWhiteLadysSlipper.Instance;
    }
}