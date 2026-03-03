using Clase_ICDIA_Unidad2.HandlersEjerciciosBasicos;

namespace Clase_ICDIA_Unidad2.EjecutoresEjercicios;

public class RunnerEjercicio_ParImpar
{
    public RunnerEjercicio_ParImpar()
    {
        
     Console.WriteLine("Ingresa un número:");
     int n = int.Parse(Console.ReadLine());

     Ejercicio ejercicio;
     ejercicio = new Ejercicio_ParImpar(n);
     ejercicio.Ejecutar();
     
    }
}