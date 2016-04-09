namespace UnitedStates.Cities
{
    public class Birmingham : ICity
    {
        private Birmingham()
        { }

        public static Birmingham Instance { get; } = new Birmingham();
        public string Name => "Birmingham";
    }
}