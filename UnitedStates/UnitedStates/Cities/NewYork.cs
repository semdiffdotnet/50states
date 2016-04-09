namespace UnitedStates.Cities
{
    public class NewYork : ICity
    {
        private NewYork()
        { }

        public static NewYork Instance { get; } = new NewYork();
        public string Name => "New York";
    }
}