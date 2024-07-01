using System.ComponentModel.DataAnnotations;

namespace Generar.Reporte.Negocio.Modelos;

public class ReporteRequest
{
    [Required(ErrorMessage = "La fecha de inicio es requerida.")]
    [DataType(DataType.Date, ErrorMessage = "La fecha de inicio debe ser una fecha válida.")]
    public DateTime FechaInicio { get; set; }

    [Required(ErrorMessage = "La fecha de fin es requerida.")]
    [DataType(DataType.Date, ErrorMessage = "La fecha de fin debe ser una fecha válida.")]
    public DateTime FechaFin { get; set; }

    [Required(ErrorMessage = "El tipo de trama es requerido.")]
    [Range(1, 3, ErrorMessage = "El tipo de trama debe ser un valor entre 1 y 3.")]
    public int TipoTrama { get; set; }
}
