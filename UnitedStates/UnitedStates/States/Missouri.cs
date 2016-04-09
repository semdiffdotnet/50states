using UnitedStates.Birds;
using UnitedStates.Cities;
using UnitedStates.Flowers;

namespace UnitedStates.States
{
    public class Missouri : IState
    {
        private Missouri()
        { }

        public static Missouri Instance { get; } = new Missouri();
        public string Name => "Missouri";
        public ICity Capital => JeffersonCity.Instance;
        public ICity LargestCity => KansasCity.Instance;
        public IBird Bird => Bluebird.Instance;
        public IFlower Flower => Hawthorn.Instance;
    }
}