namespace UnitedStates.Cities
{
    public class Phoenix : ICity
    {
        private Phoenix()
        { }

        public static Phoenix Instance { get; } = new Phoenix();
        public string Name => "Phoenix";
    }
}