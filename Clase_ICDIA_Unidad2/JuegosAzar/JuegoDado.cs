namespace Clase_ICDIA_Unidad2.JuegosAzar;

public class JuegoDado
{
    public JuegoDado()
    {

        Dado dado_usuario;
        Dado dado_computadora;

        dado_usuario = new Dado();
        dado_computadora = new Dado();
        
        Console.WriteLine("Presione una tecla para lanzar los dados");
        Console.ReadKey();
        dado_usuario.Girar();
        
        Console.WriteLine("...  La computadora lanza sus dados en 3");
        Thread.Sleep(1000);
        Console.WriteLine("...  La computadora lanza sus dados en 2");
        Thread.Sleep(1000);
        Console.WriteLine("...  La computadora lanza sus dados en 1");
        Thread.Sleep(1000);
        dado_computadora.Girar();
        Thread.Sleep(1000);
        
        Console.WriteLine("Resultado.....");
        
        int resultadoUsuario = dado_usuario.MirarValor();
        int resultadoComputadora = dado_computadora.MirarValor();

        Console.WriteLine($"Usuario: {resultadoUsuario} " +
                          $"Computadora: {resultadoComputadora}\n");
        
        if (resultadoUsuario > resultadoComputadora)
        {
            Console.WriteLine("Usuario gana");
        }
        else if (resultadoUsuario == resultadoComputadora)
        {
            Console.WriteLine("Empate");
        }
        else
        {
            Console.WriteLine("Gano la computadora");
        }

    }
}