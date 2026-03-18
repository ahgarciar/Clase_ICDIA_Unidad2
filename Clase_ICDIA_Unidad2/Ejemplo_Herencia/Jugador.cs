namespace Clase_ICDIA_Unidad2.Ejemplo_Herencia;

public class Jugador
{
    private string name;

    public string Name
    {
        get => name;
        set => name = value;
    }

    public Jugador(string name)
    {
        Name = name;
    }

    public virtual void Atacar()
    {
        //ataca ---<<<< Fist Attack
    }
}