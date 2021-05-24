using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace TP05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio1();
            //Ejercicio2();
            //Ejercicio3();
            //Ejercicio4();
            Ejercicio5();
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
        
        public static float calculadora(int opc, float a, float b)
        {
            var calculo = new Dictionary<int, float>
            {
                [1] = a + b,
                [2] = a - b,
                [3] = a * b,
                [4] = a / b,
            };

            return calculo[opc];
        }
        private static void Ejercicio2()
        {
            String[] operaciones = {"Suma", "Resta", "Multiplicación", "División"};
            float a, b, resultado = 0;
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

                    resultado = calculadora(opcion, a, b);
                    // switch (opcion)
                    // {
                    //     case 1:
                    //         resultado = a + b;
                    //         break;
                    //     case 2:
                    //         resultado = a - b;
                    //         break;
                    //     case 3:
                    //         resultado = a * b;
                    //         break;
                    //     case 4:
                    //         resultado = a / b;
                    //         break;
                    // }
                    Console.WriteLine($"La {operaciones[opcion - 1]} entre {a} y {b} es igual a: {resultado}");

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
            String cadena, cadenaBuscada, nuevaCadena;
            String[] arreglo;
            int longitud;

            Console.WriteLine("Ingrese una String");
            cadena = Console.ReadLine().Trim();
            longitud = cadena.Length;

            //Obtengo la segunda letra de la palabra ingresada
            Console.WriteLine($"La primera letra de {cadena} es {cadena[0]}");
            //Muestro la longitud
            Console.WriteLine($"Su longitud es {longitud}");
            //Concateno 2 cadenas
            cadena += " es una cadena";
            Console.WriteLine($"Concatenando: {cadena}");
            //Extraigo una subcadena
            cadena = cadena.Substring(0, longitud);
            Console.WriteLine($"Obtengo la cadena original: {cadena}");

            //Muestro de una forma mas amena el resultado de la calculadora en el ejercicio 2

            //Recorrer la cadena de texto con un ciclo Foreach e ir mostrando elemento por elemento en pantalla
            foreach (var letra in cadena)
            {
                Console.WriteLine(letra);
            }

            //Buscar la ocurrencia de una palabra determinada en la cadena ingresada
            Console.WriteLine("Ingrese una subcadena para buscar:");
            cadenaBuscada = Console.ReadLine().Trim();
            Console.WriteLine($"La subcadena '{cadenaBuscada}' {(cadena.Contains(cadenaBuscada) ? "está" : "no está")} dentro de la cadena '{cadena}'");
        
            //Convierta la cadena a Mayúsculas y luego minúsculas
            Console.WriteLine($"En mayusculas: '{cadena.ToUpper()}', en minusculas: '{cadena.ToLower()}'");
            
            //Ingrese una nueva cadena y luego compare los valores de ambas.
            Console.WriteLine("Ingrese una nueva cadena para comparar:");
            nuevaCadena = Console.ReadLine().Trim();
            Console.WriteLine($"{(cadena.Equals(nuevaCadena) ? "Las cadenas son iguales." : "Las cadenas son diferentes.")}");

            //Ingrese una cadena separada por caracteres que usted determine y muestre por
            //pantalla los resultados (Revisar el comportamiento de split())
            Console.WriteLine("Ingrese una cadena de palabras separadas por coma (,):");
            nuevaCadena = Console.ReadLine().Trim();
            foreach (var subCadena in nuevaCadena.Split(','))
            {
                //El metodo Split retorna un arreglo de cadenas separadas por el carácter enviado por parametro
                Console.WriteLine($"{subCadena}");                
            }

            //  Siguiendo con el ejemplo de la calculadora (ejercicio 2) ingrese una ecuación
            // simple como cadena de caracteres y que el sistema lo resuelva. Por ej. ingrese
            // por pantalla “582+2” y que le devuelva la suma de 582 con 2
            Console.WriteLine("Ingrese una ecuación simple:");
            cadena = Console.ReadLine().Trim();

            if(cadena.Contains('+'))
            {
                arreglo = cadena.Split('+');   
                Console.WriteLine($"El resultado de la operación es: {calculadora(1, int.Parse(arreglo[0]), int.Parse(arreglo[1]))}");
            }
            else if(cadena.Contains('-'))
            {
                arreglo = cadena.Split('-');   
                Console.WriteLine($"El resultado de la operación es: {calculadora(2, int.Parse(arreglo[0]), int.Parse(arreglo[1]))}");
            }
            else if(cadena.Contains('*'))
            {
                arreglo = cadena.Split('*');   
                Console.WriteLine($"El resultado de la operación es: {calculadora(3, int.Parse(arreglo[0]), int.Parse(arreglo[1]))}");
            }
            else if(cadena.Contains('/'))
            {
                arreglo = cadena.Split('+');   
                Console.WriteLine($"El resultado de la operación es: {calculadora(4, int.Parse(arreglo[0]), int.Parse(arreglo[1]))}");
            }
            else
            {
                Console.WriteLine("La cadena ingresada no es una ecuación.");
            }
        }

        public static bool validarDireccion(string cadena)
        {
            // Una dirección puede tener protocolo de seguridad o no, www o no, y una extesnsión
            Regex miRegex = new Regex(@"\A(https?://)?(([w]{3})\.)?[a-z0-9]+(\.)([a-z]{2,4})(\.[a-z]+)?\Z");

            return miRegex.Matches(cadena).Count > 0;
        }

        public static bool validarMail(string cadena)
        {
            // Un mail puede o no tener puntos de por medio, debe contener un @ y un .[algo]
            Regex miRegex = new Regex(@"\A(\w+\.?\w*\@\w+\.)([a-z]+)(\.[a-z]+)?\Z");

            return miRegex.Matches(cadena).Count > 0;
        }

        public static void Ejercicio5()
        {
            string direccion = "megustanlossimpsons.net.ar", mail = "profesorx@herrera.edu.ar";

            if (validarDireccion(direccion.ToLower()))
                Console.WriteLine("El texto ingresado es una dirección web.");
            else
                Console.WriteLine("El texto ingresado NO(x) es una dirección web.");

            if (validarMail(mail.ToLower()))
                Console.WriteLine("El texto ingresado es un mail.");
            else
                Console.WriteLine("El texto ingresado NO(x) es un mail.");

        }
        
    }
}
