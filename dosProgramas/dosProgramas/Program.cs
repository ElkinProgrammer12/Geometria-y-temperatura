using System;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace EjerciciosHP
{
    internal class Program
    {
        public static float valor1 = 0;
        public static float valor2 = 0;
        static void Main(string[] args)
        {
            Programas();
        }
        public static void Programas()
        {
            int eleccion = 0, item, item1;
            do
            {
                Console.WriteLine("\t" + "\t" + "|<><><><><><><><><><><><><><><><><><><><><|");
                Console.WriteLine("\t" + "\t" + "|Marca 1 para entrar a programa Geometría |");
                Console.WriteLine("\t" + "\t" + "|Marca 2 para entrar a programa Conversión|");
                Console.WriteLine("\t" + "\t" + "|Marca 3 para salir del Software          |");
                Console.WriteLine("\t" + "\t" + "|<><><><><><><><><><><><><><><><><><><><><|");
                Console.Write("Señala tu elección: ");
                eleccion = int.Parse(Console.ReadLine());
                switch (eleccion)
                {
                    case 1:
                        Console.Write("Marca 1 Cuadrado,2 Triángulo o 3 Círculo: ");
                        item = int.Parse(Console.ReadLine());
                        if (item == 1)
                        {
                            Console.Write("Favor ingrese el largo: ");
                            valor1 = float.Parse(Console.ReadLine());
                            Console.Write("Favor ingrese el ancho: ");
                            valor2 = float.Parse(Console.ReadLine());
                            float resultado1 = Cuadrado(valor1, valor2);
                            Console.WriteLine("El área del cuadrado es: " + resultado1);
                        }
                        if (item == 2)
                        {
                            Console.Write("Favor ingrese la base: ");
                            valor1 = float.Parse(Console.ReadLine());
                            Console.Write("Favor ingrese la altura: ");
                            valor2 = float.Parse(Console.ReadLine());
                            float resultado2 = Triangulo(valor1, valor2);
                            Console.WriteLine("El área del cuadrado es: " + resultado2);
                        }
                        else if (item == 3)
                        {
                            Console.Write("Favor ingresa el radio del círculo: ");
                            valor1 = float.Parse(Console.ReadLine());
                            float resultado3 = Circulo(valor1);
                            Console.WriteLine("El área del cuadrado es: " + resultado3);
                        }
                        Finalizar();
                        break;
                    case 2:
                        Console.WriteLine("Marca 1 Conversión de Fahrenheit a Celsius");
                        Console.WriteLine("Marca 2 Conversión de Celsius a Fahrenhein");
                        Console.Write("¿Cuál es tu elección?: ");
                        item1 = int.Parse(Console.ReadLine());
                        if (item1 == 1)
                        {
                            Console.Write("Ingresa los grados en Fahrenheit: ");
                            valor1 = float.Parse(Console.ReadLine());
                            float proceso1 = Fahrenheit(valor1);
                            Console.WriteLine("La conversión de Fahrenheit a Celsius es: " + proceso1);
                        }
                        else if (item1 == 2)
                        {
                            Console.Write("Ingresa los grados en Celsius: ");
                            valor1 = float.Parse(Console.ReadLine());
                            float proceso2 = Celsius(valor1);
                            Console.WriteLine("La conversión de Celsius a Fahrenheit es: " + proceso2);
                            Finalizar();
                        }
                        break;
                    case 3:
                        Console.WriteLine("Gracias por usar nuestros servicios");
                        break;
                    default:
                        Console.WriteLine("La opción que marcas no es válida. intenta de nuevo");
                        break;
                }
            } while (eleccion != 3);
        }
        public static float Cuadrado(float dato1, float dato2) => dato1 * dato2;

        public static float Triangulo(float dato1, float dato2) => (dato1 * dato2) / 2;

        public static float Circulo(float dato1) => (31416) * dato1 * dato1;

        public static float Fahrenheit(float dato1) => ((dato1 - 32) * 5) / 9;

        public static float Celsius(float dato1) => (dato1 / 5) * 9 + 32;
        public static void Finalizar()
        {
            Console.WriteLine("¿Quieres continuar en el programa?");
            Console.WriteLine("Marca S para continuar o N para salir");
            string nuevo = (Console.ReadLine());
            nuevo = nuevo.ToUpper();
            if (nuevo == "S")
            {
                Console.Clear();
                Programas();
            }
            else if (nuevo == "N")
            {
                Console.WriteLine("Finalizas el programa");
                System.Environment.Exit(0);
            }
        }
    }
}
