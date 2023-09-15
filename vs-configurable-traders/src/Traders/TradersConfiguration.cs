namespace CongifurableTraders.Traders
{
    public class TradersConfiguration
    {
        public static TradersConfiguration Instance { get; set; } = new TradersConfiguration();

        public float DeliveryPriceMul { get; set; } = 1f;
        public int DurationWeeksMul { get; set; } = 3;
        public float SalesCutRate { get; set; } = 0.1f;
    }
}
