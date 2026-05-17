using EurekaBank_Soap_DotNet_GR05.Models.DTOs;
using EurekaBank_Soap_DotNet_GR05.Services;

namespace EurekaBank_Soap_DotNet_GR05.WS
{
    /// <summary>
    /// Implementación del servicio WCF de transacciones
    /// </summary>
    public class ServicioTransaccion : IServicioTransaccion
    {
        private readonly TransaccionService transaccionService;

        public ServicioTransaccion()
        {
            transaccionService = new TransaccionService();
        }

        public RespuestaDTO RealizarDeposito(TransaccionDTO datos)
        {
            return transaccionService.RealizarDeposito(datos);
        }

        public RespuestaDTO RealizarRetiro(TransaccionDTO datos)
        {
            return transaccionService.RealizarRetiro(datos);
        }

        public RespuestaDTO RealizarTransferencia(TransferenciaDTO datos)
        {
            return transaccionService.RealizarTransferencia(datos);
        }
    }
}
