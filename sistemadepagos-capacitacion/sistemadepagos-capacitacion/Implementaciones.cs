namespace SistemaPagos;

public class TarjetaCredito : IMetodoPago
{
    public string Nombre => "Tarjeta de Crédito";
    public bool ProcesarPago(double monto)
    {
        Console.WriteLine($"[Validando Tarjeta] Cobrando ${monto}...");
        return true; 
    }
}

public class BilleteraDigital : IMetodoPago
{
    public string Nombre => "Billetera Digital (Nequi/Daviplata/Loopay)";
    public bool ProcesarPago(double monto)
    {
        Console.WriteLine($"[Escaneando QR] Descontando ${monto} de su saldo...");
        return true;
    }
}