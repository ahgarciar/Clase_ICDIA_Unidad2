using Clase_ICDIA_Unidad2.EjecutoresEjercicios;

namespace Clase_ICDIA_Unidad2;

public class Program
{
    //punto de Entrada
    public static void Main(string[] args)
    {
        Console.WriteLine("Clase_ICDIA_Unidad2");

        int idx = 9; 
        switch (idx)
        {
            case 1:
                new RunnerEjercicio_ParImpar();
                break;
            case 2:
                new RunnerSumaAB();
                break;
            case 3:
                new RunnerEsMayorEdad();
                break;
            case 4:
                new RunnerEjercicioABNumerosMayor();
                break;
            case 7:
                new RunnerEjercicioSumaABGenerico();
                break;
            case 8:
                new RunnerEjercicioIMC();
                break;
            case 9:
                new RunnerDistanciaEntreDosPuntos();
                break;
            default:
                Console.WriteLine("Opción no valida");
                break;
        }


    }
}

