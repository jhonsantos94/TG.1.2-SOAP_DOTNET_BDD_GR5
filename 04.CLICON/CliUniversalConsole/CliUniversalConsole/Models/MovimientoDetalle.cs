namespace CliUniversalConsole.Models
{
    public class MovimientoDetalle
    {
        public string CodigoCuenta { get; set; } = "";
        public int Numero { get; set; }
        public DateTime Fecha { get; set; }
        public string TipoMovimiento { get; set; } = "";
        public string Accion { get; set; } = "";
        public string EmpleadoNombre { get; set; } = "";
        public string CodigoEmpleado { get; set; } = "";
        public string? CuentaReferencia { get; set; }
        public decimal Importe { get; set; }

        public void Print()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\n┌─────────────────────────────────────────┐");
            Console.WriteLine($"│ Movimiento #{Numero}                    ");
            Console.WriteLine($"└─────────────────────────────────────────┘");
            Console.ResetColor();
            
            Console.WriteLine($"Fecha:             {Fecha:dd/MM/yyyy HH:mm:ss}");
            Console.WriteLine($"Tipo:              {TipoMovimiento}");
            if (!string.IsNullOrWhiteSpace(Accion))
            {
                Console.WriteLine($"Accion:            {Accion}");
            }
            Console.WriteLine($"Importe:           S/ {Importe:N2}");
            var empleado = !string.IsNullOrWhiteSpace(EmpleadoNombre) ? EmpleadoNombre : CodigoEmpleado;
            if (!string.IsNullOrWhiteSpace(empleado))
            {
                Console.WriteLine($"Empleado:          {empleado}");
            }
            
            if (!string.IsNullOrEmpty(CuentaReferencia))
            {
                Console.WriteLine($"Cuenta Ref:        {CuentaReferencia}");
            }
        }
    }
}
