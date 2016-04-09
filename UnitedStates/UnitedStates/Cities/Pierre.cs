namespace UnitedStates.Cities
{
    public class Pierre : ICity
    {
        private Pierre()
        { }

        public static Pierre Instance { get; } = new Pierre();
        public string Name => "Pierre";
    }
}