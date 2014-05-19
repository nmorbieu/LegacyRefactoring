using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DojoRefactoring.ThirdParties
{
    /// <summary>
    /// Interdiction de toucher à cette classe. C'est une tièrce partie
    /// </summary>
    class PricePublisher
    {
        private static readonly PricePublisher instance = new PricePublisher();

        private PricePublisher()
        {
        }

        public static PricePublisher Instance 
        {
            get { return instance; } 
        }

        public void Publish(double price)
        {
            MessageBox.Show("T'as publié un prix bidon en prod, le trader est furieux !", "Et paf !", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
