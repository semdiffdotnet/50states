using UnitedStates.Birds;
using UnitedStates.Cities;
using UnitedStates.Flowers;

namespace UnitedStates.States
{
    public class Vermont : IState
    {
        private Vermont()
        { }

        public static Vermont Instance { get; } = new Vermont();
        public string Name => "Vermont";
        public ICity Capital => Montpelier.Instance;
        public ICity LargestCity => Burlington.Instance;
        public IBird Bird => HermitThrush.Instance;
        public IFlower Flower => RedClover.Instance;
    }
}