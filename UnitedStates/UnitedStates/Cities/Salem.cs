namespace UnitedStates.Cities
{
    public class Salem : ICity
    {
        private Salem()
        { }

        public static Salem Instance { get; } = new Salem();
        public string Name => "Salem";
    }
}