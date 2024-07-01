namespace Generar.Reporte.Negocio.Modelos;
public class ReporteCuota : Poliza
{
    public string NroCuota { get; set; }
    public DateTime FechaPago { get; set; }
    public ReporteCuota() : base() { }
    public ReporteCuota(int nroPoliza, string nombreCliente, decimal prima, int tipoReporte, string nroCuota, DateTime fechaPago) 
        : base(nroPoliza, nombreCliente, prima, tipoReporte)
    {
        NroCuota = nroCuota;
        FechaPago = fechaPago;
    }
}
