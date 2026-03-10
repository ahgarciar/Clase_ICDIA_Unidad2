using Clase_ICDIA_Unidad2.HandlersEjerciciosBasicos;

namespace Clase_ICDIA_Unidad2.EjecutoresEjercicios;

public class RunnerLineaRecta
{
    public RunnerLineaRecta()
    {
        int m, x, b;
        bool se_ejecuto = false;
        while (!se_ejecuto)
        {
            try
            {
                //inicio de la validación de código
                //Console.WriteLine......
                m = 10;//int.Parse(Console.ReadLine());
                //Console.WriteLine......
                x = -2;
                //Console.WriteLine......
                b = 4;

                Ejercicio ejercicio;
                ejercicio = new Ejercicio_LineaRecta<int>(m, x, b);
                ejercicio.Ejecutar();

                se_ejecuto = true;
            } //fin del espacio de validacion de código
            catch (Exception ex)
            {
                Console.WriteLine("Error encontrado: " + ex.Message);
                se_ejecuto = false;
            }
            finally
            {
                Console.WriteLine("Intento de Ejecución Terminado!");
            }
        }
        
    }
}