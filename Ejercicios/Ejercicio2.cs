using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISC_103_Examen_U1_MenjivarJose.Ejercicios
{
    public class Ejercicio2
    {
        public void SimuladorCargaCombustible()
        {
            Console.WriteLine("=== Simulador de Carga Combustible ===");
            Console.WriteLine("Seleccione el tipo de combustible deseado :");
            Console.WriteLine("1. regular");
            Console.WriteLine("2. premium");
            Console.WriteLine("3. diesel");
            Console.Write("Ingrese el número de la opción deseada : ");

            int opcion = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Cuantos litros desea");
            Console.WriteLine("1. 10");
            Console.WriteLine("2. 20");
            Console.WriteLine("3. 30");
            Console.WriteLine("4. 40");
            Console.WriteLine("5. 50");
            Console.WriteLine("6. 60");
            Console.Write("Ingrese el número de la opción deseada : ");

            int litros = Convert.ToInt32(Console.ReadLine());

            double regular = 28.50;
            double premium = 32.00;
            double diesel = 26.75;
            
            
        }
    }
}