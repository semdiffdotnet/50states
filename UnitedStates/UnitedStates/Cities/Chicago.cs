namespace UnitedStates.Cities
{
    public class Chicago : ICity
    {
        private Chicago()
        { }

        public static Chicago Instance { get; } = new Chicago();
        public string Name => "Chicago";
    }
}