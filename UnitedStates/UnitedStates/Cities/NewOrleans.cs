namespace UnitedStates.Cities
{
    public class NewOrleans : ICity
    {
        private NewOrleans()
        { }

        public static NewOrleans Instance { get; } = new NewOrleans();
        public string Name => "New Orleans";
    }
}