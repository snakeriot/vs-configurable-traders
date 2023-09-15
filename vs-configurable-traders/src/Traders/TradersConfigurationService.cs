using Vintagestory.API.Common;
using Vintagestory.GameContent;

namespace CongifurableTraders.Traders
{
    public class TradersConfigurationService
    {
        private readonly static string FILE_NAME = "TradersConfiguration.json";

        public static void LoadOrCreateConfigFile(ICoreAPI api)
        {
            try
            {
                TradersConfiguration fromDisk;
                if ((fromDisk = api.LoadModConfig<TradersConfiguration>(FILE_NAME)) == null)
                {
                    api.StoreModConfig(TradersConfiguration.Instance, FILE_NAME);
                }
                else
                {
                    TradersConfiguration.Instance = fromDisk;
                }
            }
            catch
            {
                api.StoreModConfig(TradersConfiguration.Instance, FILE_NAME);
            }

        }

        public static void SetWorldConfig(ICoreAPI api)
        {
            ModSystemAuction auction = api.ModLoader.GetModSystem<ModSystemAuction>();
            auction.DeliveryPriceMul = TradersConfiguration.Instance.DeliveryPriceMul;
            auction.DurationWeeksMul = TradersConfiguration.Instance.DurationWeeksMul;
            auction.SalesCutRate = TradersConfiguration.Instance.SalesCutRate;
        }
    }
}
