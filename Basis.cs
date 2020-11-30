using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Salad_1_
{
    public class Basis : Components_Abs // мясо/рыба
    {
        public Basis(string name, double weight, int type, int calories, double prise, string bases)
        : base(weight, name, type, calories, prise)

        {
            Bases = bases;
        }
        public string Bases { get; private set; }

    }
}
