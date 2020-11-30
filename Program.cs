using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Salad_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            СhiefСooker cc = new СhiefСooker();
            cc.AddVegetablesToSalad(3);
            cc.AddExtenderToSalad(1);
            cc.AddBasisToSalad(1);
            Console.WriteLine("-------------------");
            cc.GetWeightOfSalad();
            Console.WriteLine("-------------------");
            cc.PrintAllComponent();
            Console.WriteLine("--------------------");
            cc.SortCaloriesOfSalad();
            Console.ReadLine();
        }
    }
}
