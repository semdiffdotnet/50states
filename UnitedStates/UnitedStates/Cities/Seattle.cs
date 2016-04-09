namespace UnitedStates.Cities
{
    public class Seattle : ICity
    {
        private Seattle()
        { }

        public static Seattle Instance { get; } = new Seattle();
        public string Name => "Seattle";
    }
}