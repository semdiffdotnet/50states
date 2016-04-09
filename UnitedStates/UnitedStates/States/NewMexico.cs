using UnitedStates.Birds;
using UnitedStates.Cities;
using UnitedStates.Flowers;

namespace UnitedStates.States
{
    public class NewMexico : IState
    {
        private NewMexico()
        { }

        public static NewMexico Instance { get; } = new NewMexico();
        public string Name => "New Mexico";
        public ICity Capital => SantaFe.Instance;
        public ICity LargestCity => Albuquerque.Instance;
        public IBird Bird => Roadrunner.Instance;
        public IFlower Flower => YuccaFlower.Instance;
    }
}