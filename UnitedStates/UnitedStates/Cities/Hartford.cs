namespace UnitedStates.Cities
{
    public class Hartford : ICity
    {
        private Hartford()
        { }

        public static Hartford Instance { get; } = new Hartford();
        public string Name => "Hartford";
    }
}