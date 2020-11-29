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
        string Type { get; set; } // тип (овощи и другое продовольствие)
        int Сalories { get; set; } // Каллории
        double Prise { get; set; } // цена
    }
    public abstract class Components_Abs : IComponents
    {
        public Components_Abs(double weight, string name, string type, int calories, double prise)
        {
            Weight = weight;
            Name = name;
            Type = type;
            Сalories = calories;
            Prise = prise;
        }
        public double Weight { get; set; }
        public string Name { get; set; } 
        public string Type { get; set; } 
        public int Сalories { get; set; } 
        public double Prise { get; set; } 
    }

}
