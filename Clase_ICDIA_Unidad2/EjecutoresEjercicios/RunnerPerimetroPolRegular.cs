using Clase_ICDIA_Unidad2.HandlersEjerciciosBasicos;

namespace Clase_ICDIA_Unidad2.EjecutoresEjercicios;

public class RunnerPerimetroPolRegular
{
    public RunnerPerimetroPolRegular()
    {
        int cantidad_lados;
        int longitud_lado;

        try
        {
            Console.WriteLine("Ingresa la cantidad de lados:");
            cantidad_lados = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa la longitud de un lado:");
            longitud_lado = int.Parse(Console.ReadLine());

            Ejercicio ejercicio;
            ejercicio = new Ejercicio_PerimetroPoligonoRegular<int>(
                longitud_lado, cantidad_lados);
        }
        catch (ArgumentException argumentException)
        {
            Console.WriteLine(argumentException.Message);
            Console.WriteLine("Un argumento no cumple las reestricciones de entrada");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        


    }
}