using UnitedStates.Birds;
using UnitedStates.Cities;
using UnitedStates.Flowers;

namespace UnitedStates.States
{
    public class Maryland : IState
    {
        private Maryland()
        { }

        public static Maryland Instance { get; } = new Maryland();
        public string Name => "Maryland";
        public ICity Capital => Annapolis.Instance;
        public ICity LargestCity => Baltimore.Instance;
        public IBird Bird => BaltimoreOriole.Instance;
        public IFlower Flower => BlackEyedSusan.Instance;
    }
}