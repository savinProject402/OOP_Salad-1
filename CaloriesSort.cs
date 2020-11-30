using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Salad_1_
{
    public class CaloriesSort : IComparer<Components_Abs>
    {
        public int Compare(Components_Abs c1, Components_Abs c2)
        {
            if (c1.Сalories > c2.Сalories)
                return 1;
            else if (c1.Сalories < c2.Сalories)
                return -1;
            else
                return 0;
        }
    }
}
