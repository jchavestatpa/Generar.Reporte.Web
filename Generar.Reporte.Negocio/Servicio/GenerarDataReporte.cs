using Bogus;
using Generar.Reporte.Negocio.Modelos;

namespace Generar.Reporte.Negocio.Servicio;

public class GenerarDataReporte
{
    public List<Poliza> GenerarData(int cantidad, ReporteRequest reporteRequest)
    {
        switch (reporteRequest.TipoTrama)
        {
            case 1:
                var faker1 = new Faker<ReporteVida>()
                    .RuleFor(o => o.NroPoliza, f => f.IndexFaker + 1)
                    .RuleFor(o => o.NombreCliente, f => f.Name.FullName())
                    .RuleFor(o => o.Prima, f => decimal.Parse(f.Commerce.Price(10, 100)))
                    .RuleFor(o => o.TipoReporte, reporteRequest.TipoTrama)
                    .RuleFor(o => o.Fumador, f => f.Random.Bool() ? "SI" : "NO");
                return faker1.Generate(cantidad).ConvertAll(x => (Poliza)x);

            case 2:
                var faker2 = new Faker<ReporteAuto>()
                    .RuleFor(o => o.NroPoliza, f => f.IndexFaker + 1)
                    .RuleFor(o => o.NombreCliente, f => f.Name.FullName())
                    .RuleFor(o => o.Prima, f => decimal.Parse(f.Commerce.Price(1000, 50000)))
                    .RuleFor(o => o.TipoReporte, reporteRequest.TipoTrama)
                    .RuleFor(o => o.Auto, f => f.Vehicle.Model())
                    .RuleFor(o => o.Marca, f => f.Vehicle.Manufacturer())
                    .RuleFor(o => o.Modelo, f => f.Vehicle.Type());
                return faker2.Generate(cantidad).ConvertAll(x => (Poliza)x);

            case 3:
                var faker3 = new Faker<ReporteCuota>()
                    .RuleFor(o => o.NroPoliza, f => f.IndexFaker + 1)
                    .RuleFor(o => o.NombreCliente, f => f.Name.FullName())
                    .RuleFor(o => o.Prima, f => decimal.Parse(f.Commerce.Price(100, 2000)))
                    .RuleFor(o => o.TipoReporte, reporteRequest.TipoTrama)
                    .RuleFor(o => o.NroCuota, f => f.Random.Int(1, 5).ToString())
                    .RuleFor(o => o.FechaPago, f => f.Date.Between(reporteRequest.FechaInicio, reporteRequest.FechaFin));
                return faker3.Generate(cantidad).ConvertAll(x => (Poliza)x);

            default:
                return new List<Poliza>();
        }
    }
}
