using System;
using Library_Circle;
namespace Ej_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Área Visual solo para el usuario se pueden implementar solo un metodo, o 
            // Los metodos necesarios para su implementación, por ejemplo puede ser solo perimetro, o area , o diametro
            // Segun lo que Pueda o requiera utilizar el desarrollador.

            Console.WriteLine("Introduzca un numero de radio o finalice el programa con -1");
            string radio = Console.ReadLine();
            while (radio!="-1")
            {
                Circle circle = new Circle();
                try
                {
                    decimal r = 0;
                    bool isNumeric = decimal.TryParse(radio, out r);
                    if (isNumeric == true)
                    {
                        circle.Mostrar(r);
                    }
                    else
                    {
                        Console.WriteLine("Introduzca un numero valido, solo se aceptan caracteres numericos \n");
                    }

                    
                }
                catch (Exception e)
                {

                    Console.WriteLine("Sus datos no corresponden a un numero");
                }

                Console.WriteLine("Introduzca un numero de radio o finalice el programa con -1");
                 radio = Console.ReadLine();
            }

            Console.WriteLine("#####  Gracias por Usar Nuestra App  #####");
            Console.ReadLine();
        }
    }
}
