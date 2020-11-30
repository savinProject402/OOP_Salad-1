using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Salad_1_
{
    public class Vegetables : Components_Abs // овощи
    {
            public Vegetables(double weight, string name, string type, int calories, double prise, string stuffing) 
            : base (weight, name, type, calories, prise)
        {
            Stuffing = stuffing;
        }
        public string Stuffing { get; private set; }
    }
}
