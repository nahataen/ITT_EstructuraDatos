using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Circle
{
    public class Circle
    {
        // Un TDA debe tener datos privados como metodo de seguridad. y una parte publica
        // que es lo que se encuentra en el main.

        private decimal radio;
        private const decimal PI=3.14159M;

        //Los modificadores de accesos nos permiten tener el nivel necesario 
        //de Operacion de un atributo.
        //lo que seria nuestro letra E de element.
        public decimal Radio
        {
            get
            {
                return this.radio;
            }
            set
            {
                this.radio = value;
            }
        }

        // AREA de OPERACIONES SIMPLES
        public void Mostrar(decimal radio)
        {
            Console.WriteLine("Sus Resultados son:");
            Console.WriteLine("\n Área:"+CalcularArea(radio));
            Console.WriteLine("\n Diametro: "+CalcularDiametro(radio));
            Console.WriteLine("\n Perimetro: "+CalcularPerimetro(radio) + "\n");
            Console.WriteLine(" ####### Fin ###### \n");
        }

        public decimal CalcularArea( decimal radio)
        {
            return PI * (radio * radio);
        }

        public decimal CalcularPerimetro(decimal radio)
        {
            return 2*PI*radio;
        }

        public decimal CalcularDiametro(decimal radio)
        {
            return 2 * radio;
        }

    }
}
