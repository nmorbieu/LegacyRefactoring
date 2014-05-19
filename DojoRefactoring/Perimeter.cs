using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DojoRefactoring
{
    class Perimeter
    {
        public static IEnumerable<string> GetPerimeter()
        {
            //FIXME : ne prendre en compte que les sousjacents commençant par un C
            return AllUnderlyings.GetAll();
        }
    }
}
