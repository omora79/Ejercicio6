//Escribir un programa que convierta un valor dado en grados Fahrenheit a grados Celsius.

//1 clase y metodo

public class Ejercicio6
{
    static void Main(string[] Args)
    {
        // 2 Determinar las variables

        double celcius, farenhait;

        //3 pedir datos

        Console.WriteLine("Dijete el valor en grados F: ");
        farenhait = Convert.ToDouble(Console.ReadLine());

        // 4 realizar calculos (32 °F − 32) × 5/9 = 0 °C

        celcius = (farenhait - 32) * 5/9;

        // mostrar en pantalla

        Console.WriteLine($"los {farenhait} grados Farenhait  equivalen a {celcius} grados celcius" );



    }

}