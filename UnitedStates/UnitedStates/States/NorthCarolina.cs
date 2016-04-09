using UnitedStates.Birds;
using UnitedStates.Cities;
using UnitedStates.Flowers;

namespace UnitedStates.States
{
    public class NorthCarolina : IState
    {
        private NorthCarolina()
        { }

        public static NorthCarolina Instance { get; } = new NorthCarolina();
        public string Name => "North Carolina";
        public ICity Capital => Raleigh.Instance;
        public ICity LargestCity => Charlotte.Instance;
        public IBird Bird => Cardinal.Instance;
        public IFlower Flower => Dogwood.Instance;
    }
}