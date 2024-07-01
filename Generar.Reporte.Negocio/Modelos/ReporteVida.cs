namespace Generar.Reporte.Negocio.Modelos;
public class ReporteVida : Poliza
{
    public string Fumador { get; set; }

    public ReporteVida() : base() { }

    public ReporteVida(int nroPoliza, string nombreCliente, decimal prima, int tipoReporte, string fumador)
        : base(nroPoliza, nombreCliente, prima, tipoReporte)
    {
        Fumador = fumador;
    }

}
