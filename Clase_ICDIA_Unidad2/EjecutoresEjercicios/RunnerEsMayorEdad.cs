using Clase_ICDIA_Unidad2.HandlersEjerciciosBasicos;

namespace Clase_ICDIA_Unidad2.EjecutoresEjercicios;

public class RunnerEsMayorEdad
{
    public RunnerEsMayorEdad()
    {
        Console.WriteLine("Dame la edad de la persona");
        int edad = int.Parse(Console.ReadLine());

        Ejercicio ejercicio;
        ejercicio = new Ejercicio_CompruebaMayoriaEdad(edad);
        ejercicio.Ejecutar();
    }
}