namespace Clase_ICDIA_Unidad2.RPG_Mini;

public class Personaje
{
    private string nombre;
    private int vida;
    private int ataque;
    private double probabilidad_esquivar;

    public string Nombre
    {
        get => nombre;
        set => nombre = value; //
    }

    public int Vida
    {
        get => vida;
        set
        {
            if (value < 0) //si al recibir el ataque la vida baja de cero, se asigna 0 
            {
                vida = 0;
            }
            else
            {
                vida = value; //positivo
            }
            
        }
    }

    public int Ataque
    {
        get => ataque;
        set => ataque = value; //positivo
    }

    public double Probabilidad_esquivar
    {
        get => probabilidad_esquivar;
        set => probabilidad_esquivar = value; //0 - 1
    }

    public Personaje(string nombre, int vida, int ataque, double probabilidad_esquivar)
    {
        Nombre = nombre;
        Vida = vida;
        Ataque = ataque;
        Probabilidad_esquivar = probabilidad_esquivar;
    }


}