using System;
using System.Text.Json.Serialization;

namespace ProyectoAvalonia.Core
{
    public abstract class Reparacion
    {
        public Dispositivo MiDispositivo { get; set; }
        public int TiempoReparacion { get; set; }
        public double PrecioPiezas { get; set; }

        public Reparacion(Dispositivo disp, int tiempoReparacion, double precioPiezas)
        {
            this.MiDispositivo = disp;
            this.TiempoReparacion = tiempoReparacion;
            this.PrecioPiezas = precioPiezas;
        }

        public abstract double CalcularPrecioReparacion();
    }
}
