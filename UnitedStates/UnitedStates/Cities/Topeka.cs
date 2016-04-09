namespace UnitedStates.Cities
{
    public class Topeka : ICity
    {
        private Topeka()
        { }

        public static Topeka Instance { get; } = new Topeka();
        public string Name => "Topeka";
    }
}