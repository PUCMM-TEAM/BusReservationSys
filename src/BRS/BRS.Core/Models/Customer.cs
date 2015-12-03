using System;
using System.Collections.Generic;

namespace BRS.Core.Models
{
  /// <summary>
  /// Clase representativa de la entidad cliente.
  /// </summary>  
  public class Customer : Entity{
        /// <summary>
        /// Representa el nombre del cliente.
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Representa el apellido del cliente.
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Representa la fecha de cumpleanios del cliente.
        /// </summary>
        public DateTime Birthday { get; set; }
        /// <summary>
        /// Representa la tarjeta de credito del cliente.
        /// </summary>
        public CreditCard CreditCard { get; set; } 
    }
}
