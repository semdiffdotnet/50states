namespace UnitedStates.Cities
{
    public class VirginiaBeach : ICity
    {
        private VirginiaBeach()
        { }

        public static VirginiaBeach Instance { get; } = new VirginiaBeach();
        public string Name => "Virginia Beach";
    }
}