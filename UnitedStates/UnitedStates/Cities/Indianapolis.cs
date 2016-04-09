namespace UnitedStates.Cities
{
    public class Indianapolis : ICity
    {
        private Indianapolis()
        { }

        public static Indianapolis Instance { get; } = new Indianapolis();
        public string Name => "Indianapolis";
    }
}