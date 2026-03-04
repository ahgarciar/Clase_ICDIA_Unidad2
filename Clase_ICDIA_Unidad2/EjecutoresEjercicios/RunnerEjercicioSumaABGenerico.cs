using Clase_ICDIA_Unidad2.HandlersEjerciciosBasicos;

namespace Clase_ICDIA_Unidad2.EjecutoresEjercicios;

public class RunnerEjercicioSumaABGenerico
{
    public RunnerEjercicioSumaABGenerico()
    {
        double a, b;
        Console.WriteLine("Dame el valor de a: ");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine("Dame el valor de b: ");
        b = double.Parse(Console.ReadLine());

        Ejercicio ejercicio = new EjercicioSumaAB_Genericos<double>(a, b);
        ejercicio.Ejecutar();
        
    }
    
}