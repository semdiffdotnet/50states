namespace UnitedStates.Cities
{
    public class Milwaukee : ICity
    {
        private Milwaukee()
        { }

        public static Milwaukee Instance { get; } = new Milwaukee();
        public string Name => "Milwaukee";
    }
}