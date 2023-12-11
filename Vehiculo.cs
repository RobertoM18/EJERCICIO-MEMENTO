
// Originator
class Vehiculo
{
    // Propiedades que representan el estado del vehículo
    public string Modelo { get; set; }
    public int Año { get; set; }
    // Método para crear un memento con el estado actual del vehículo
    public VehiculoMemento CrearMemento()
    {
        return new VehiculoMemento(Modelo, Año);
    }
    // Método para restaurar el estado del vehículo desde un memento
    public void RestaurarMemento(VehiculoMemento memento)
    {
        Modelo = memento.Modelo;
        Año = memento.Año;
    }
    // Método para mostrar la información actual del vehículo
    public void MostrarInformacion()
    {
        Console.WriteLine($"Modelo: {Modelo}, Año: {Año}");
    }
}