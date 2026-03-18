namespace Clase_ICDIA_Unidad2.Ejemplo_Herencia;

public class JugadorSupport : Jugador
{
    private string habilidad;

    public string Habilidad
    {
        get => habilidad;
        set => habilidad = value;
    }
    
    public JugadorSupport(string nombrecito, string habilidad) 
        : base(nombrecito) //llamada al constructor padre
    {
        Habilidad = habilidad;
    }

    public override void Atacar()
    {
        //ataca de manera especial
    }

}