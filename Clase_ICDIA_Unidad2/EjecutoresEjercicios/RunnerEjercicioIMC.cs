using Clase_ICDIA_Unidad2.HandlersEjerciciosBasicos;

namespace Clase_ICDIA_Unidad2.EjecutoresEjercicios;

public class RunnerEjercicioIMC
{
    public RunnerEjercicioIMC()
    {
        double[] parametros = new double[2];
        Console.WriteLine("Dame el peso:");
        parametros[0] = double.Parse(Console.ReadLine());
        Console.WriteLine("Dame el altura:");
        parametros[1] = double.Parse(Console.ReadLine());

        Ejercicio ejercicio;
        ejercicio = new Ejercicio_IMC<double>(parametros[0], 
            parametros[1]);
        ejercicio.Ejecutar();
        
    }
}