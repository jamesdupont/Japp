namespace Models
{
    public class RoundGemWidth : BaseEntity
    {
        public RoundGemWidth()
        {
            SetDefaults();
        }
        public int RoundGemWidthID { get; set; }

        public int OwnerID { get; set; }

        public decimal Mesurement { get; set; }

        public void SetDefaults()
        {
            SetBaseDefaults();
        }
    }
}