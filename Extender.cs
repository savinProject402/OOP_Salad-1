using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Salad_1_
{
        public class Extender : Components_Abs // майонез/масло
        {
            public Extender(string name, double weight,  string type, int calories, double prise, string filling)
            : base(weight, name, type, calories, prise)
            {
                Filling = filling;
            }
            public string Filling { get; private set; }
        }
}
