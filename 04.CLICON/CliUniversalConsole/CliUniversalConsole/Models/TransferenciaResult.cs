namespace CliUniversalConsole.Models
{
    public class TransferenciaResult
    {
        public string CuentaOrigen { get; set; }
        public string CuentaDestino { get; set; }
        public decimal ImporteTransferido { get; set; }
        public decimal ImporteITF { get; set; }
        public decimal ImporteCargo { get; set; }
        public decimal TotalDescontado { get; set; }
        public decimal SaldoAnteriorOrigen { get; set; }
        public decimal SaldoNuevoOrigen { get; set; }
        public decimal SaldoAnteriorDestino { get; set; }
        public decimal SaldoNuevoDestino { get; set; }
        public int NumeroMovimientoOrigen { get; set; }
        public int NumeroMovimientoDestino { get; set; }

        public void Print()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n╔════════════════════════════════════════╗");
            Console.WriteLine("║    TRANSFERENCIA REALIZADA EXITOSA     ║");
            Console.WriteLine("╚════════════════════════════════════════╝");
            Console.WriteLine($"\n💸 Importe Transferido: S/ {ImporteTransferido:N2}");

            if (ImporteITF > 0 || ImporteCargo > 0 || TotalDescontado > 0)
            {
                Console.WriteLine($"🏦 ITF: S/ {ImporteITF:N2}");
                Console.WriteLine($"💳 Cargo por Movimiento: S/ {ImporteCargo:N2}");
                Console.WriteLine($"➖ Total Descontado: S/ {TotalDescontado:N2}");
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n📤 CUENTA ORIGEN: {CuentaOrigen}");
            Console.WriteLine($"   Saldo Anterior: S/ {SaldoAnteriorOrigen:N2}");
            Console.WriteLine($"   Saldo Nuevo: S/ {SaldoNuevoOrigen:N2}");
            if (NumeroMovimientoOrigen > 0)
            {
                Console.WriteLine($"   Movimiento: #{NumeroMovimientoOrigen}");
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n📥 CUENTA DESTINO: {CuentaDestino}");
            Console.WriteLine($"   Saldo Anterior: S/ {SaldoAnteriorDestino:N2}");
            Console.WriteLine($"   Saldo Nuevo: S/ {SaldoNuevoDestino:N2}");
            if (NumeroMovimientoDestino > 0)
            {
                Console.WriteLine($"   Movimiento: #{NumeroMovimientoDestino}");
            }

            Console.ResetColor();
        }
    }
}
