using Clase_ICDIA_Unidad2.HandlersEjerciciosBasicos;

namespace Clase_ICDIA_Unidad2.EjecutoresEjercicios;

public class RunnerSumaAB
{
    public RunnerSumaAB()
    {
        int a, b;
        Console.WriteLine("Dame el valor de A:");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Dame el valor de B:");
        b = int.Parse(Console.ReadLine());

        Ejercicio ejercicio;
        ejercicio = new Ejercicio_SumaAB(a, b);
        ejercicio.Ejecutar();

    }
    
}