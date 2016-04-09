using UnitedStates.Birds;
using UnitedStates.Cities;
using UnitedStates.Flowers;

namespace UnitedStates.States
{
    public class SouthCarolina : IState
    {
        private SouthCarolina()
        { }

        public static SouthCarolina Instance { get; } = new SouthCarolina();
        public string Name => "South Carolina";
        public ICity Capital => Columbia.Instance;
        public ICity LargestCity => Columbia.Instance;
        public IBird Bird => CarolinaWren.Instance;
        public IFlower Flower => YellowJessamine.Instance;
    }
}