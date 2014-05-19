using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DojoRefactoring
{
    static class AllUnderlyings
    {
        public static IEnumerable<string> GetAll()
        {
            Thread.Sleep(5000); //Les accès à la base de données sont super lents
            return new[] { "Cacao", "Sucre", "Petrole", "Carcasses de porc", "Or", "Cuivre" };
        }
    }
}
