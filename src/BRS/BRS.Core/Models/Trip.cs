namespace BRS.Core.Models {
  /// <summary>
  /// Clase representativa de la entidad viaje.
  /// </summary>
  public class Trip : Entity {
    /// <summary>
    /// Representa los dias que esta disponible el viaje.
    /// </summary>
    public byte DateAvailable { get; set; }
    /// <summary>
    /// Representa la hora de salida.
    /// </summary>
    public int DepartureTime { get; set; }
    /// <summary>
    /// Representa la hora de llegada.
    /// </summary>
    public int ArrivalTime { get; set; }
    /// <summary>
    /// Representa el precio del viaje.
    /// </summary>
    public float Price { get; set; }
    /// <summary>
    /// Representa una ruta.
    /// </summary>
    public virtual Route Route { get; set; }
    /// <summary>
    /// Representa un vehiculo.
    /// </summary>
    public virtual Vehicle Vehicle{ get; set; }
  }
}
