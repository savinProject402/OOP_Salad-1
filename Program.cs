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
            cc.AddVegetablesToSalad(5); // кол-во овощей
            cc.AddExtenderToSalad(1); // заправка майонез или масло
            cc.AddBasisToSalad(1); // мясной или рыбный
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
