using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa4
{
    //&p-Simpson
    class Simpson
    {
        private double x;       //rango que se calculará ( 0 a x )
        private double dof;     //grado de libertad
        private double num_seg; //número de segmentos
        private double width;   //ancho del segmento

        //&i
        public Simpson()
        {
            x = 0;
            dof = 0;
            num_seg = 0;
            width = 0;
        }
        //&i
        public Simpson(double x, double dof, double num_seg)
        {
            this.x = x;
            this.dof = dof;
            this.num_seg = num_seg;
            this.width = this.x / this.num_seg;
        }
        //&i
        public double FuncionP()
        {
            double dXi, dResultado;
            int iMultiplier;
            dXi = 0;
            dResultado = 0;
            Distribucion distribucion;

            for (int iA = 0; iA <= num_seg; iA++)
            {
                distribucion = new Distribucion(dXi, dof);

                if (iA == 0 || iA == num_seg)
                {
                    iMultiplier = 1;
                }
                else if (iA % 2 == 0)
                {
                    iMultiplier = 2;
                }
                else
                {
                    iMultiplier = 4;
                }
                dResultado = dResultado + (((width / 3) * iMultiplier * distribucion.FuncionF()));
                dXi = dXi + width;
            }
            return dResultado;
        }
    }
}
