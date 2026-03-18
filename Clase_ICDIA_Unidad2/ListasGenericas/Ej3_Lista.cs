namespace Clase_ICDIA_Unidad2.ListasGenericas;

public class Ej3_Lista
{
    public Ej3_Lista()
    {

        //Lista de calificaciones parciales del grupo
        List<int> califs_parcial1; //declaracion
        califs_parcial1 = new List<int>(); //instanciacion con constructor vacio

        //objeto de clase random ... Esta clase sirve para generar numeros aleatorios
        Random random;
        //random = new Random(); //sin semilla (pseudoaleatorio)
        random = new Random(5);
        
        for (int i = 0; i < 10; i++)
        {
            int v = random.Next(0,11);
            Console.WriteLine(v);
            califs_parcial1.Add(v);
        }
        
        Console.WriteLine();
        

    }
    
}