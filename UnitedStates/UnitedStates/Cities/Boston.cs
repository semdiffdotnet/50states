namespace UnitedStates.Cities
{
    public class Boston : ICity
    {
        private Boston()
        { }

        public static Boston Instance { get; } = new Boston();
        public string Name => "Boston";
    }
}