using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace DojoRefactoring.ThirdParties
{
    class MarketDataRetriever
    {
        public double GetClose(string underlying)
        {
            if (ConfigurationManager.AppSettings["licence"] == null)
            {
                MessageBox.Show("Pas de licence !", "Licence pénible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new ConfigurationException();
            }
            return ((double) underlying.GetHashCode() * (new Random()).NextDouble());
        }
    }
}
