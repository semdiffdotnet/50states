using UnitedStates.Birds;
using UnitedStates.Cities;
using UnitedStates.Flowers;

namespace UnitedStates.States
{
    public class Kansas : IState
    {
        private Kansas()
        { }

        public static Kansas Instance { get; } = new Kansas();
        public string Name => "Kansas";
        public ICity Capital => Topeka.Instance;
        public ICity LargestCity => Wichita.Instance;
        public IBird Bird => WesternMeadowlark.Instance;
        public IFlower Flower => NativeSunflower.Instance;
    }
}