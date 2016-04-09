namespace UnitedStates.Cities
{
    public class Burlington : ICity
    {
        private Burlington()
        { }

        public static Burlington Instance { get; } = new Burlington();
        public string Name => "Burlington";
    }
}