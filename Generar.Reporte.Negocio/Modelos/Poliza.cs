namespace Generar.Reporte.Negocio.Modelos;
public class Poliza
{
    public int NroPoliza { get; private set; }
    public string NombreCliente { get; private set; }
    public decimal Prima { get; private set; }
    public int TipoReporte { get; private set; }
    public Poliza() { }
    public Poliza(int nroPoliza, string nombreCliente, decimal prima, int tipoReporte)
    {
        NroPoliza = nroPoliza;
        NombreCliente = nombreCliente;
        Prima = prima;
        TipoReporte = tipoReporte;
    }
}
