using System;

namespace TP05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio1();
            //Ejercicio2();
            //Ejercicio3();
            Ejercicio4();


            /*****Ejercicio 2*****/
        }

        private static int invertir(int numero)
        {
            int invertido = 0;

            while (numero > 0)
            {
                invertido = invertido * 10 + numero % 10;
                numero = numero / 10;
            }
            //Si el numero es negativo devuelvo el numero sin invertir, sino el invertido.
            return (numero < 0) ? numero : invertido;
        }

        private static void Ejercicio1()
        {
            int num;

            Console.WriteLine("Ingrese un numero:");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Invertido: " + invertir(num) + "\n\n");
        }

        private static void Ejercicio2()
        {
            int a, b, resultado = 0;
            int opcion;
            String respuesta;
            bool reDo;

            do
            {
                reDo = false;
                Console.WriteLine("¿Que operacion desea realizar?\n1: Suma\n2: Resta\n3: Producto\n4: Cociente");
                opcion = int.Parse((Console.ReadLine()));

                if (opcion > 0 && opcion < 5)
                {
                    Console.WriteLine("Ingrese el primer valor: ");
                    a = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el segundo valor: ");
                    b = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            resultado = a + b;
                            break;
                        case 2:
                            resultado = a - b;
                            break;
                        case 3:
                            resultado = a * b;
                            break;
                        case 4:
                            resultado = a / b;
                            break;
                    }
                    Console.WriteLine("El resultado es: " + resultado);

                    Console.WriteLine("¿Desea realizar otra operación? (S/N)");
                    respuesta = Console.ReadLine();

                    if (respuesta.ToLower() == "s")
                        reDo = true;
                    else
                        reDo = false;
                }
                else 
                {
                    Console.WriteLine("El valor ingresado es incorrecto. Intentelo de nuevo");
                    reDo = true;
                }
            } while(reDo);
        }

        public static void Ejercicio3()
        {
            float a, b;

            Console.WriteLine("Ingrese un número");
            a = float.Parse(Console.ReadLine());

            Console.WriteLine($"El valor absoluto de {a} es {Math.Abs(a)}");
            Console.WriteLine($"El cuadrado de {a} es {Math.Pow(a, 2)}");
            Console.WriteLine((a > 0) ? $"La raíz cuadrada de {a} es {Math.Sqrt(a)}" : $"{a} no tiene raiz cuadrada.");
            Console.WriteLine($"El seno de {a} es {Math.Sin(a)}");
            Console.WriteLine($"El coseno de {a} es {Math.Cos(a)}");
            Console.WriteLine($"El parte entera de {a} es {(int) a}");

            Console.WriteLine("Ingrese dos numeros");
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());

            Console.WriteLine($"El máximo es {Math.Max(a, b)}");
            Console.WriteLine($"El minimo es {Math.Min(a, b)}");
        }

        public static void Ejercicio4()
        {
            
        }
    }
}
