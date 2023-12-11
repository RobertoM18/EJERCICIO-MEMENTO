    //Memento
class VehiculoMemento
{
    // Propiedades que almacenan el estado del vehículo en un momento dado
    public string Modelo { get; }
    public int Año { get; }
    // Constructor para crear un memento con un estado específico
    public VehiculoMemento(string modelo, int año)
    {
        Modelo = modelo;
        Año = año;
    }
}