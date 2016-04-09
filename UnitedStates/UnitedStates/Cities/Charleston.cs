namespace UnitedStates.Cities
{
    public class Charleston : ICity
    {
        private Charleston()
        { }

        public static Charleston Instance { get; } = new Charleston();
        public string Name => "Charleston";
    }
}