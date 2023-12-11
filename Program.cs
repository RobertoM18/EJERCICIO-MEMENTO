internal class Program
{
        static void Main()
    {
        // Crear un vehículo
        Vehiculo miVehiculo = new Vehiculo
        {
            Modelo = "Sedán",
            Año = 2022
        };
        // Mostrar la información actual del vehículo
        miVehiculo.MostrarInformacion(); 

        // Guardar el estado actual en el historial
        HistorialVehiculo historial = new HistorialVehiculo
        {
            Historial = miVehiculo.CrearMemento()
        };

        // Cambiar el estado del vehículo
        miVehiculo.Modelo = "SUV";
        miVehiculo.Año = 2023;

        miVehiculo.MostrarInformacion(); // Mostrar la información después del cambio

        // Restaurar el estado anterior desde el historial
        miVehiculo.RestaurarMemento(historial.Historial);

        miVehiculo.MostrarInformacion(); // Mostrar la información después de la restauración
    }
}
