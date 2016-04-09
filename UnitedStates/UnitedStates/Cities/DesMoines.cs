namespace UnitedStates.Cities
{
    public class DesMoines : ICity
    {
        private DesMoines()
        { }

        public static DesMoines Instance { get; } = new DesMoines();
        public string Name => "Des Moines";
    }
}