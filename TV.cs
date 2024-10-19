namespace ProyectoAvalonia.Core;

public class TV:Dispositivo
{
    public int Pulgadas { get; set; }

    public TV(string Modelo, int NumeroSerie, TipoDispositivo Tipo, int Pulgadas):base(NumeroSerie, Modelo, Tipo,10)
    {
        this.Pulgadas = Pulgadas;
    }
}
