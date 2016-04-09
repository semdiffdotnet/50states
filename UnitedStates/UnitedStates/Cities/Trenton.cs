namespace UnitedStates.Cities
{
    public class Trenton : ICity
    {
        private Trenton()
        { }

        public static Trenton Instance { get; } = new Trenton();
        public string Name => "Trenton";
    }
}