using System.Diagnostics;

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
            Console.WriteLine($"\nHa aparecido un enemigo: {enemigo_a_vencer.Nombre}");

            Console.WriteLine("Proceso de ataque iniciado...Presione una tecla para continuar...");
            Console.ReadKey();
            do
            {
                //if (condicion_para_decir_quien_ataca_primero)
             
                //Primero ataca el jugador
                pPlayer.EfectuaAtaque(enemigo_a_vencer);

                if (enemigo_a_vencer.Vida > 0)
                {
                    //Segundo ataca el enemigo
                    enemigo_a_vencer.EfectuaAtaque(pPlayer);
                    Console.WriteLine("Turno terminado. Presione una tecla para continuar.");
                    Console.ReadKey();
                }
                
            }
            while(pPlayer.Vida > 0 && enemigo_a_vencer.Vida > 0);

            if (enemigo_a_vencer.Vida == 0)
            {
                Console.WriteLine("Enemigo derrotado");
                enemigos.RemoveAt(indice); //Eliminarlo de la lista 
                Console.ReadKey();
            }
            
        } while (pPlayer.Vida>0 && enemigos.Count>0);
        
        //Validar la razon de que se termino el ciclo anterior
        if (pPlayer.Vida>0) {
            Console.WriteLine("\nHas ganado el juego :D!");
        }
        else {
            Console.WriteLine("\nHas muerto!!! x.x");
        }

    }
}