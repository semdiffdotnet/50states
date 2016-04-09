namespace UnitedStates.Cities
{
    public class Montgomery : ICity
    {
        private Montgomery()
        { }

        public static Montgomery Instance { get; } = new Montgomery();
        public string Name => "Montgomery";
    }
}