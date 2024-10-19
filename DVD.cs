namespace ProyectoAvalonia.Core;

public class DVD: Dispositivo
{
    public bool PuedeGrabar { get; set; }
    public int TiempoGrabacion { get; set; }
    public bool BlueRay { get; set; }

    public DVD(string Modelo, int NumeroSerie, TipoDispositivo Tipo, bool BlueRay, int TiempoGrabacion):base(NumeroSerie, Modelo, Tipo,10)
    {
        this.BlueRay = BlueRay;
        this.TiempoGrabacion = TiempoGrabacion;
        if (TiempoGrabacion > 0)
        {
            this.PuedeGrabar=true;
        }
        else
        {
            this.PuedeGrabar=false;
        }
    }    
}
