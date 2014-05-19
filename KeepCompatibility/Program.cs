using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DojoRefactoring;

namespace KeepCompatibility
{
    /// <summary>
    /// Classe à ne pas modifier. Ça doit compiler et fonctionner comme avant (aux corrections de bug près)
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var massPricerPublisher = new MassPricerPublisher();
            massPricerPublisher.PriceAndPublishEverything();
        }
    }
}
