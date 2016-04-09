namespace UnitedStates.Birds
{
    public class CaliforniaValleyQuail : IBird
    {
        private CaliforniaValleyQuail()
        { }

        public static CaliforniaValleyQuail Instance { get; } = new CaliforniaValleyQuail();
        public string Name => "California Valley Quail";
    }
}