using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            Console.WriteLine("\n*********** Sintaxis de estructura de cotrol selectivas en C# ***********");
            Console.WriteLine("\nOPCIONES:");
            Console.WriteLine("1. Determinar si el número es positivo, negativo o igual a cero");
            Console.WriteLine("2. Mostrar fecha y hora actual");
            Console.WriteLine("3. Determinar si puede votar y conducir legalmlente");
            Console.WriteLine("4. Determinar si el número es par o impar");
            Console.WriteLine("\n -----Elija una opción----- ");
            int opción = Convert.ToInt32(Console.ReadLine());

            if (opción == 1){
                Console.WriteLine("\nIngrese un número:");
                int numero = Convert.ToInt32(Console.ReadLine());
                if (numero > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nSu número es positivo.\n");
                }

                else if (numero < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nSu número es negativo.\n");
                }

                else{
                     Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nSu número es igual a cero.\n");
                }
            }

            else if (opción == 2){
                Console.ForegroundColor = ConsoleColor.Red;
                DateTime fechaHahora = DateTime.Now;
                Console.WriteLine("\nLa fecha y hora actual es: " + fechaHahora + "\n");
            }

            else{
                switch (opción)
                {
                    case 3:
                        Console.WriteLine("Ingese su edad:");
                        int edad = Convert.ToInt32(Console.ReadLine());

                        if (edad >= 18)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nEres mayor de edad, puedes votar y conducir legalmente. :)\n");
                        }

                        else{
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nEres menor de edad, no puedes votar ni conducir legalmente. :(\n");  
                        }
                        break;

                        case 4:
                        Console.WriteLine("Ingese un número:");
                        int numero = Convert.ToInt32(Console.ReadLine());

                        if (numero % 2 == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nEl número igresado es un número par. \n");
                        }

                        else{
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nEl número igresado es un número impar. \n");  
                        }
                        break;
                    default:
                        Console.WriteLine("\n ¡¡¡¡¡¡OPCIÓN INVALIDA, INTENTE DE NUEVO!!!!!!\n");
                        break;
                }
            }
            Console.ReadKey();
            Console.ResetColor();
        }
    }
}
