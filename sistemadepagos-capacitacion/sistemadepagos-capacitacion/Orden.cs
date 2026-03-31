namespace SistemaPagos;

public class Orden
{
    public int Id { get; }
    public string Cliente { get; }
    public double Monto { get; }
    public bool EstaPagada { get; private set; } 
    public string MetodoUsado { get; private set; } = "Ninguno";

    public Orden(int id, string cliente, double monto)
    {
        Id = id;
        Cliente = cliente;
        Monto = monto;
        EstaPagada = false;
    }

    public void MarcarComoPagada(string metodo)
    {
        EstaPagada = true;
        MetodoUsado = metodo;
    }

    public override string ToString() =>
        $"Orden #{Id} - Cliente: {Cliente} - Monto: ${Monto} - Pagada: {EstaPagada} (vía {MetodoUsado})";
}