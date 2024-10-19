namespace ProyectoAvalonia.Core;

public class TDT:Dispositivo
{
    public int TiempoGrabacion { get; set; }
    public bool PuedeGrabar { get; set; }

    public TDT(string Modelo, int NumeroSerie, TipoDispositivo Tipo, int TiempoGrabacion):base(NumeroSerie, Modelo, Tipo,5)
    {
        this.TiempoGrabacion = TiempoGrabacion;
        if (TiempoGrabacion>0)
        {
            this.PuedeGrabar = true;
        }
        else
        {
            this.PuedeGrabar = false;
        }
    }
}
