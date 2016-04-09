namespace UnitedStates.Cities
{
    public class Portland : ICity
    {
        private Portland()
        { }

        public static Portland Instance { get; } = new Portland();
        public string Name => "Portland";
    }
}