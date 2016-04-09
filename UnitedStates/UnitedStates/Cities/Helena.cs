namespace UnitedStates.Cities
{
    public class Helena : ICity
    {
        private Helena()
        { }

        public static Helena Instance { get; } = new Helena();
        public string Name => "Helena";
    }
}