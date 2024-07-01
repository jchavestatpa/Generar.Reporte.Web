namespace Generar.Reporte.Negocio.Modelos;
public class ReporteAuto : Poliza
{
    public string Auto { get; private set; }
    public string Marca { get; private set; }
    public string Modelo { get; private set; }

    public ReporteAuto() : base() { }
    public ReporteAuto(int nroPoliza, string nombreCliente, decimal prima, int tipoReporte, string auto, string marca, string modelo) 
        : base(nroPoliza, nombreCliente, prima, tipoReporte)
    {
        Auto = auto;
        Marca = marca;
        Modelo = modelo;
    }
}