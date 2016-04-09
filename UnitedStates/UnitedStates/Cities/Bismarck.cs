namespace UnitedStates.Cities
{
    public class Bismarck : ICity
    {
        private Bismarck()
        { }

        public static Bismarck Instance { get; } = new Bismarck();
        public string Name => "Bismarck";
    }
}