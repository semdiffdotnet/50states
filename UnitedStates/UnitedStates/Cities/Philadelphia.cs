namespace UnitedStates.Cities
{
    public class Philadelphia : ICity
    {
        private Philadelphia()
        { }

        public static Philadelphia Instance { get; } = new Philadelphia();
        public string Name => "Philadelphia";
    }
}