namespace Clase_ICDIA_Unidad2.RPG_Mini;

public class MainJuego
{
    public MainJuego()
    {
        //objetivo... vencer a los tres enemigos!
        
        List<Enemigo> enemigos = new List<Enemigo>();
        enemigos.Add(new EnemigoTipo1("Luis Salvaje", 100, 10, 0.5));
        enemigos.Add(new EnemigoTipo2("Oscar", 50, 80, 0.3));
        enemigos.Add(new EnemigoTipo3("Aldair", 10, 20, 0.0));

        Personaje pPlayer = new Usuario("Dui", 300, 25, .25);

        Random random = new Random(5);
        int indice;
        
        do
        {
            indice = random.Next(0, enemigos.Count); //para que aleatoriamente me salga un enemigo
            Enemigo enemigo_a_vencer = enemigos[indice];
            Console.WriteLine($"Ha aparecido un enemigo: {enemigo_a_vencer.Nombre}");

            Console.ReadKey();

        } while (pPlayer.Vida>0);


    }
}