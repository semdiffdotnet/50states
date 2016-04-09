using UnitedStates.Birds;
using UnitedStates.Cities;
using UnitedStates.Flowers;

namespace UnitedStates.States
{
    public class Washington : IState
    {
        private Washington()
        { }

        public static Washington Instance { get; } = new Washington();
        public string Name => "Washington";
        public ICity Capital => Olympia.Instance;
        public ICity LargestCity => Seattle.Instance;
        public IBird Bird => WillowGoldfinch.Instance;
        public IFlower Flower => WesternRhododendron.Instance;
    }
}