namespace Clase_ICDIA_Unidad2.Ejemplo_Herencia;

public class SupportType1 : JugadorSupport
{
    private string habilidad_especifica;

    public string Habilidad_especifica
    {
        get => habilidad_especifica;
        set => habilidad_especifica = value;
    }

    public SupportType1(string nombre, string habilidad,
        string habilidad_especifica)
        : base(nombre, habilidad)
    {
        Habilidad_especifica = habilidad_especifica;
    }

}