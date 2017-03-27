using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa4
{
    //&p-Main
    class Program
    {
        //&i
        static void Main(string[] args)
        {
            double dof;
            double x;
            dof = 0;
            x = 0;

            try
            {
                x = double.Parse(Console.ReadLine());
                dof = double.Parse(Console.ReadLine());
                double num_seg;
                double resta;
                num_seg = 10;

                Simpson simpsonA = new Simpson();
                Simpson simpsonB = new Simpson(x, dof, num_seg + 10);
                resta = simpsonA.FuncionP() - simpsonB.FuncionP();
                do
                {
                    simpsonA = simpsonB;
                    num_seg = num_seg + 10;
                    simpsonB = new Simpson(x, dof, num_seg);
                    resta = simpsonA.FuncionP() - simpsonB.FuncionP();
                }
                while (Math.Abs(resta) >= 0.0000001);
                Console.WriteLine("x = " + x.ToString("N5") + "\ndof = " + dof + "\np = " + Math.Round(simpsonB.FuncionP(), 5).ToString("N5"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
