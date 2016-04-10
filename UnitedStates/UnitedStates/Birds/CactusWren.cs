namespace UnitedStates.Birds
{
    public class CactusWren : IBird
    {
        private CactusWren()
        { }

        public static CactusWren Instance { get; } = new CactusWren();
        public string Name => "Cactus Wren";
        public string BinomialNomenclature => "Campylorhynchus brunneicapillus";
    }
}