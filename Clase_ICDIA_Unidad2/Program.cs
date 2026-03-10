using Clase_ICDIA_Unidad2.EjecutoresEjercicios;
using Clase_ICDIA_Unidad2.HandlersEjerciciosBasicos;

namespace Clase_ICDIA_Unidad2;

public class Program
{
    //punto de Entrada
    public static void Main(string[] args)
    {
        Console.WriteLine("Clase_ICDIA_Unidad2");

        List<Ejercicio> listaEjercicios = new List<Ejercicio>();
        listaEjercicios.Add(new Ejercicio_ParImpar());
        listaEjercicios.Add(new Ejercicio_PerimetroPoligonoRegular<int>());

        foreach (Ejercicio item in listaEjercicios)
        {
            Console.WriteLine(item);
        }
        

        int idx = 15; 
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
            case 14:
                new RunnerLineaRecta();
                break;
            case 15:
                new RunnerPerimetroPolRegular();
                break;
            default:
                Console.WriteLine("Opción no valida");
                break;
        }


    }
}

