namespace UnitedStates.Birds
{
    public class CommonLoon : IBird
    {
        private CommonLoon()
        { }

        public static CommonLoon Instance { get; } = new CommonLoon();
        public string Name => "Common Loon";
    }
}