namespace UnitedStates.Cities
{
    public class Richmond : ICity
    {
        private Richmond()
        { }

        public static Richmond Instance { get; } = new Richmond();
        public string Name => "Richmond";
    }
}