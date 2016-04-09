using UnitedStates.Birds;
using UnitedStates.Cities;
using UnitedStates.Flowers;

namespace UnitedStates.States
{
    public class Indiana : IState
    {
        private Indiana()
        { }

        public static Indiana Instance { get; } = new Indiana();
        public string Name => "Indiana";
        public ICity Capital => Indianapolis.Instance;
        public ICity LargestCity => Indianapolis.Instance;
        public IBird Bird => Cardinal.Instance;
        public IFlower Flower => Peony.Instance;
    }
}