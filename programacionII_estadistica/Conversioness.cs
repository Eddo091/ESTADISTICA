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
            new string[]{"Dolares","Euros","Quetzalez","Lempira","Cordobas","Colon CR","Dolar Canadience","Peso Chileno","Peso Arg","Yen JPY","Won SurCoreano","Won Norcoreano","MXN","Rupia India","Corona Danesa","Dirham Marroqui", "Escudo caboverdiano", "Pula botsuanés", "Dolar bahameño", "Corona noruega"}, //monedas
            new string[]{"Metros","CM","Pulgadas","Pie","Varas","Yardas","Micrometro","Nanometro"}, //Longitud
            new string[]{"Libra","Gramos","Kilogramos","Onzas","Quintales","Toneladas","Tonelada larga","Tonelada Corta"}, //Peso
             new string[]{ "Libra", "Mililitro", "Galon imperial", "Cuarto imperial","Pinta imperial","Taza Imperial","Onza liquida imperial"}, //Volumen
              new string[]{"Bit","Byte","Kilobyte","Megabyte","Gygabyte","Terabyte","Petabyte"} //Almacenamiento
        };
        double[][] valores = {
            //monedas
            new double[]{1,0.92,7.65,24.9,34.22,572.26,1.33458,813.003,62.0138, 110.315, 1216.21, 900.072, 19.3635, 71.6572, 6.85392, 9.68004, 101.144, 11.0795, 1.00000, 9.39713}, 
            //Longitud
            new double[]{1,100,39.37,3.281,1.196,1.094,1e+6,1e+9}, 
            //Peso
            new double[]{1, 453.592, 0.453592, 16, 0.000453592,0.000453592,0.000446429,0.0005}, 
            //Volumen
            new double[]{1,1000, 0.219969, 0.879877, 1.759752,3.519504309673087,35.1950799988562}, 
            //Almacenamiento
            new double[]{1, 0.125, 0.000125, 1.25e-7, 1.25e-10 , 1.25e-13, 1.25e-16 } 
        };
        public double convertir(int opcion, int de, int a, double cantidad)
        {
            return valores[opcion][a] / valores[opcion][de] * cantidad;
        }
    }
}
