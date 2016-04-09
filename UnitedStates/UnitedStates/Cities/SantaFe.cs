namespace UnitedStates.Cities
{
    public class SantaFe : ICity
    {
        private SantaFe()
        { }

        public static SantaFe Instance { get; } = new SantaFe();
        public string Name => "Santa Fe";
    }
}