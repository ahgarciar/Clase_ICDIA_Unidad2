namespace Clase_ICDIA_Unidad2.RPG_Mini;

public class Enemigo : Personaje
{
    /*
    Jugador tiene vida / ataque
    
    Caada x tiempo, mientras que tenga vida, 
    podrá aparecersele un enemigo. Existen tres tipos de enemigos,
    cada uno con sus caracteristicas de vida y ataque.
    
    En cada turno, el jugador puede atacar o defenderse.
    
    Si decide atacar, el enemigo podría recibir el ataque, bloquear (defenderse) o esquivar
    
    Despues del turno del jugador, el enemigo podrá atacar, si el jugador
    defendio previamente, entonces el ataque bajará menos. 
    Existe una probabalidad de que se esquive el ataque
    */
    
    public Enemigo(string nombre, int vida, int ataque, double probEsquivar)
        : base(nombre, vida, ataque, probEsquivar)
    {
        
    }
}