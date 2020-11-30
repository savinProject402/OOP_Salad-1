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
                var randomcount1 = rand1.Next(0, 0);
                var randomcount2 = rand2.Next(25, 100);
                var randomcount3 = rand3.Next(35, 100);
                var randomcount4 = rand3.Next(4, 10);
                vege = new Vegetables($"Vege:{randomcount4}", randomcount2, randomcount1, randomcount3, randomcount1, "Stuffing with something");
                Array.Resize<Components_Abs>(ref comp, comp.Length + 1);
                comp[comp.Length - 1] = vege;
            }

        }
        public void AddExtenderToSalad(int ExtenderCounter)
        {
            Extender exten;
            for (int i = 0; i < ExtenderCounter; i++)
            {
                var randomcount1 = rand1.Next(1, 3);
                var randomcount2 = rand2.Next(70, 250);
                var randomcount3 = rand3.Next(100, 350);
                var randomcount4 = rand3.Next(4, 10);
                exten = new Extender($"Extend:{randomcount1}", randomcount2, randomcount1, randomcount3, randomcount1, "");
                Array.Resize<Components_Abs>(ref comp, comp.Length + 1);
                comp[comp.Length - 1] = exten;
            }
        }
        public void AddBasisToSalad(int BasisCounter)
        {
            Basis bas;
            for (int i = 0; i < BasisCounter; i++)
            {
                var randomcount1 = rand1.Next(1, 3);
                var randomcount2 = rand2.Next(100, 150);
                var randomcount3 = rand3.Next(100, 350);
                var randomcount4 = rand3.Next(4, 10);
                bas = new Basis($"Basis:{randomcount1}", randomcount2, randomcount1, randomcount3, randomcount1,"");
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
