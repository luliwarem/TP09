namespace TP09_Szmedra_Waremkraut.Models;

public class Genero
{
    private int _idGenero;
    private string _nombre;


    public int IdGenero
    {
        get
        {
            return _idGenero;
        }
        set{
            _idGenero = value;
        }

    }

    public string Nombre
    {
        get
        {
            return _nombre;
        }
        set{
            _nombre = value;
        }
    }
}