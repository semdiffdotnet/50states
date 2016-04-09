using UnitedStates.Birds;
using UnitedStates.Cities;
using UnitedStates.Flowers;

namespace UnitedStates.States
{
    public class Georgia : IState
    {
        private Georgia()
        { }

        public static Georgia Instance { get; } = new Georgia();
        public string Name => "Georgia";
        public ICity Capital => Atlanta.Instance;
        public ICity LargestCity => Atlanta.Instance;
        public IBird Bird => BrownThrasher.Instance;
        public IFlower Flower => CherokeeRose.Instance;
    }
}