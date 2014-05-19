using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DojoRefactoring.ThirdParties;

namespace DojoRefactoring
{
    class PricingTask
    {
        private MarketDataRetriever marketDataRetriever;

        public PricingTask()
        {
            marketDataRetriever = new MarketDataRetriever();
        }

        public void PriceAndPublish(string underlying)
        {
            double yesterdayPrice = marketDataRetriever.GetClose(underlying);
            //FIXME en fait, ça devrait être + 2 et non pas + 1
            double todayPrice = yesterdayPrice + 1;
            PricePublisher.Instance.Publish(todayPrice);
        }
    }
}
