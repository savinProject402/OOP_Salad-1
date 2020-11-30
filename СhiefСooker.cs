using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Salad_1_
{
    public class СhiefСooker
    {
        private Components_Abs[] comp = new Components_Abs[0] { };
        private readonly Random rand1;
        private readonly Random rand2;
        private readonly Random rand3;
        public СhiefСooker()
        {
            rand1 = new Random();
            rand2 = new Random();
            rand3 = new Random();
        }
        public void AddVegetablesToSalad(int VegetableСounter)
        {
            Vegetables vege;
            for (int i = 0; i < VegetableСounter; i++)
            {
                var randParametr1 = rand1.Next(1, 100);
                vege = new Vegetables($"Vege:{randParametr1}", randParametr1, "some type", randParametr1, randParametr1, "Stuffing with something");
                Array.Resize<Components_Abs>(ref comp, comp.Length + 1);
                comp[comp.Length - 1] = vege;
            }

        }
        public void AddExtenderToSalad(int ExtenderCounter)
        {
            Extender exten;
            for (int i = 0; i < ExtenderCounter; i++)
            {
                var randParametr2 = rand2.Next(1, 4);
                exten = new Extender($"Extend:{randParametr2}", randParametr2, "some type", randParametr2, randParametr2, "filling with something");
                Array.Resize<Components_Abs>(ref comp, comp.Length + 1);
                comp[comp.Length - 1] = exten;
            }
        }
        public void AddBasisToSalad(int BasisCounter)
        {
            Basis bas;
            for (int i = 0; i < BasisCounter; i++)
            {
                var randParametr3 = rand3.Next(1, 100);
                var randParametr4 = rand3.Next(1, 4);
                bas = new Basis($"Basis:{randParametr4}", randParametr4, "some basis", randParametr3, randParametr3, "bases with something");
                Array.Resize<Components_Abs>(ref comp, comp.Length + 1);
                comp[comp.Length - 1] = bas;
            }
        }
        public void GetWeightOfSalad()
        {
            var calories = 0.0;
            foreach (Components_Abs comps in comp)
            {
                calories += comps.Сalories;
            }
            Console.WriteLine($"Calories Of Salad: {calories}");
        }
        public void SortCaloriesOfSalad()
        {
            Array.Sort(comp, new CaloriesSort());
            PrintAllComponent();
        }
        public void PrintAllComponent()
        {
            foreach (Components_Abs comps in comp)
            {
                Console.WriteLine(GetDatailsComponets(comps));
            }
        }
        public string GetDatailsComponets(Components_Abs comps)
        {
            string result1 = $"Name:{comps.Name}, Calories: {comps.Сalories}, Type: {comps.Type}, Weight:{comps.Weight}";
            return result1;
        }
        public void FindCallories(int compPers)
        {
            var result = Array.Find<Components_Abs>(comp, item => item.Сalories.Equals(compPers));
            Console.WriteLine(GetDatailsComponets(result));
        }
    }
}
