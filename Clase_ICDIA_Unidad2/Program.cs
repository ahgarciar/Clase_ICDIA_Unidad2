using Clase_ICDIA_Unidad2.EjecutoresEjercicios;
using Clase_ICDIA_Unidad2.HandlersEjerciciosBasicos;
using Clase_ICDIA_Unidad2.JuegosAzar;
using Clase_ICDIA_Unidad2.ListasGenericas;
using Clase_ICDIA_Unidad2.RPG_Mini;

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
        

        int idx = 24; 
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
            case 20:
                new Ej2_ListaEnlanzada();
                break;
            case 21:
                new Ej3_Lista();
                break;
            case 22:
                new Ej4_pokemon();
                break;
            case 23:
                new JuegoDado();
                break;
            case 24:
                new MainJuego();
                break;
            default:
                Console.WriteLine("Opción no valida");
                break;
        }


    }
}

