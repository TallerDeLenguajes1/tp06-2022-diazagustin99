// See https://aka.ms/new-console-template for more information
Console.WriteLine("jjj, World!");
Calculadora calculadora = new Calculadora(0);
int opcion = 0;
do
{
    Console.WriteLine("1-Sumar");
    Console.WriteLine("2-Restar");
    Console.WriteLine("3-Multiplicar");
    Console.WriteLine("4-Dividir");
    Console.WriteLine("5-Limpiar");
    Console.WriteLine("6-Salir");
    Console.WriteLine("Ingrese una opcion");
    String aux = Console.ReadLine();
    opcion = Convert.ToInt32(aux);
    switch (opcion)
    {
        case 1:
            Console.WriteLine("Escriba un numero:");
            String numero = Console.ReadLine();
            calculadora.suma(Convert.ToInt32(numero));
            Console.WriteLine("El resultado de la suma es: " + calculadora.Resultado);
            break;

        case 2:
            Console.WriteLine("Escriba un numero:");
            numero = Console.ReadLine();
            calculadora.Resta(Convert.ToInt32(numero));
            Console.WriteLine("El resultado de la resta es: " + calculadora.Resultado);
            break;

        case 3:
            Console.WriteLine("Escriba un numero:");
            numero = Console.ReadLine();
            calculadora.Multiplicar(Convert.ToInt32(numero));
            Console.WriteLine("El resultado de la Multiplicacion es: " + calculadora.Resultado);
            break;

        case 4:
            Console.WriteLine("Escriba un numero:");
            numero = Console.ReadLine();
            bool resul = calculadora.Dividir(Convert.ToInt32(numero));
            if (resul)
            {
                Console.WriteLine("El resultado de la Division es: " + calculadora.Resultado);
            }
            else
            {
                Console.WriteLine("No se puede dividir en 0.");
            }
            break;

        case 5:
            calculadora.Limpiar();
            Console.WriteLine("Se Limpio el resultado, ahora vale 0.");
            break;

        case 6:
            Console.WriteLine("Cerro el programa con exito.");
            break;

        default:
            Console.WriteLine("Selecciono una opcion no valida.");
            break;
    }

} while (opcion != 6);



