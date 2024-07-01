using Generar.Reporte.Negocio.Modelos;
using System.Text;

namespace Generar.Reporte.Negocio.Servicio;

public class FormatearDatosReporte
{
    public string GenerarArchivoCsv(List<Poliza> data)
    {
        var sb = new StringBuilder();
        var properties = data.First().GetType().GetProperties();

        // Encabezado
        sb.AppendLine(string.Join(";", properties.Select(p => p.Name)));

        // contenido
        foreach (var item in data)
        {
            var values = properties.Select(p => p.GetValue(item)?.ToString());
            sb.AppendLine(string.Join(";", values));
        }

        return sb.ToString();
    }
}
