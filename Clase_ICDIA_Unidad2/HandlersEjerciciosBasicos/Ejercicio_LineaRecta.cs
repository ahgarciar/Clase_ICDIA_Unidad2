using System.Numerics;

namespace Clase_ICDIA_Unidad2.HandlersEjerciciosBasicos;

public class Ejercicio_LineaRecta<T> : Ejercicio where T: INumber<T> 
{
    // y = mx + b
    private T valor_m; //snake_case - (puede ser camelCase)
    private T valor_x;
    private T valor_b;
    
    public T ValorM //PascalCase
    {
        get => valor_m;
        set => valor_m = value;
    }

    public T ValorX
    {
        get => valor_x;
        set
        {
            if (value.CompareTo(0) > 0)
            {
                valor_x = value;       
            }
            else
            {
               throw new ArgumentException("El valor es invalido"); 
            }

        }
    }

    public T ValorB
    {
        get => valor_b;
        set => valor_b = value;
    }

    public Ejercicio_LineaRecta(T m, T x, T b)
    : base(14, "Linea Recta",
        "Genera un punto de una line recta")
    {
        //try
        //{
            ValorM = m;
            ValorX = x;
            ValorB = b;
        //}
        //catch (Exception ex)
        //{
            
        //}
    }

    public override void Ejecutar()
    {
        // y = mx + b
        T resultado = ValorM * ValorX + ValorB;
        Console.WriteLine($"El resultado es {resultado}.");
    }

}