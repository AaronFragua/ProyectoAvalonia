namespace ProyectoAvalonia.Core;

public class Dispositivo
{
    public enum TipoDispositivo{Radio,TDT,DVD,TV}

    private int NumeroSerie { get; set; }
    private string Modelo { get; set; }
    public int PrecioReparacionPorHora { get; set; }
    private TipoDispositivo Tipo { get; set; }

    public Dispositivo(int NumeroSerie, string Modelo,TipoDispositivo Tipo, int precioReparacionPorHora)
    {
        this.NumeroSerie = NumeroSerie;
        this.Modelo = Modelo;
        this.Tipo = Tipo;
        this.PrecioReparacionPorHora= precioReparacionPorHora;
    }

    public TipoDispositivo getTipoDispositivo()
    {
        return this.Tipo;
    }

    public int getNumeroSerie()
    {
        return this.NumeroSerie;
    }
}
