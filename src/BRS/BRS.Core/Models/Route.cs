namespace BRS.Core.Models
{
    /// <summary>
    /// Clase representativa de la entidad ruta.
    /// </summary>
    public class Route : Entity{
        /// <summary>
        /// Representa un destino de origen.
        /// </summary>
        public virtual Destination Pickup { get; set; }
        /// <summary>
        /// Representa un destino final.
        /// </summary>
        public virtual Destination DropOff { get; set; }

        /// <summary>
        /// Representa el  nombre de una ruta.
        /// </summary>
        public string RouteName { get { return Pickup.Name + " - " + DropOff.Name; } }
    }
}
