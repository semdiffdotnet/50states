namespace UnitedStates.Birds
{
    public class HawaiianGoose : IBird
    {
        private HawaiianGoose()
        { }

        public static HawaiianGoose Instance { get; } = new HawaiianGoose();
        public string Name => "Nēnē (Hawaiian Goose)";
        public string BinomialNomenclature => "Branta sandvicensis";
    }
}