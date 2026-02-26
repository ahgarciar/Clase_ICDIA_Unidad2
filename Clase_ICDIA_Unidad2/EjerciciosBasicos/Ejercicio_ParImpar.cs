namespace Clase_ICDIA_Unidad2.EjerciciosBasicos;

public class Ejercicio_ParImpar :Ejercicio
{
    private int n;
    
    public int N { get => n; set => n = value; }
    
    public Ejercicio_ParImpar(int n)
        : base(1, "Par-Impar",
            "Determinar si un número es par o impar")
    {
        N = n;
    }

    public override void Ejecutar()
    {
        if (N % 2 == 0) {
            Console.WriteLine("ES PAR");
        }
        else {
            Console.WriteLine("ES IMPAR");
        }
        
    }

}