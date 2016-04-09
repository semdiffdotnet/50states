using UnitedStates.Birds;
using UnitedStates.Cities;
using UnitedStates.Flowers;

namespace UnitedStates.States
{
    public class Oklahoma : IState
    {
        private Oklahoma()
        { }

        public static Oklahoma Instance { get; } = new Oklahoma();
        public string Name => "Oklahoma";
        public ICity Capital => OklahomaCity.Instance;
        public ICity LargestCity => OklahomaCity.Instance;
        public IBird Bird => ScissorTailedFlycatcher.Instance;
        public IFlower Flower => Mistletoe.Instance;
    }
}