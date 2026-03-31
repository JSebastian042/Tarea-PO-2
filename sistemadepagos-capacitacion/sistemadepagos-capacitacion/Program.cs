using SistemaPagos;

Tienda miTienda = new Tienda();


miTienda.AgregarOrden(new Orden(1, "Juan Jurado", 50000));
miTienda.AgregarOrden(new Orden(2, "Andres Ramirez", 120000));
miTienda.AgregarOrden(new Orden(3, "Ramdhei Lopez", 85000));


miTienda.ProcesarPago(1, new TarjetaCredito());
miTienda.ProcesarPago(2, new BilleteraDigital());


miTienda.ProcesarPago(1, new TarjetaCredito());


miTienda.MostrarResumen();