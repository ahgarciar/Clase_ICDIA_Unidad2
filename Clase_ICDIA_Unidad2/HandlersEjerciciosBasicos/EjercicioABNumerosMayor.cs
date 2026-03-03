namespace Clase_ICDIA_Unidad2.HandlersEjerciciosBasicos;

public class EjercicioABNumerosMayor : Ejercicio
{
    private int a;
    private int b;
    
    public EjercicioABNumerosMayor(int a, int b) : base (4,
        "Numero mayor", "decide que numero es mayor de a y b")
    {
        A = a;
        B = b;
    }

    public int A
    {
        get => a; 
        set => a = value;
    }

    public int B
    {
        get => b;
        set => b = value;
    }
    public override void Ejecutar()
    {
        if (A > B)
        {
            Console.WriteLine("A es mayor que B");
            
        }
        else if (A < B)
        {
            Console.WriteLine("B es mayor que A");
        }
        else
        {
            Console.WriteLine("Son iguales");
        }
    }
    
}