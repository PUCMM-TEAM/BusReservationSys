namespace BRS.Core.Models {
  /// <summary>
  /// Clase representativa de una entidad de tarjerta de credito.
  /// </summary>
  public class CreditCard : Entity {
    /// <summary>
    /// Representa el duenio de la tarjeta.
    /// </summary>
    public string CardHolder { get; set; }
    /// <summary>
    /// Representa el numero de tarjeta.
    /// </summary>
    public string CardNumber { get; set; }
    /// <summary>
    /// Representa el CVC de la tarjeta.
    /// </summary>
    public string CVC { get; set; }
    /// <summary>
    /// Representa la fecha de expiracion de la tarjeta.
    /// </summary>
    public int ExpirationDate { get; set; }
  }
}
