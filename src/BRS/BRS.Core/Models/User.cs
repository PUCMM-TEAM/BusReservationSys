namespace BRS.Core.Models {
  public class User : Entity {
    public string Username { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public Role Role { get; set; }
    public Customer Customer { get; set; }
  }
}
