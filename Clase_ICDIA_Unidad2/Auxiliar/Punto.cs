using System.Numerics;

namespace Clase_ICDIA_Unidad2.Auxiliar;

public class Punto<T> where T : INumber<T>
{
    //Coordenadas
    private T coordX;
    private T coordY;
    
    public T CoordX { get => coordX; set => coordX = value; }
    public T CoordY { get => coordY; set => coordY = value; }

    public Punto(T coordX, T coordY)
    {
        CoordX = coordX;
        CoordY = coordY;
    }
}