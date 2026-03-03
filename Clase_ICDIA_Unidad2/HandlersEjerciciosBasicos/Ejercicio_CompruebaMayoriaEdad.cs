namespace Clase_ICDIA_Unidad2.HandlersEjerciciosBasicos;

public class Ejercicio_CompruebaMayoriaEdad : Ejercicio
{
   private int edad;

   public int Edad
   {
      get => edad; 
      set => edad = value;
   }

   public Ejercicio_CompruebaMayoriaEdad(int edad) :
      base(3, 
         "Checar Si es Ciudadano", 
         "Comprueba si dada una edad la persona es ciudadana")
   {
      Edad = edad;
   }

   public override void Ejecutar()
   {
      if (Edad >= 18)
      {
         Console.WriteLine("Es ciudadano");
      }
      else
      {
         Console.WriteLine("No es ciudadano");
      }
   }

}