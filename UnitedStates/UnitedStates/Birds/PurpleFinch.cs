namespace UnitedStates.Birds
{
    public class PurpleFinch : IBird
    {
        private PurpleFinch()
        { }

        public static PurpleFinch Instance { get; } = new PurpleFinch();
        public string Name => "Purple Finch";
    }
}