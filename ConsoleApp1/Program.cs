using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape s = null;
            string option;

            Console.WriteLine("Elegir la figura a operar: ");
            Console.WriteLine("1. Rectángulo ");
            Console.WriteLine("2. Cuadrado");
            Console.WriteLine("3. Circulo");
            Console.WriteLine("4. Triangulo");
            option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    float rectangleWidth;
                    float rectangleHeight;
                    Console.WriteLine("Introducir la base del rectángulo: ");
                    rectangleWidth = float.Parse(Console.ReadLine());
                    Console.WriteLine("Introducir la altura del rectángulo: ");
                    rectangleHeight = float.Parse(Console.ReadLine());
                    s = new Rectangulo(rectangleWidth, rectangleHeight);
                    break;

                case "2":
                    break;
            }

            if (s != null)
            {
                Console.WriteLine($"El área es {s.GetArea()}");
            }
            else
            {
                Console.WriteLine("No se seleccionó figura");
            }
            Console.ReadLine();

        }
    }
}