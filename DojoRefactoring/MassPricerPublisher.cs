using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DojoRefactoring
{
    /// <summary>
    /// Cette classe est utilisée par d'autres. Il ne faut pas casser la compatibilité
    /// </summary>
    public class MassPricerPublisher
    {
        public void PriceAndPublishEverything()
        {
            var underlyings = Perimeter.GetPerimeter();
            foreach (var underlying in underlyings)
            {
                var pricingTask = new PricingTask();
                pricingTask.PriceAndPublish(underlying);
            }
        }
    }
}
