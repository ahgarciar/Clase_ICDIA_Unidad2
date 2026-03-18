namespace Clase_ICDIA_Unidad2.JuegosAzar;

public class Dado
{
    private int valor; //0 - 6
    private Random random; //sera utilizado unicamente de manera interna

    public int Valor { 
        get => valor; 
        set => valor = value; }
    
    public Dado(int semilla)
    {
        random = new Random(semilla);
        Valor = -1;
    }

    public Dado()
    {
        random = new Random();
        Valor = -1;
    }

    public void Girar()
    {
        Valor += random.Next(1, 7);
    }

    public int MirarValor()
    {
        return Valor;
    }

}