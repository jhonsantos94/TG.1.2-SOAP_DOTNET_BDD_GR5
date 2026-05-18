namespace CliUniversalConsole.Config
{
    public static class ServiceConfig
    {
        // URLs para servicios REST - Autenticación
        public static string RestJavaBaseUrl { get; set; } = "http://localhost:8081/EurekaBank_RestFull_Java_GR05/api/Autenticacion";
        public static string RestDotNetBaseUrl { get; set; } = "http://localhost:9099/api/Autenticacion";

        // URLs para servicios SOAP - Autenticación
        public static string SoapJavaBaseUrl { get; set; } = "http://10.40.20.34:8080/JavaBDDSOAP/ServicioAutenticacion";
        public static string SoapDotNetBaseUrl { get; set; } = "http://localhost:9098/ws/ServicioAutenticacion.svc";

        // URLs para servicios REST - Transacciones
        public static string RestJavaTransaccionUrl { get; set; } = "http://localhost:8081/EurekaBank_RestFull_Java_GR05/api/Transaccion";
        public static string RestDotNetTransaccionUrl { get; set; } = "http://localhost:9099/api/Transaccion";

        // URLs para servicios SOAP - Transacciones
        public static string SoapJavaTransaccionUrl { get; set; } = "http://10.40.20.34:8080/JavaBDDSOAP/ServicioTransaccion";
        public static string SoapDotNetTransaccionUrl { get; set; } = "http://localhost:9098/ws/ServicioTransaccion.svc";

        // URLs para servicios REST - Reportes
        public static string RestJavaReporteUrl { get; set; } = "http://localhost:8081/EurekaBank_RestFull_Java_GR05/api/Reporte";
        public static string RestDotNetReporteUrl { get; set; } = "http://localhost:9099/api/Reporte";

        // URLs para servicios SOAP - Reportes
        public static string SoapJavaReporteUrl { get; set; } = "http://10.40.20.34:8080/JavaBDDSOAP/ServicioReporte";
        public static string SoapDotNetReporteUrl { get; set; } = "http://localhost:9098/ws/ServicioReporte.svc";
    }
}
