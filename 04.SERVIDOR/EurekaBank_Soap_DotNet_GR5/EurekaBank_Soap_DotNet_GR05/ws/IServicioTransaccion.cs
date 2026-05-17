using System.ServiceModel;
using EurekaBank_Soap_DotNet_GR05.Models.DTOs;

namespace EurekaBank_Soap_DotNet_GR05.WS
{
    /// <summary>
    /// Contrato de servicio para transacciones bancarias
    /// </summary>
    [ServiceContract]
    public interface IServicioTransaccion
    {
        /// <summary>
        /// Realiza un depósito en una cuenta
        /// </summary>
        /// <param name="datos">Datos de la transacción</param>
        /// <returns>RespuestaDTO con el resultado de la operación</returns>
        [OperationContract]
        RespuestaDTO RealizarDeposito(TransaccionDTO datos);

        /// <summary>
        /// Realiza un retiro de una cuenta
        /// </summary>
        /// <param name="datos">Datos de la transacción</param>
        /// <returns>RespuestaDTO con el resultado de la operación</returns>
        [OperationContract]
        RespuestaDTO RealizarRetiro(TransaccionDTO datos);

        /// <summary>
        /// Realiza una transferencia entre dos cuentas
        /// </summary>
        /// <param name="datos">Datos de la transferencia</param>
        /// <returns>RespuestaDTO con el resultado de la operación</returns>
        [OperationContract]
        RespuestaDTO RealizarTransferencia(TransferenciaDTO datos);
    }
}
