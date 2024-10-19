namespace ProyectoAvalonia.Core;

public class Radio: Dispositivo
{
    public enum Bandas {AM,FM,AMBAS}
    public Bandas MiBandas { get; set; }

    public Radio(string Modelo, int NumeroSerie, TipoDispositivo Tipo, Bandas MiBandas):base(NumeroSerie, Modelo, Tipo,5)
    {
        this.MiBandas = MiBandas;
    }
}
