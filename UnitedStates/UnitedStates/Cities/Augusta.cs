namespace UnitedStates.Cities
{
    public class Augusta : ICity
    {
        private Augusta()
        { }

        public static Augusta Instance { get; } = new Augusta();
        public string Name => "Augusta";
    }
}