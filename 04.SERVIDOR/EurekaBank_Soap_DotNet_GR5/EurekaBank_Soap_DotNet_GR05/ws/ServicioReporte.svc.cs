using System;
using System.Collections.Generic;
using EurekaBank_Soap_DotNet_GR05.Models.DTOs;
using EurekaBank_Soap_DotNet_GR05.Services;

namespace EurekaBank_Soap_DotNet_GR05.WS
{
    /// <summary>
    /// Implementación del servicio WCF de reportes
    /// </summary>
    public class ServicioReporte : IServicioReporte
    {
        private readonly ReporteService reporteService;

        public ServicioReporte()
        {
            reporteService = new ReporteService();
        }

        public List<MovimientoDetalleDTO> ObtenerMovimientos(string codigoCuenta)
        {
            return reporteService.ObtenerMovimientos(codigoCuenta);
        }

        public List<MovimientoDetalleDTO> ObtenerMovimientosPorRango(string codigoCuenta, DateTime fechaInicio, DateTime fechaFin)
        {
            return reporteService.ObtenerMovimientosPorRango(codigoCuenta, fechaInicio, fechaFin);
        }
    }
}
