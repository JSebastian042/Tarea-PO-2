namespace SistemaPagos;

public interface IMetodoPago
{
    string Nombre { get; }
    bool ProcesarPago(double monto);
}