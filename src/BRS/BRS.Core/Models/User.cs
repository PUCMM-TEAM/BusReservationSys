namespace BRS.Core.Models {
  /// <summary>
  /// Clase representativa de la entidad usuario.
  /// </summary>
  public class User : Entity {
    /// <summary>
    /// Representa el nombre de usuario.
    /// </summary>
    public string Username { get; set; }
    /// <summary>
    /// Representa la contrasena del usuario.
    /// </summary>
    public string Password { get; set; }
    /// <summary>
    /// Representa el E-mail del usuario.
    /// </summary>
    public string Email { get; set; }
    /// <summary>
    /// Representa el rol del usuario.
    /// </summary>
    public Role Role { get; set; }
    /// <summary>
    /// Representa un cliente.
    /// </summary>
    public Customer Customer { get; set; }
  }
}
