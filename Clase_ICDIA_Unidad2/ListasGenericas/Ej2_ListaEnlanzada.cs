namespace Clase_ICDIA_Unidad2.ListasGenericas;

public class Ej2_ListaEnlanzada
{
    public Ej2_ListaEnlanzada()
    {
        //Crea una lista vacia
        List<double> calificaciones; //declaracion
        calificaciones = new List<double>(); //instanciacion
        
        calificaciones.Add(5.6);
        calificaciones.Add(8.5);
        calificaciones.Add(9.8);
        
        //Console.WriteLine(calificaciones);

        //Recomendado solo para visualizar o cambios muy puntuales
        foreach (double elemento in calificaciones)
        {
            Console.WriteLine(elemento);
            //calificaciones.Remove(elemento); //No se debe hacer
        }
        //Util para lo que sea :D!
        for (int i = 0; i < calificaciones.Count; i++)
        {
            Console.WriteLine(calificaciones[i]);
            calificaciones.RemoveAt(i);
        }
        
        
    }
}