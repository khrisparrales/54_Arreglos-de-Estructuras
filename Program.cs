using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54_Arreglos_de_Estructuras
{
    class Program
    {
        public struct empleado
        {
            public string nombre;
            public int edad;
            public int id;
            public double sueldo;
            public override string ToString()
            {
                StringBuilder cadena = new StringBuilder();
                cadena.AppendFormat("Empleado: {0}, Nombre :{1},Eda:{2}, Sueldo {3}", id, nombre, edad, sueldo);
                return cadena.ToString();
            }

        }
        static void Main(string[] args)
        {

            //variables
            int n = 0;
            empleado[] gente = new empleado[3];
            string dato = "";
            //Pedimos la Informacion
            for (n=0;n<3;n++)
            {
                Console.WriteLine("Ingrese ID del emnpleado");
                dato = Console.ReadLine();
                gente[n].id = int.Parse(dato);
                Console.WriteLine("Ingrese nombre del trabajador");
                gente[n].nombre = Console.ReadLine();
                Console.WriteLine("Ingrese Edad del empleado");
                dato = Console.ReadLine();
                gente[n].edad = int.Parse(dato);
                Console.WriteLine("Ingrese Sueldodel empleado");
                dato = Console.ReadLine();
                gente[n].sueldo = Convert.ToDouble(dato);
            }
            Console.ReadKey();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(gente[i]);
                Console.WriteLine("-------------");
            }
            //Uso de arreglo
            for (int i = 0; i < 3; i++)
            {
                if (gente[i].edad==19) {
                    Console.Write("Eres mayor de edad ");
                    Console.WriteLine(gente[i].nombre);
                    Console.WriteLine("-------------"); }
            }
            Console.ReadKey();
        }
    }
}




