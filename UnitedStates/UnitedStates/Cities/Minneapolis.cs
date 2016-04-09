namespace UnitedStates.Cities
{
    public class Minneapolis : ICity
    {
        private Minneapolis()
        { }

        public static Minneapolis Instance { get; } = new Minneapolis();
        public string Name => "Minneapolis";
    }
}