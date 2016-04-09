namespace UnitedStates.Cities
{
    public class Lincoln : ICity
    {
        private Lincoln()
        { }

        public static Lincoln Instance { get; } = new Lincoln();
        public string Name => "Lincoln";
    }
}