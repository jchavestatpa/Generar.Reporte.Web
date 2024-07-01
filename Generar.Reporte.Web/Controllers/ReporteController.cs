using Generar.Reporte.Negocio.Modelos;
using Generar.Reporte.Negocio.Servicio;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace Generar.Reporte.Web.Controllers;

[ApiController]
[Route("[controller]")]
public class ReporteController : ControllerBase
{
    private readonly GenerarReporte _generarReporte;
    private readonly ILogger<GenerarReporte> _logger;

    public ReporteController(ILogger<GenerarReporte> logger)
    {
        _logger = logger;
        _generarReporte = new GenerarReporte();
    }

    [HttpPost]
    public ActionResult GenerarReporte([FromBody] ReporteRequest reporteRequest)
    {

        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        try
        {
            var csv = _generarReporte.CrearReporte(reporteRequest);
            var bytes = Encoding.UTF8.GetBytes(csv);

            var result = new FileContentResult(bytes, "text/csv")
            {
                FileDownloadName = "Reporte.csv"
            };

            return result;
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Error al generar el reporte: {ex.Message}");
        }
    }
}
