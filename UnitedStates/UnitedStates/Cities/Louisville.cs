namespace UnitedStates.Cities
{
    public class Louisville : ICity
    {
        private Louisville()
        { }

        public static Louisville Instance { get; } = new Louisville();
        public string Name => "Louisville";
    }
}