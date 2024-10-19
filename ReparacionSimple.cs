using System.Text;

namespace EntregaAvalonia.Core;

public class ReparacionSimple: Reparacion
{
    public ReparacionSimple(Dispositivo disp, int tiempoReparacion, double precioPiezas):base(disp,tiempoReparacion,precioPiezas)
    {
    }

    public override double CalcularPrecioReparacion()
    {
        double toret = 0;
        int precioBase = 10;
        int minutos=this.TiempoReparacion;
        toret += this.MiDispositivo.PrecioReparacionPorHora * ((double)minutos/100);
        toret += precioBase;
        toret += this.PrecioPiezas;
        return toret;
    }
}
