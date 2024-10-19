using Avalonia.Controls;
using Avalonia.Interactivity;
using System;
using EntregaAvalonia.Core;

namespace ProyectoAvalonia
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            CalcularPrecioButton.Click += CalcularPrecioButton_Click;
            DispositivoComboBox.SelectionChanged += DispositivoComboBox_SelectionChanged;
        }

        private void DispositivoComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedDevice = (DispositivoComboBox.SelectedItem as ComboBoxItem)?.Content.ToString();

            BandasComboBox.IsVisible = false;
            PulgadasTextBox.IsVisible = false;
            BlueRayTextBox.IsVisible = false;
            TiempoGrabacionTextBox.IsVisible = false;
            TiempoGrabacionTdtTextBox.IsVisible = false;

            switch (selectedDevice)
            {
                case "Radio":
                    BandasComboBox.IsVisible = true;
                    break;
                case "Televisor":
                    PulgadasTextBox.IsVisible = true;
                    break;
                case "DVD":
                    BlueRayTextBox.IsVisible = true;
                    TiempoGrabacionTextBox.IsVisible = true;
                    break;
                case "TDT":
                    TiempoGrabacionTdtTextBox.IsVisible = true;
                    break;
            }
        }

        private void CalcularPrecioButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (DispositivoComboBox.SelectedItem == null)
                {
                    PrecioTotalTextBox.Text = "Por favor, seleccione un dispositivo válido.";
                    return;
                }

                var selectedDeviceName = (DispositivoComboBox.SelectedItem as ComboBoxItem)?.Content.ToString();

                if (!int.TryParse(TiempoReparacionTextBox.Text, out int minutosReparacion))
                {
                    PrecioTotalTextBox.Text = "Introduce un tiempo válido.";
                    return;
                }
                if (!double.TryParse(CostePiezasTextBox.Text, out double precioPiezas))
                {
                    PrecioTotalTextBox.Text = "Introduce un coste de piezas válido.";
                    return;
                }
                if (ModeloTextBox.Text.Length == 0)
                {
                    PrecioTotalTextBox.Text = "Por favor, introduzca un modelo válido.";
                    return;
                }
                if (NumeroSerieTextBox.Text.Length == 0 || !int.TryParse(NumeroSerieTextBox.Text, out int NumeroSerie))
                {
                    PrecioTotalTextBox.Text = "Por favor, introduzca un numero de serie conformado solo por numeros.";
                    return;
                }

                int Pulgadas = 0; 

                if (selectedDeviceName == "Televisor" && (PulgadasTextBox.Text.Length == 0 || !int.TryParse(PulgadasTextBox.Text, out Pulgadas)))
                {
                    PrecioTotalTextBox.Text = "Por favor, introduzca un numero de pulgadas correcto.";
                    return;
                }
                
                if (selectedDeviceName == "DVD" && (BlueRayTextBox.Text.Length == 0 ||
                    (!BlueRayTextBox.Text.Equals("Si") && !BlueRayTextBox.Text.Equals("No"))))
                {
                    PrecioTotalTextBox.Text = "Por favor, introduzca si tiene o no BlueRay (Si/No).";
                    return;
                }

                Dispositivo dispositivo = null;

                switch (selectedDeviceName)
                {
                    case "Radio":
                        if (BandasComboBox.SelectedItem == null)
                        {
                            PrecioTotalTextBox.Text = "Por favor, seleccione una banda.";
                            return;
                        }

                        var bandaSeleccionada = (BandasComboBox.SelectedItem as ComboBoxItem)?.Content.ToString();
                        if (bandaSeleccionada == "AM")
                        {
                            dispositivo = new Radio(ModeloTextBox.Text, NumeroSerie, Dispositivo.TipoDispositivo.Radio, Radio.Bandas.AM);
                        }
                        else if (bandaSeleccionada == "FM")
                        {
                            dispositivo = new Radio(ModeloTextBox.Text, NumeroSerie, Dispositivo.TipoDispositivo.Radio, Radio.Bandas.FM);
                        }
                        else
                        {
                            dispositivo = new Radio(ModeloTextBox.Text, NumeroSerie, Dispositivo.TipoDispositivo.Radio, Radio.Bandas.AMBAS);
                        }
                        break;
                    case "Televisor":
                        dispositivo = new TV(ModeloTextBox.Text, NumeroSerie, Dispositivo.TipoDispositivo.TV, Pulgadas);
                        break;
                    case "DVD":
                        dispositivo = new DVD(ModeloTextBox.Text, NumeroSerie, Dispositivo.TipoDispositivo.DVD, BlueRayTextBox.Text.Equals("Si"), int.Parse(TiempoGrabacionTextBox.Text));
                        break;
                    case "TDT":
                        dispositivo = new TDT(ModeloTextBox.Text, NumeroSerie, Dispositivo.TipoDispositivo.TDT, int.Parse(TiempoGrabacionTextBox.Text));
                        break;
                }

                Reparacion rep;
                double precioTotal = 0;
                if (minutosReparacion < 60)
                {
                    rep = new ReparacionSimple(dispositivo, minutosReparacion, precioPiezas);
                }
                else
                {
                    rep = new ReparacionCompleja(dispositivo, minutosReparacion, precioPiezas);
                }

                precioTotal = rep.CalcularPrecioReparacion();
                PrecioTotalTextBox.Text = $"Precio total: {precioTotal}€";
            }
            catch (Exception ex)
            {
                PrecioTotalTextBox.Text = $"Error: {ex.Message}";
            }
        }
    }
}
