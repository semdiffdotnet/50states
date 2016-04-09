namespace UnitedStates.Cities
{
    public class Springfield : ICity
    {
        private Springfield()
        { }

        public static Springfield Instance { get; } = new Springfield();
        public string Name => "Springfield";
    }
}