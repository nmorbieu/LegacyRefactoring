using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DojoRefactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            var massPricerPublisher = new MassPricerPublisher();
            massPricerPublisher.PriceAndPublishEverything();
        }
    }
}
