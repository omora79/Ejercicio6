// Escribir un programa que convierta un valor dado en grados Fahrenheit a grados Celsius.

// 1 clase y metodo

public class Ejercicio6
{
    static void Main(string[] args)
    {

        // 2 definicion de variables

        int farenhait, celcius;

        // pedir datos por pantalla

        Console.WriteLine("Ingrese las grados medidos en Farenhait: ");
        farenhait = Convert.ToInt32(Console.ReadLine());

        // 4 realizar los calculos

        celcius = ((farenhait - 32) * 5 / 9);

        // 5 mostrar resultados en pantalla

        Console.WriteLine($"La conversion de {farenhait} grados farenhait es de {celcius} grados celcuis");


    }
}