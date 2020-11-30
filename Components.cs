using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Salad_1_
{
    interface IComponents
    {
        double Weight { get; set; } // вес
        string Name { get; set; } // имя
        int Type { get; set; } // тип 
        int Сalories { get; set; } // Каллории
        double Prise { get; set; } // цена
    }
    public abstract class Components_Abs : IComponents
    {
        public Components_Abs(double weight, string name, int type, int calories, double prise)
        {
            Weight = weight;
            Name = name;
            Type = type;
            Сalories = calories;
            Prise = prise;
        }
        public double Weight { get; set; }
        public string Name { get; set; } 
        public int Type { get; set; } 
        public int Сalories { get; set; } 
        public double Prise { get; set; } 
    }

}
