namespace UnitedStates.Birds
{
    public class BlueHenChicken : IBird
    {
        private BlueHenChicken()
        { }

        public static BlueHenChicken Instance { get; } = new BlueHenChicken();
        public string Name => "Blue Hen Chicken";
    }
}