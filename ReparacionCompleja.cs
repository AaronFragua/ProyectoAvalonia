using System.Text;

namespace ProyectoAvalonia.Core;

public class ReparacionCompleja: Reparacion
{
    public ReparacionCompleja(Dispositivo disp, int tiempoReparacion, double precioPiezas):base(disp,tiempoReparacion,precioPiezas)
    {
    }

    public override double CalcularPrecioReparacion()
    {
        double toret = 0;
        int precioBase = 10;
        int horas = this.TiempoReparacion / 60;
        int minutos=this.TiempoReparacion % 60;
        for (int i = 0; i < horas; i++)
        {
            toret += this.MiDispositivo.PrecioReparacionPorHora * 1.25;
        }

        toret += (((double)minutos / 100) * this.MiDispositivo.PrecioReparacionPorHora);
        toret += precioBase;
        toret += this.PrecioPiezas;
        return toret;
    }
}
