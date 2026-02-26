using Clase_ICDIA_Unidad2.EjerciciosBasicos;

namespace Clase_ICDIA_Unidad2;

public class Program
{
    //punto de Entrada
    public static void Main(string[] args)
    {
        Console.WriteLine("Clase_ICDIA_Unidad2");

        Ejercicio ejercicio;

        ejercicio = new Ejercicio_ParImpar(5);
        ejercicio.Ejecutar();


    }
}

