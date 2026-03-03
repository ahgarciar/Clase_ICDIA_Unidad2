namespace Clase_ICDIA_Unidad2.HandlersEjerciciosBasicos;

public class Ejercicio_SumaAB : Ejercicio
{
    private int a;
    private int b;
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

    public Ejercicio_SumaAB(int a, int b) : 
        base(2, "Suma A + B",
        "Suma de dos numeros ( a+b)")
    {
        A = a;
        B = b;
    }

    public override void Ejecutar()
    {
        int resultado = A + B;
        Console.WriteLine("Resultado de la suma: " + 
                          resultado);
    }

}