using CongifurableTraders.Traders;
using System;
using Vintagestory.API.Common;

namespace CongifurableTraders
{
    public class CongifurableTradersMod : ModSystem
    {
        public override void StartPre(ICoreAPI api)
        {
            base.StartPre(api);
            TradersConfigurationService.LoadOrCreateConfigFile(api);
        }

        public override void AssetsLoaded(ICoreAPI api)
        {
            Console.WriteLine("----------------- HI --------------------------");
            TradersConfigurationService.SetWorldConfig(api);
        }
    }
}
