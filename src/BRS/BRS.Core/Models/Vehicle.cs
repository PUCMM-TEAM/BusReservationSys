namespace BRS.Core.Models
{
    /// <summary>
    /// Clase representativa de la entidad vehiculo.
    /// </summary>
    public class Vehicle : Entity{
      /// <summary>
      /// Representa el nombre de un vehiculo.
      /// </summary>
      public string Name { get; set; }
        /// <summary>
        /// Representa la capacidad de pasajeros de un vehiculo.
        /// </summary>
        public int PassengerCapacity { get; set; }
        /// <summary>
        /// Representa el tipo de vehiculo.
        /// </summary>
        public string VehicleType { get; set; }
        /// <summary>
        /// Representa la imagen del vehiculo.
        /// </summary>
        public string Image { get; set; }
        /// <summary>
        /// Representa la descripcion del vehiculo.
        /// </summary>
        public string Description { get; set; }
    }
}
