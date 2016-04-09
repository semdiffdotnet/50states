using UnitedStates.Birds;
using UnitedStates.Cities;
using UnitedStates.Flowers;

namespace UnitedStates.States
{
    public class NewYork : IState
    {
        private NewYork()
        { }

        public static NewYork Instance { get; } = new NewYork();
        public string Name => "New York";
        public ICity Capital => Albany.Instance;
        public ICity LargestCity => Cities.NewYork.Instance;
        public IBird Bird => Bluebird.Instance;
        public IFlower Flower => Rose.Instance;
    }
}