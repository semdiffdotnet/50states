using UnitedStates.Birds;
using UnitedStates.Cities;
using UnitedStates.Flowers;

namespace UnitedStates.States
{
    public class Hawaii : IState
    {
        private Hawaii()
        { }

        public static Hawaii Instance { get; } = new Hawaii();
        public string Name => "Hawaii";
        public ICity Capital => Honolulu.Instance;
        public ICity LargestCity => Honolulu.Instance;
        public IBird Bird => HawaiianGoose.Instance;
        public IFlower Flower => Hibiscus.Instance;
    }
}