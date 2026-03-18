namespace Clase_ICDIA_Unidad2.ListasGenericas;

public class Ej4_pokemon
{
    public Ej4_pokemon()
    {
        //Zona A de la Ruta 105
        List<string> pokesPosibles = new List<string>();
        pokesPosibles.Add("Pikachu");       // 0
        pokesPosibles.Add("Pidgeot");       // 1
        pokesPosibles.Add("Evee");          // 2
        pokesPosibles.Add("Snorlax");       // 3
        pokesPosibles.Add("Charmander");    // 4
        
        Random random = new Random();
        int indicePoke = random.Next(0, pokesPosibles.Count);
        string poke = pokesPosibles[indicePoke];
        Console.Write(poke);

        double shiny = random.NextDouble();
        if (shiny > 0.95) //prob = 1-a  .... a = 0.95
        {
            Console.WriteLine( " -- Shiny!!!");
        }
        
        
        // Mini juego-> RPG Sim
        // jugadar dados

    }
}