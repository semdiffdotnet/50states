using UnitedStates.Birds;
using UnitedStates.Cities;
using UnitedStates.Flowers;

namespace UnitedStates.States
{
    public class Nebraska : IState
    {
        private Nebraska()
        { }

        public static Nebraska Instance { get; } = new Nebraska();
        public string Name => "Nebraska";
        public ICity Capital => Lincoln.Instance;
        public ICity LargestCity => Omaha.Instance;
        public IBird Bird => WesternMeadowlark.Instance;
        public IFlower Flower => Goldenrod.Instance;
    }
}