namespace UnitedStates.Cities
{
    public class Jacksonville : ICity
    {
        private Jacksonville()
        { }

        public static Jacksonville Instance { get; } = new Jacksonville();
        public string Name => "Jacksonville";
    }
}