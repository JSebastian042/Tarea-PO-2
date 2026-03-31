namespace SistemaPagos;

public class Tienda
{
    private List<Orden> _ordenes = new();

    public void AgregarOrden(Orden orden) => _ordenes.Add(orden);

    public void ProcesarPago(int ordenId, IMetodoPago metodo)
    {
        var orden = _ordenes.Find(o => o.Id == ordenId);

        if (orden == null)
        {
            Console.WriteLine("Orden no encontrada.");
            return;
        }

        if (orden.EstaPagada)
        {
            Console.WriteLine($"ALERTA: La orden #{ordenId} ya fue pagada anteriormente.");
            return;
        }

        if (metodo.ProcesarPago(orden.Monto))
        {
            orden.MarcarComoPagada(metodo.Nombre);
            Console.WriteLine("¡Pago procesado con éxito!");
        }
    }

    public void MostrarResumen()
    {
        Console.WriteLine("\n-=- RESUMEN DE LA TIENDA -=-");
        double totalRecaudado = 0;
        int pendientes = 0;

        foreach (var orden in _ordenes)
        {
            Console.WriteLine(orden);
            if (orden.EstaPagada) totalRecaudado += orden.Monto;
            else pendientes++;
        }

        Console.WriteLine($"\nTotal Recaudado: ${totalRecaudado}");
        Console.WriteLine($"Órdenes Pendientes: {pendientes}");
    }
}