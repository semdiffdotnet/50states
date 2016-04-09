using UnitedStates.Birds;
using UnitedStates.Cities;
using UnitedStates.Flowers;

namespace UnitedStates.States
{
    public class Oregon : IState
    {
        private Oregon()
        { }

        public static Oregon Instance { get; } = new Oregon();
        public string Name => "Oregon";
        public ICity Capital => Salem.Instance;
        public ICity LargestCity => Portland.Instance;
        public IBird Bird => WesternMeadowlark.Instance;
        public IFlower Flower => OregonGrape.Instance;
    }
}