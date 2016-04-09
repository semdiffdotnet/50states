namespace UnitedStates.Birds
{
    public class RingNeckedPheasant : IBird
    {
        private RingNeckedPheasant()
        { }

        public static RingNeckedPheasant Instance { get; } = new RingNeckedPheasant();
        public string Name => "Ring-Necked Pheasant";
    }
}