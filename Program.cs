using System;

class ejercicio6
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el sueldo bruto:");
        double sueldoBruto = Convert.ToDouble(Console.ReadLine());

        double aumento = 10;

        double sueldoFinal = AplicarAumento(sueldoBruto, aumento);

        Console.WriteLine("El sueldo final es: " + sueldoFinal);
    }

    static double AplicarAumento(double sueldoBruto, double aumento)
    {
        double aumentoMonetario = (sueldoBruto * aumento) / 100;
        return sueldoBruto + aumentoMonetario;
    }
}