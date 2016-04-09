namespace UnitedStates.Cities
{
    public class Columbus : ICity
    {
        private Columbus()
        { }

        public static Columbus Instance { get; } = new Columbus();
        public string Name => "Columbus";
    }
}