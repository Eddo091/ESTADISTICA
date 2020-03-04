using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programacionII_estadistica
{
    class Conversioness
    {
        public string[][] conversor = {
            new string[]{"DOLARES","COLONES SV","YENES","RUPIA","PESO CHILE","PESO MXN","PESO ARG","BITCOIN"}, //monedas
              new string[]{"MEGABYTE","BIT","BYTE","KILOBYTE","GIGABYTE","TERABYTE"} //Almacenamiento
        };
        double[][] valores = {
            //monedas
            new double[]{1,8.75,111.27,69.75,667.08,19.36,39.69,0.00026}, 
            
            //Almacenamiento
            new double[]{1, 8.388608,1.048576, 1.024, 0.0009765625, 0.00000095367431660625 } 
        };
        public double convertir(int opcion, int de, int a, double cantidad)
        {
            return valores[opcion][a] / valores[opcion][de] * cantidad;
        }
        //LISTO
    }
}
