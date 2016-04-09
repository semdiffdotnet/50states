namespace UnitedStates.Birds
{
    public class MountainBluebird : IBird
    {
        private MountainBluebird()
        { }

        public static MountainBluebird Instance { get; } = new MountainBluebird();
        public string Name => "Mountain Bluebird";
    }
}