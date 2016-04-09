namespace UnitedStates.Cities
{
    public class LasVegas : ICity
    {
        private LasVegas()
        { }

        public static LasVegas Instance { get; } = new LasVegas();
        public string Name => "Las Vegas";
    }
}