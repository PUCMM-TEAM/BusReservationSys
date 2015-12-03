using System;

namespace BRS.Core.Models {
  /// <summary>
  /// Clase abstracta de una entidad
  /// </summary>
  public abstract class Entity{
    /// <summary>
    /// Representa el id de la entidad.
    /// </summary>
    public int ID { get; set; }
    /// <summary>
    /// Representa la fecha de creacion.
    /// </summary>
    public DateTime CreatedDate { get; set; }
    /// <summary>
    /// Representa la fecha de modificacion.
    /// </summary>
    public DateTime ModifiedDate { get; set; }
    /// <summary>
    /// Representa si la entidad se eliminara.
    /// </summary>
    public bool Deleted { get; set; }
  }
}
