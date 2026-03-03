using Clase_ICDIA_Unidad2.HandlersEjerciciosBasicos;

namespace Clase_ICDIA_Unidad2.EjecutoresEjercicios;

public class RunnerEjercicioABNumerosMayor
{
    public RunnerEjercicioABNumerosMayor()
    {
        Console.Write("Ingresa A");
        int a = int.Parse(Console.ReadLine());
        
        Console.Write("Ingresa B");
        int b = int.Parse(Console.ReadLine());
        
        
        Ejercicio ejercicio;
        ejercicio = new EjercicioABNumerosMayor(a,b);
        ejercicio.Ejecutar();
    }
}