namespace UnitedStates.Birds
{
    public class AmericanRobin : IBird
    {
        private AmericanRobin()
        { }

        public static AmericanRobin Instance { get; } = new AmericanRobin();
        public string Name => "American Robin";
    }
}