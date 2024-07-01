using Generar.Reporte.Negocio.Modelos;

namespace Generar.Reporte.Negocio.Servicio;

public class GenerarReporte
{
    private readonly GenerarDataReporte _generarDataReporte;
    private readonly FormatearDatosReporte _formatearDatosReporte;

    public GenerarReporte()
    {
        _generarDataReporte = new GenerarDataReporte();
        _formatearDatosReporte = new FormatearDatosReporte();
    }

    public string CrearReporte(ReporteRequest reporteRequest)
    {
        int recordCount = reporteRequest.TipoTrama switch
        {
            1 => 10,
            2 => 20,
            3 => 30,
            _ => 10
        };

        var data = _generarDataReporte.GenerarData(recordCount, reporteRequest);
        var csv = _formatearDatosReporte.GenerarArchivoCsv(data);

        return csv;
    }
}
